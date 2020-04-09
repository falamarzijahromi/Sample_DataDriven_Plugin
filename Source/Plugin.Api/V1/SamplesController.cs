using Microsoft.AspNetCore.Mvc;
using Plugin.Api.ViewModels;
using Plugin.Application.Contracts.Part_1.Services;
using System;
using System.Threading.Tasks;
using Plugin.Api.Factories;

namespace Plugin.Api.V1
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private readonly ISampleCrudService sampleCrudService;

        public SamplesController(ISampleCrudService sampleCrudService)
        {
            this.sampleCrudService = sampleCrudService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSample(SampleViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var createdId = await sampleCrudService.InsertSample(model.ToSampleDto());

            model.Id = createdId;

            return Created(Request.Path, model);
        }

        [HttpDelete, Route("{sampleId:guid}")]
        public async Task<IActionResult> DeleteSample(Guid sampleId)
        {
            if (sampleId == default)
                return BadRequest(sampleId);

            await sampleCrudService.DeleteSample(sampleId);

            return Ok(sampleId);
        }

        [HttpPut, Route("{sampleId:guid}")]
        public async Task<IActionResult> DeleteSample(Guid sampleId, SampleViewModel model)
        {
            if (sampleId == default)
                return BadRequest(sampleId);

            model.Id = sampleId;

            await sampleCrudService.DeleteSample(sampleId);

            return Ok(model);
        }
    }
}
