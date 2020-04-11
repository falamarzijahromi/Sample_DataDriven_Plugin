using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Contracts.Part_1.Services;
using Plugin.Application.Part_1.Repositories;
using System;
using System.Threading.Tasks;
using Framework.Consistency.Contracts.Eventual.Event;
using Plugin.Application.Part_1.Factories;
using Plugin.Application.Contracts.Part_1.Events.V_1._0._0;

namespace Plugin.Application.Part_1.Services
{
    public class SomethingElseService : ISomethingElseService
    {
        private readonly ISomethingElseRepository repository;
        private readonly IIntegrationEventContext eventCotnext;

        public SomethingElseService(ISomethingElseRepository repository, IIntegrationEventContext eventCotnext)
        {
            this.repository = repository;
            this.eventCotnext = eventCotnext;
        }

        public async Task<Guid> CraeteSomethingElse(SomethingElseDto dto)
        {
            var somethingElse = dto.ToSomethingElse();

            await repository.CreateSomethignElse(somethingElse);

            var sampleCreatedEvent = new SomethingElseCreatedEvent(somethingElse.Id);

            eventCotnext.AddEvents(sampleCreatedEvent);

            return somethingElse.Id;
        }
    }
}
