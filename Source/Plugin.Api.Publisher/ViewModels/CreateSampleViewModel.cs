using System.ComponentModel.DataAnnotations;

namespace Plugin.Api.Publisher.ViewModels
{
    public class CreateSampleViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
