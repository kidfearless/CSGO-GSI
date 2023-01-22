using Newtonsoft.Json;
namespace CSGO_GSI.Models;


public partial struct GameStateResponse
{
	[JsonProperty("provider")]
	public Provider Provider;

	[JsonProperty("map")]
	public Map Map;

	[JsonProperty("player")]
	public Player Player;
}

public partial struct State
{
	[JsonProperty("health")]
	public short Health;

	[JsonProperty("armor")]
	public short Armor;

	[JsonProperty("helmet")]
	public bool Helmet;

	[JsonProperty("flashed")]
	public short Flashed;

	[JsonProperty("smoked")]
	public short Smoked;

	[JsonProperty("burning")]
	public short Burning;

	[JsonProperty("money")]
	public ushort Money;

	[JsonProperty("round_kills")]
	public short RoundKills;

	[JsonProperty("round_killhs")]
	public short RoundKillhs;

	[JsonProperty("equip_value")]
	public short EquipValue;
}

public partial struct Weapons
{
	[JsonProperty("weapon_0")]
	public Weapon Weapon0;

	[JsonProperty("weapon_1")]
	public Weapon Weapon1;
}

public partial struct Weapon
{
	[JsonProperty("name")]
	public string Name;

	[JsonProperty("paintkit")]
	public string PaintKit;

	[JsonProperty("type")]
	public string Type;

	[JsonProperty("state")]
	public string State;

	[JsonProperty("ammo_clip")]
	public short? AmmoClip;

	[JsonProperty("ammo_clip_max")]
	public short? AmmoClipMax;

	[JsonProperty("ammo_reserve")]
	public short? AmmoReserve;

}

public partial struct Provider
{
	[JsonProperty("name")]
	public string Name;

	[JsonProperty("appid")]
	public short Appid;

	[JsonProperty("version")]
	public int Version;

	[JsonProperty("steamid")]
	public string Steamid;

	[JsonProperty("timestamp")]
	public ulong Timestamp;
}


