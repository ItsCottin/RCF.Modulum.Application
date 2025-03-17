using System.Text.Json;
using modulum.Application.Interfaces.Serialization.Options;

namespace modulum.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}