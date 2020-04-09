using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Plugin.Application.Contracts.OData.Part_1;
using Plugin.Application.Contracts.OData.Part_1.Dtos;
using System.Linq;

namespace Plugin.Api.OData.V1
{
    [Route("api/Samples")]
    [ApiController]
    public class SamplesOData : ODataController
    {
        private readonly ISamplesODataRepository repository;

        public SamplesOData(ISamplesODataRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet, EnableQuery]
        public IQueryable<SampleDto> GET_Query() => repository.GetSamplesQuery();
    }
}
