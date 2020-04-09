using Framework.Consistency.Contracts.Eventual;
using Plugin.Application.Contracts.Part_1.Dtos;

namespace Plugin.Application.Contracts.Part_1.Events.V_1._0._0
{
    [IntegrationEvent(version: "1.0.0")]
    public class SampleCreatedEvent
    {
        public SampleDto Sample { get; }

        public SampleCreatedEvent(SampleDto sample)
        {
            Sample = sample;
        }
    }
}
