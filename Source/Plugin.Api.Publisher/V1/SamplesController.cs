using Framework.Consistency.Contracts.Eventual.Command;
using Microsoft.AspNetCore.Mvc;
using Plugin.Api.Publisher.ViewModels;
using System.Threading.Tasks;
using Plugin.Api.Publisher.Factories;

namespace Plugin.Api.Publisher
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private readonly ICommandBus commandBus;

        public SamplesController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSample(CreateSampleViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var commandRequestId = await commandBus.Publish(viewModel.ToCreateSampleCommand());

            return Ok(commandRequestId);
        }
    }
}
