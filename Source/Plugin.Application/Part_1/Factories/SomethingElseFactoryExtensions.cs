using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Part_1.Models;

namespace Plugin.Application.Part_1.Factories
{
    public static class SomethingElseFactoryExtensions
    {
        public static SomethingElseBySample ToSomethingElse(this SomethingElseDto dto) => new SomethingElseBySample(dto.Id);
    }
}
