
using modulum.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace modulum.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}