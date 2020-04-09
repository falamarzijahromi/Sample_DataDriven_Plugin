using Plugin.Application.Contracts.Part_1.Dtos;
using Plugin.Application.Part_1.Models;
using System.Collections.Generic;
using Mapster;
using System.Linq;

namespace Plugin.Application.Part_1.Factories
{
    public static class SampleDtoFactoryExtensions
    {
        public static SampleDto ToSampleDto(this Sample sample) => sample.Adapt<SampleDto>();

        public static List<SampleDto> ToSampleDtos(this List<Sample> samples) => samples.Select(s => s.ToSampleDto()).ToList();

        public static Sample ToSample(this SampleDto sampleDto) => sampleDto.Adapt<Sample>();

        public static List<Sample> ToSamples(this List<SampleDto> sampleDtos) => sampleDtos.Select(s => s.ToSample()).ToList();
    }
}
