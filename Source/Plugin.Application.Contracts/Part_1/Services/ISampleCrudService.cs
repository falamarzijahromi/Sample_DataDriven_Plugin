using Plugin.Application.Contracts.Part_1.Dtos;
using System;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Plugin.Application.Contracts.Part_1.Services
{
    public interface ISampleCrudService
    {
        [PrincipalPermission(SecurityAction.Demand, Name = nameof(Permissions.DeleteSample))]
        Task DeleteSample(Guid id);
        Task<Guid> InsertSample(SampleDto dto);
        Task UpdateSample(SampleDto dto);
    }
}
