using Plugin.Application.Contracts.OData.Part_1;
using Plugin.Application.Contracts.OData.Part_1.Dtos;
using Plugin.Application.Part_1.Models;
using Plugin.Repositories.EFCore.DataBase;
using System.Linq;

namespace Plugin.Repositories.EFCore.ODataRepos
{
    public class SampleODataRepository : ISamplesODataRepository
    {
        private readonly DataContext dbContext;

        public SampleODataRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<SampleDto> GetSamplesQuery()
        {
            return dbContext.Set<Sample>()
                .Select(s => new SampleDto
                {
                    Id = s.Id,
                    Name = s.Name,
                });
        }
    }
}
