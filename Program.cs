using CSGO_GSI.Models;
using CSGO_GSI.Services;

short lastFlash = 0;
DateTime startTime = DateTime.Now;

List<short> flashTicks = new List<short>(5 * 128);


using var gameStateListener = new GameStateListener();
gameStateListener.GameEvent += OnClientTick;
gameStateListener.Start();

void OnClientTick(GameStateResponse obj, string body)
{
	var flashed = obj.Player.State.Flashed;
	if (flashed > 0 && lastFlash == 0)
	{
		flashTicks.Clear();
		flashTicks.Add(flashed);
		startTime = DateTime.Now;
	}

	if (flashed > 0)
	{
		flashTicks.Add(flashed);
	}


	if (flashed == 0 && lastFlash > 0)
	{
		// on end
		var time = DateTime.Now - startTime;
		var max = flashTicks.Max();
		var maxTicks = flashTicks.Count(x => x == max);
		var frameTime = time.TotalMilliseconds / flashTicks.Count;

		var maxTime = TimeSpan.FromMilliseconds(maxTicks * frameTime);
		var avg = flashTicks.Average(x => x);
		var avgTicks = flashTicks.Count(x => x >= avg);
		var avgTime = TimeSpan.FromMilliseconds(avgTicks * frameTime);

		Console.WriteLine($"Total Flash Duration: {time.TotalSeconds:F2} Seconds\n" +
			$"Peak Flash Strength: {max / 255.0 * 100.0:F2}%\n" +
			$"Time At Peak Flash: {maxTime.TotalSeconds:F2} Seconds\n" +
			$"Average Flash Strength: {avg / 255.0 * 100.0:F2}%\n" +
			$"Time At Or Above Average Flash: {avgTime.TotalSeconds:F2} Seconds\n");
	}

	lastFlash = flashed;
}