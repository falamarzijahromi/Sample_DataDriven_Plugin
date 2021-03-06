﻿using System;
using Framework.Consistency.Contracts.Eventual.Event;

namespace Plugin.Application.Contracts.Part_1.Events.V_1._0._0
{
    [IntegrationEvent(version: null)]
    public class SampleDeletedEvent
    {
        public Guid SampleId { get; }

        public SampleDeletedEvent(Guid SampleId)
        {
            this.SampleId = SampleId;
        }
    }
}
