using Newtonsoft.Json;
namespace CSGO_GSI.Models;

public partial struct Team
{
	[JsonProperty("score")]
	public short Score;

	[JsonProperty("consecutive_round_losses")]
	public short ConsecutiveRoundLosses;

	[JsonProperty("timeouts_remaining")]
	public short TimeoutsRemaining;

	[JsonProperty("matches_won_this_series")]
	public short MatchesWonThisSeries;
}


