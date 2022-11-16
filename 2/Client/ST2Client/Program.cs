namespace ST2Client
{
    internal static class Program
    {
        public static string HOST = "https://localhost:7086/chatHub";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}