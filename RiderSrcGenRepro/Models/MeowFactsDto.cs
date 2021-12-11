using System.Text.Json.Serialization;

namespace RiderSrcGenRepro.Models;

public readonly struct MeowFactsDto
{
	[JsonPropertyName("data")]
	public string[] Data { get; }

	[JsonConstructor]
	public MeowFactsDto(string[] data)
	{
		Data = data;
	}
}