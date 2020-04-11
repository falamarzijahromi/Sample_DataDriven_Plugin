using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Contracts.Part_1.Events.V_1._0._0;
using Plugin.Application.Contracts.Part_1.Services;
using Plugin.Application.Part_1.Factories;
using Plugin.Application.Part_1.Models;
using Plugin.Application.Part_1.Repositories;
using System;
using System.Threading.Tasks;
using Framework.Consistency.Contracts.Eventual.Event;

namespace Plugin.Application.Part_1.Services
{
    public class SampleCrudService : ISampleCrudService
    {
        private readonly ISampleCrudRepository repo;
        private readonly IIntegrationEventContext eventContext;

        public SampleCrudService(ISampleCrudRepository repo, IIntegrationEventContext eventContext)
        {
            this.repo = repo;
            this.eventContext = eventContext;
        }

        public async Task DeleteSample(Guid id)
        {
            var sample = new Sample
            {
                Id = id,
            };

            await repo.DeleteSample(sample);

            var deletedEvent = new SampleDeletedEvent(sample.Id);

            eventContext.AddEvents(deletedEvent);
        }

        public async Task<Guid> InsertSample(SampleDto dto)
        {
            var sample = dto.ToSample();

            await repo.InsertSample(sample);

            var createdEvent = new SampleCreatedEvent(sample.ToSampleDto());

            eventContext.AddEvents(createdEvent);

            return sample.Id;
        }

        public async Task UpdateSample(SampleDto dto)
        {
            var sample = await repo.GetSample(dto.Id);

            await repo.UpdateSample(dto.ToSample());

            var createdEvent = new SampleUpdatedEvent(dto.Id, sample.ToSampleDto(), dto);

            eventContext.AddEvents(createdEvent);
        }
    }
}
