using Plugin.Application.Part_1.Models;
using Plugin.Application.Part_1.Repositories;
using Plugin.Repositories.EFCore.DataBase;
using System.Threading.Tasks;

namespace Plugin.Repositories.EFCore.Part_1
{
    public class SomethingElseRepository : ISomethingElseRepository
    {
        private readonly DataContext dbContext;

        public SomethingElseRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateSomethignElse(SomethingElseBySample somethingElse)
        {
            dbContext.Set<SomethingElseBySample>().Add(somethingElse);

            return Task.CompletedTask;
        }
    }
}
