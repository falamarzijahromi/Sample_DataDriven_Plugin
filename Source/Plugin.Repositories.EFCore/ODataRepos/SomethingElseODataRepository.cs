using Plugin.Application.Contracts.OData.Part_1;
using Plugin.Application.Contracts.OData.Part_1.Dtos;
using Plugin.Repositories.EFCore.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Plugin.Repositories.EFCore.ODataRepos
{
    public class SomethingElseODataRepository : ISomethingElseODataRepository
    {
        private readonly DataContext dbContext;

        public SomethingElseODataRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<SomethingElseDto> GetSomethingElseQuery()
        {
            return dbContext.Set<SomethingElseDto>().FromSqlRaw("SELECT * FROM SOMETHINGELSEBYSAMPLES");
        }
    }
}
