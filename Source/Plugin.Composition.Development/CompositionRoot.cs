using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Plugin.Repositories.EFCore.DataBase;
using System.Linq;
using Framework.Consistency.Contracts.Eventual.Event;

namespace Plugin.Composition.Development
{
    public static class CompositionRoot
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            Composition.CompositionRoot.RegisterDependencies(services);

            OverrideDataContextRegistration(services);
        }

        private static void RemoveEventBus(IServiceCollection services)
        {
            var eventBusServiceDescriptor = services.Single(sd => sd.ServiceType == typeof(IEventBus));

            services.Remove(eventBusServiceDescriptor);
        }

        private static void OverrideDataContextRegistration(IServiceCollection services)
        {
            var dataContextServiceDescriptor = services.Single(sd => sd.ServiceType == typeof(DataContext));

            services.Remove(dataContextServiceDescriptor);

            services.AddScoped(_ =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

                optionsBuilder.UseInMemoryDatabase("Plugin.Development");

                var dataContext = new DataContext(optionsBuilder.Options);

                dataContext.Database.EnsureCreated();

                return dataContext;
            });
        }
    }
}
