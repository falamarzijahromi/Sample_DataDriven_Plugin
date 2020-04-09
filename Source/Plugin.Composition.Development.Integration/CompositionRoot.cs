using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Plugin.Repositories.EFCore.DataBase;

namespace Plugin.Composition.Development
{
    public static class CompositionRoot
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            Composition.CompositionRoot.RegisterDependencies(services);

            services.AddScoped(_ =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

                optionsBuilder.UseInMemoryDatabase("Plugin.Develpment");

                var dataContext = new DataContext(optionsBuilder.Options);

                dataContext.Database.EnsureCreated();

                return dataContext;
            });
        }
    }
}
