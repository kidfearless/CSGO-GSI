using Newtonsoft.Json;
namespace CSGO_GSI.Models;

public partial struct Player
{
	[JsonProperty("steamid")]
	public string Steamid;

	[JsonProperty("name")]
	public string Name;

	[JsonProperty("observer_slot")]
	public short ObserverSlot;

	[JsonProperty("team")]
	public string Team;

	[JsonProperty("activity")]
	public string Activity;

	[JsonProperty("state")]
	public State State;

	[JsonProperty("weapons")]
	public Weapons Weapons;

	[JsonProperty("match_stats")]
	public MatchStats MatchStats;
}


