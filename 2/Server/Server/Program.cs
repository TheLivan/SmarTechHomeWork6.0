using Server.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();
app.MapGet("/", () => "SERVER IS WORKING...");
app.MapHub<ChatHub>("/chatHub");
app.Run();
