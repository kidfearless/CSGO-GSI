using Newtonsoft.Json;
namespace CSGO_GSI.Models;

public partial struct MatchStats
{
	[JsonProperty("kills")]
	public short Kills;

	[JsonProperty("assists")]
	public short Assists;

	[JsonProperty("deaths")]
	public short Deaths;

	[JsonProperty("mvps")]
	public short Mvps;

	[JsonProperty("score")]
	public short Score;
}


