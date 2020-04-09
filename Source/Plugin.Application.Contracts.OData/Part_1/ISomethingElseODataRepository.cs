using Plugin.Application.Contracts.OData.Part_1.Dtos;
using System.Linq;
using System.Security.Permissions;

namespace Plugin.Application.Contracts.OData.Part_1
{
    public interface ISomethingElseODataRepository
    {
        [PrincipalPermission(SecurityAction.Demand, Name = nameof(Permissions.SomethingElseQuery))]
        IQueryable<SomethingElseDto> GetSomethingElseQuery();
    }
}
