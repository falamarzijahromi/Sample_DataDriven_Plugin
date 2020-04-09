using Microsoft.Extensions.DependencyInjection;
using Plugin.Application.Contracts.OData.Part_1;
using Plugin.Application.Contracts.Part_1.Services;
using Plugin.Application.Part_1.Repositories;
using Plugin.Application.Part_1.Services;
using Plugin.Repositories.EFCore.DataBase;
using Plugin.Repositories.EFCore.ODataRepos;
using Plugin.Repositories.EFCore.Part_1;

namespace Plugin.Composition
{
    public static class CompositionRoot
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            RegisterApplicationServices(services);

            RegisterRepositories(services);

            RegisterODataRepositories(services);

            RegisterAcls(services);

            RegisterDataContext(services);
        }

        private static void RegisterAcls(IServiceCollection services)
        {
        }

        private static void RegisterODataRepositories(IServiceCollection services)
        {
            services.AddScoped<ISamplesODataRepository, SampleODataRepository>();
            services.AddScoped<ISomethingElseODataRepository, SomethingElseODataRepository>();
        }

        private static void RegisterDataContext(IServiceCollection services)
        {
            services.AddScoped<DataContext>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ISampleCrudRepository, SampleCrudRepository>();
            services.AddScoped<ISomethingElseRepository, SomethingElseRepository>();
        }

        private static void RegisterApplicationServices(IServiceCollection services)
        {
            services.AddScoped<ISampleCrudService, SampleCrudService>();
            services.AddScoped<ISomethingElseService, SomethingElseService>();
        }
    }
}
