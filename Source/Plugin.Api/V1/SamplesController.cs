﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpDelete, Route("{sampleId:guid}")]
        public async Task<IActionResult> DeleteSample(Guid sampleId)
        {
            if (sampleId == default(Guid))
                return BadRequest(sampleId);

            await sampleCrudService.DeleteSample(sampleId);

            return Ok(sampleId);
        }

        [HttpPut, Route("{sampleId:guid}")]
        public async Task<IActionResult> UpdateSample(Guid sampleId, SampleViewModel model)
        {
            if (sampleId == default(Guid))
                return BadRequest(sampleId);

            model.Id = sampleId;

            await sampleCrudService.UpdateSample(model.ToSampleDto());

            return Ok(model);
        }
    }
}
