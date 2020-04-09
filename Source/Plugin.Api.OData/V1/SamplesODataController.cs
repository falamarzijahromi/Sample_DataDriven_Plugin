using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Plugin.Application.Contracts.OData.Part_1;
using Plugin.Application.Contracts.OData.Part_1.Dtos;
using System.Linq;

namespace Plugin.Api.OData.V1
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SamplesODataController : ODataController
    {
        private readonly ISamplesODataRepository repository;

        public SamplesODataController(ISamplesODataRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet, EnableQuery]
        public IQueryable<SampleDto> GetSamplesQuery() => repository.GetSamplesQuery();
    }
}
