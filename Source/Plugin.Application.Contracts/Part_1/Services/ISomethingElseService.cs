using Plugin.Application.Contracts.Part_1.Dtos;
using System;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Plugin.Application.Contracts.Part_1.Services
{
    public interface ISomethingElseService
    {
        [PrincipalPermission(SecurityAction.Demand, Name = nameof(Permissions.CreateSomethingElse))]
        Task<Guid> CraeteSomethingElse(SomethingElseDto dto);
    }
}
