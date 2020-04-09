using Plugin.Application.Part_1.Models;
using System;
using System.Threading.Tasks;

namespace Plugin.Application.Part_1.Repositories
{
    public interface ISampleCrudRepository
    {
        Task<Sample> GetSample(Guid id);
        Task InsertSample(Sample sample);
        Task DeleteSample(Sample sample);
        Task UpdateSample(Sample sample);
    }
}
