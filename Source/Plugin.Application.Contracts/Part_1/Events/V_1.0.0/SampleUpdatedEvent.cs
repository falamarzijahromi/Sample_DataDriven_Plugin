using Plugin.Application.Contracts.Part_1.Dtos;
using System;
using Framework.Consistency.Contracts.Eventual.Event;

namespace Plugin.Application.Contracts.Part_1.Events.V_1._0._0
{
    [IntegrationEvent(version: null)]
    public class SampleUpdatedEvent
    {
        public Guid SampleId { get; }
        public SampleDto LastState { get; }
        public SampleDto CurrentState { get; }

        public SampleUpdatedEvent(Guid sampleId, SampleDto lastState, SampleDto currentState)
        {
            SampleId = sampleId;
            LastState = lastState;
            CurrentState = currentState;
        }
    }
}
