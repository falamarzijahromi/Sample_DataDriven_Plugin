using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plugin.Application.Part_1.Models;
using System;

namespace Plugin.Repositories.EFCore.Mappings.Part_1
{
    public class SomethingElseBySampleMapping : IEntityTypeConfiguration<SomethingElseBySample>
    {
        public void Configure(EntityTypeBuilder<SomethingElseBySample> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property<Guid>("sampleId");
        }
    }
}
