using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Plugin.Repositories.EFCore.DataBase;

namespace Just_For_EFCore
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {

            var connectionBuilder = new SqlConnectionStringBuilder();

            connectionBuilder.DataSource = ".";
            connectionBuilder.InitialCatalog = "PluginDb";
            connectionBuilder.IntegratedSecurity = true;

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            optionsBuilder.UseSqlServer(connectionBuilder.ConnectionString, options =>
            {
                options.MigrationsHistoryTable("Plugin_Migration_Table");
            });

            return new DataContext(optionsBuilder.Options);
        }
    }
}
