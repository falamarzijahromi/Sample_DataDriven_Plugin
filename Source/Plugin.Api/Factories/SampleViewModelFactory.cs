using Plugin.Api.ViewModels;
using Plugin.Application.Contracts.Part_1.Dtos;
using Mapster;

namespace Plugin.Api.Factories
{
    public static class SampleViewModelFactoryExtensions
    {
        public static SampleDto ToSampleDto(this SampleViewModel model) => model.Adapt<SampleDto>();
    }
}
