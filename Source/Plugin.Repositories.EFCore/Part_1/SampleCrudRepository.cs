using Plugin.Application.Part_1.Models;
using Plugin.Application.Part_1.Repositories;
using Plugin.Repositories.EFCore.DataBase;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Plugin.Repositories.EFCore.Part_1
{
    public class SampleCrudRepository : ISampleCrudRepository
    {
        private readonly DataContext dbContext;

        public SampleCrudRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task DeleteSample(Sample sample)
        {
            dbContext.Set<Sample>().Remove(sample);

            return Task.CompletedTask;
        }

        public async Task<Sample> GetSample(Guid id)
        {
            return await dbContext.Set<Sample>().SingleAsync(s => s.Id == id);
        }

        public async Task InsertSample(Sample sample)
        {
            await dbContext.Set<Sample>().AddAsync(sample);
        }

        public Task UpdateSample(Sample sample)
        {
            dbContext.Set<Sample>().Update(sample);

            return Task.CompletedTask;
        }
    }
}
