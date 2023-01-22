# CSGO-GSI
A minimal console application that I use as a base for csgo game state integration. This app was made because I found it difficult to view data about my flashes and had to rely on "feeling" to see how effective they were. With this you will now get detailed breakdowns for flashes that blind you. Here's an example of the output
```
CSGO Flashbang Helper Is Now Running
Total Flash Duration: 3.25 Seconds
Peak Flash Strength: 80.39%
Time At Peak Flash: 1.62 Seconds
Average Flash Strength: 48.43%
Time At Or Above Average Flash: 1.62 Seconds
```
A direct flashbang will last a little more than 5 seconds total, most of this is at a strength that people can still easily see through. The peak stat for good flashbangs will always be 100% meaning full blind. you'll want to increase that time as much as possible. The mean average stat is just to show how blind the were most of the time, and how long that blindness lasted.

## Running
1. Download the release from the releases tab on the right.
2. Copy the gamestate_integration_flashhelper.cfg file into your csgo/cfg folder (e.g. C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\cfg).
3. Launch csgo.
4. Run the CSGO-GSI.exe inside the release folder.
5. Load into a map and improve your flashbang usage :)

## Building
1. Install the dotnet 7.0 sdk from microsoft (https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
2. run `dotnet restore` in the solution folder
3. run `dotnet publish -r win-x64 -c Release` in the solution folder

### side note
If you like this project I would very much so appreciate people spreading the word about two convars in the game that can get you banned by overwatch without any way to resolve them. These two are the `sensitivity` and `m_yaw` convars. As most people know the sensitivity convar is a multiplier for what csgo receives from your mouse. But m_yaw and m_pitch are the horizontal and vertical multiplies added on top of that. For most people using raw input on and mouse acceleration off, and not using a scoped weapon, then these are the only two modifiers for your mouse movement. The m_yaw and sensitivity products result in the total degrees you move your mouse horizontally. So if you move 1 "pixel" on your screen then the total number of degrees you move would look something like `1 px * 0.022 m_yaw * 1 sensitivity = 0.022 degree change`. This is where things get dangerous as the max value for m_yaw is set high at 1000. So using some simple math we can set our m_yaw to be a full 180 degrees by just entering `m_yaw 180` in console with a sensitivity of 1. You can't really aim like that though but when you move your mouse you will see the front and back of your view overlaying on each other. And if we look above we can see that our default is 0.022 m_yaw so now all we need to do is make sure that our m_yaw times our sensitivity equals 180.022. This gives us the ability to spin at ridiculously high rates but still be able to aim normally. Although roughly half your shots will go behind you.

I used this in a comp match when valve put me against some lower ranked players and quickly got banned by overwatch. With my appeal denied I'd like to share this knowledge with the community in hopes that valve will eventually repeal my ban. Valvo pls fix.

Formula for finding your m_yaw

180.022 / sensitivity = m_yaw

Copy Pastable Spinbot Values

`sensitivity 1; m_yaw 180.022`

`sensitivity 1.5; m_yaw 120.01466`

`sensitivity 2; m_yaw 90.011`

`sensitivity 2.5; m_yaw 72.0088` default csgo sensitivity

`sensitivity 4; m_yaw 45.0055`

Link to the bind in action: https://youtu.be/3NGBxfQDBHo?t=20

Link to my banned profile: https://steamcommunity.com/id/kidfearless/
