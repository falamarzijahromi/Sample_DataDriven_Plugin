using Plugin.Api.Publisher.ViewModels;
using Plugin.Application.Contracts.Part_1.Commands;
using Mapster;

namespace Plugin.Api.Publisher.Factories
{
    public static class CreateSampleViewModelFactoryExtensions
    {
        public static CreateSampleCommand ToCreateSampleCommand(this CreateSampleViewModel model) => model.Adapt<CreateSampleCommand>();
    }
}
