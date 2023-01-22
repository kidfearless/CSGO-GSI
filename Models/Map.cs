using Newtonsoft.Json;
namespace CSGO_GSI.Models;

public partial struct Map
{
	[JsonProperty("mode")]
	public string Mode;

	[JsonProperty("name")]
	public string Name;

	[JsonProperty("phase")]
	public string Phase;

	[JsonProperty("round")]
	public short Round;

	[JsonProperty("team_ct")]
	public Team TeamCt;

	[JsonProperty("team_t")]
	public Team TeamT;

	[JsonProperty("num_matches_to_win_series")]
	public short NumMatchesToWinSeries;

	[JsonProperty("current_spectators")]
	public short CurrentSpectators;

	[JsonProperty("souvenirs_total")]
	public short SouvenirsTotal;
}


