using System.Text.Json.Serialization;
using RiderSrcGenRepro.Models;

namespace RiderSrcGenRepro.JSON;

[JsonSerializable(typeof(MeowFactsDto))]
public partial class MeowFactsSerializerContext : JsonSerializerContext
{
}