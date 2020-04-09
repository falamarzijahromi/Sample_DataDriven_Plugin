using Framework.Consistency.Contracts.Eventual;
using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Contracts.Part_1.Events.V_1._0._0;
using Plugin.Application.Contracts.Part_1.Services;
using System.Threading.Tasks;

namespace Plugin.Application.EventHandlers.Part_1.V1
{
    [ForIntegrationEvent(typeof(SampleCreatedEvent), eventVersion: "1.0.0")]
    public class CreateSampleForSomethingElseEventHandler
    {
        private readonly ISomethingElseService somethingElseService;

        public CreateSampleForSomethingElseEventHandler(ISomethingElseService somethingElseService)
        {
            this.somethingElseService = somethingElseService;
        }

        public async Task HandleEventAsync(SampleCreatedEvent @event)
        {
            var somethingElseDto = new SomethingElseDto { SampleId = @event.Sample.Id };

            await somethingElseService.CraeteSomethingElse(somethingElseDto);
        }
    }
}
