using System;
using System.ComponentModel.DataAnnotations;

namespace Plugin.Api.ViewModels
{
    public class SampleViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
