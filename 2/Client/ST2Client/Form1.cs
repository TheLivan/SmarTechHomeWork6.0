using Microsoft.AspNetCore.SignalR.Client;

/*
 * Не очень понимаю что конкретно от функционала требуется. 
 * Должно ли быть постоянное подключение, или только при нажатии кнопки.
 * Сделал постоянное, только после отправки.
 * Нарушен принцип единой ответственности, но в такой маленькой программе эт не страшно)
 * @TheLivan
 */
namespace ST2Client
{
    public partial class Form1 : Form
    {
        HubConnection connection;

        public Form1()
        {
            InitializeComponent();

            connection = new HubConnectionBuilder()
                .WithUrl(Program.HOST)
                .Build();

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
            };

            connection.On<string>("ReceiveMessage", (message) =>
            {
                this.label3.Invoke(new Action(() => label3.Text = message));
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == HubConnectionState.Disconnected)
            {
                try
                {
                    this.label3.Text = "Connecting...";
                    await connection.StartAsync();
                    this.label3.Text = "Connection started";
                }
                catch (Exception ex)
                {
                    this.label3.Text = "No connection to server";
                }
            }
            
            if (connection.State == HubConnectionState.Connected)
            {
                try
                {
                    await connection.InvokeAsync("SendMessage", textBox1.Text);
                }
                catch (Exception ex)
                {
                    this.label3.Text = ex.Message;
                }
            }
        }
    }
}