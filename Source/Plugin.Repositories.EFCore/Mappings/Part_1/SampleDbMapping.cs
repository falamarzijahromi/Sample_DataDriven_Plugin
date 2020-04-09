using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plugin.Application.Part_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.Repositories.EFCore.Mappings.Part_1
{
    public class SampleDbMapping : IEntityTypeConfiguration<Sample>
    {
        public void Configure(EntityTypeBuilder<Sample> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired();                
        }
    }
}
