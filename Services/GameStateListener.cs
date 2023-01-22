using CSGO_GSI.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_GSI.Services;



public class GameStateListener : IDisposable
{
	private readonly HttpListener _listener;
	public event Action<GameStateResponse, string>? GameEvent;
	private bool _isDisposed;
	public static GameStateResponse State;
	public GameStateListener(int port = 3000, string host = "127.0.0.1")
	{
		// start up a new udp listener on port 3000
		_listener = new HttpListener();
		_listener.Prefixes.Add($"http://{host}:{port}/");
	}

	private void StartListening()
	{
		while (!_isDisposed)
		{
			try
			{
				var context = _listener.GetContext();
				Tick(context);
			}
			catch (Exception ex)
			{
				Debugger.Break();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex.Message);
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
	}

	private void Tick(HttpListenerContext context)
	{
		var inputStream = context.Request.InputStream;
		Span<byte> bytes = stackalloc byte[(int)context.Request.ContentLength64];
		var read = inputStream.Read(bytes);
		var body = Encoding.Default.GetString(bytes);
		State = JsonConvert.DeserializeObject<GameStateResponse>(body);
		GameEvent?.Invoke(State, body);
	}

	public void Start()
	{
		_listener.Start();
		Console.WriteLine("CSGO Flashbang Helper Is Now Running");
		StartListening();
	}

	public void Stop()
	{
		_listener.Stop();
	}

	public void Dispose()
	{
		_isDisposed = true;
		_listener.Close();
	}
}
