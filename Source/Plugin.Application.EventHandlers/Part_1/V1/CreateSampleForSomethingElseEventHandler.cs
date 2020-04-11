using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Contracts.Part_1.Events.V_1._0._0;
using Plugin.Application.Contracts.Part_1.Services;
using System.Threading.Tasks;
using Framework.Consistency.Contracts.Eventual.Event;

namespace Plugin.Application.EventHandlers.Part_1.V1
{
    [ForIntegrationEvent(typeof(SampleCreatedEvent), eventVersion: null)]
    public class CreateSampleForSomethingElseEventHandler
    {
        private readonly ISomethingElseService somethingElseService;

        public CreateSampleForSomethingElseEventHandler(ISomethingElseService somethingElseService)
        {
            this.somethingElseService = somethingElseService;
        }

        public async Task HandleEvent(SampleCreatedEvent @event)
        {
            var somethingElseDto = new SomethingElseDto { SampleId = @event.Sample.Id };

            await somethingElseService.CraeteSomethingElse(somethingElseDto);
        }
    }
}
