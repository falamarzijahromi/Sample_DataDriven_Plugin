using System;

namespace Plugin.Application.Part_1.Models
{
    public class Sample
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
