using Microsoft.EntityFrameworkCore;
using ENSPRONET.Domains.Domains;
namespace ENSPRONET.Services.Context;

public class ENSPRONETContext : DbContext
{
    public string DbPath { get; }
    public DbSet<Country> Countries { get; set; }

    public ENSPRONETContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "ENSPRONET.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite($"Data Source={DbPath}");
}
