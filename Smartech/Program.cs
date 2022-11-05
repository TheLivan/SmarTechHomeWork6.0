using Smartech.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

using var db = new SampleContext();
if (db.Languages.ToList().Count == 0)
{
    db.Add(new Languages { Lang = "ru", Message = "Привет" });
    db.Add(new Languages { Lang = "en", Message = "Hi" });
    db.Add(new Languages { Lang = "by", Message = "Вiтаю" });
    db.Add(new Languages { Lang = "es", Message = "Hola" });
    db.Add(new Languages { Lang = "fr", Message = "Salut" });
    db.SaveChanges();
}

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
   name: "default",
   pattern: "{controller=Index}/{action=Index}");

app.Run();

//TheLivan
//Комментарии не пишу, не вижу смысла, тут пару классов) Можно же разобраться