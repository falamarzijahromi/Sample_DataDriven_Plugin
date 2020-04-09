using Framework.Consistency.Contracts.Eventual;
using Plugin.Application.Contracts.Part_1.Commands;
using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Contracts.Part_1.Services;
using System.Threading.Tasks;

namespace Plugin.Application.Part_1.CommandHandlers
{
    [ForCommand(typeof(CreateSampleCommand), version: "1.0.0")]
    public class CreateSampleCommandHandler
    {
        private readonly ISampleCrudService service;

        public CreateSampleCommandHandler(ISampleCrudService service)
        {
            this.service = service;
        }

        public async Task HandleCommandAsync(CreateSampleCommand command)
        {
            var sampleDto = new SampleDto { Name = command.Name };

            await service.InsertSample(sampleDto);
        }
    }
}
