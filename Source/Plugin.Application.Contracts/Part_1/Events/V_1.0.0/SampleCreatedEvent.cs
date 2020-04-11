using Framework.Consistency.Contracts.Eventual.Event;
using Plugin.Application.Contracts.Part_1.Dtos;

namespace Plugin.Application.Contracts.Part_1.Events.V_1._0._0
{
    [IntegrationEvent(version: null)]
    public class SampleCreatedEvent
    {
        public SampleDto Sample { get; }

        public SampleCreatedEvent(SampleDto sample)
        {
            Sample = sample;
        }
    }
}
