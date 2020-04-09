using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Part_1.Models;
using Mapster;

namespace Plugin.Application.Part_1.Factories
{
    public static class SomethingElseFactoryExtensions
    {
        public static SomethingElseBySample ToSomethingElse(this SomethingElseDto dto) => dto.Adapt<SomethingElseBySample>();
    }
}
