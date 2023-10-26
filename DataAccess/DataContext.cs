using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SendSMS.Provider.Factory.Models;
using System.Configuration;

namespace SendSMS.Provider.Factory.DataAccess;

public class DataContext : DbContext
{
    public DataContext(){}
    public DbSet<UserModel> Users => Set<UserModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>()
            .HasKey(u => u.Id);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["mssqlConnection"].ToString());
     }
}
