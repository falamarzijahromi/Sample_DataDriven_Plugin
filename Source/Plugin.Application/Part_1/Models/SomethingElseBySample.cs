using System;

namespace Plugin.Application.Part_1.Models
{
    public class SomethingElseBySample
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public SomethingElseBySample(Guid sampleId)
        {
            this.sampleId = sampleId;
        }

        private readonly Guid sampleId;
    }
}
