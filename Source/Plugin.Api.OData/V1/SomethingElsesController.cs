using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Plugin.Application.Contracts.OData.Part_1;
using Plugin.Application.Contracts.OData.Part_1.Dtos;
using System.Linq;

namespace Plugin.Api.OData.V1
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SomethingElsesController : ODataController
    {
        private readonly ISomethingElseODataRepository repository;

        public SomethingElsesController(ISomethingElseODataRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet, EnableQuery]
        public IQueryable<SomethingElseDto> GetSomethingElseQuery() => repository.GetSomethingElseQuery();
    }
}
