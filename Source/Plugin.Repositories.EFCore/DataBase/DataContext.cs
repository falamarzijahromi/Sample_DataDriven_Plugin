using Microsoft.EntityFrameworkCore;

namespace Plugin.Repositories.EFCore.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public override void Dispose()
        {
            try
            {
                var connection = base.Database.GetDbConnection();

                if (connection != null)
                {
                    if (connection?.State != System.Data.ConnectionState.Closed)
                    {
                        connection?.Close();
                    }

                    connection.Dispose();
                }
            }
            catch (System.Exception)
            {
            }

            base.Dispose();
        }
    }
}
