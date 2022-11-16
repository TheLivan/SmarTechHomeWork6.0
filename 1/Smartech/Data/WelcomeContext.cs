using Microsoft.EntityFrameworkCore;

namespace Smartech.Data
{
    public class SampleContext : DbContext
    {
        public string DbPath { get; }

        public SampleContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "welcome.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Languages> Languages { get; set; }
    }
}
