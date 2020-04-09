using Plugin.Application.Contracts.OData.Part_1.Dtos;
using System.Linq;
using System.Security.Permissions;

namespace Plugin.Application.Contracts.OData.Part_1
{
    public interface ISamplesODataRepository
    {
        [PrincipalPermission(SecurityAction.Demand, Name = nameof(Permissions.SampleQuery))]
        IQueryable<SampleDto> GetSamplesQuery();
    }
}
