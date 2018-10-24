[![Build status](https://ci.appveyor.com/api/projects/status/6hh4634tssym3660?svg=true)](https://ci.appveyor.com/project/puckzxz/slvod)
[![CodeFactor](https://www.codefactor.io/repository/github/puckzxz/slvod/badge)](https://www.codefactor.io/repository/github/puckzxz/slvod)
[![GitHub license](https://img.shields.io/github/license/puckzxz/slvod.svg)](https://github.com/puckzxz/slvod/blob/master/LICENSE)
# slvod
A simple application to make watching Twitch VOD's with streamlink easier

## What?
slvod is a very simple application to assist watching Twitch VOD's using streamlink.  Normally to watch a VOD through streamlink you would need to use the command line.  While streamlink-GUI exists it does not currently supoprt watching VOD's.  This application serves as a middle ground to launch streamlink to watch VOD's.

## Why?
Twitch's player for watching a VOD is laggy and unuseable.  It frequently buffers even at 160p when a live broadcast plays fine at 1080p/60fps. This application will allow you to bypass Twitch's player and stream the VOD in your player of choice for a better viewing experience.

## How do I use it?
### Prerequisites
Ensure [streamlink](https://streamlink.github.io/) is installed and is in your PATH

### Building
You will need
* Visual Studio 2017
* .NET 4.7.2

Open `slvod.sln` and build in `Release` mode

### Running
Once you build the application and start it, you will be greeted with this

![slvod](https://i.imgur.com/8wnMWrd.png)

Click the button in the bottom-left to set your player path.

These are the recommended players as they support HLS passthrough

* [MPV](https://mpv.io/)
* [MPC-HC](https://github.com/clsid2/mpc-hc)
* [VLC](https://www.videolan.org/vlc/)

Once you set your player, paste your VOD URL and then press **Start Player** to launch

Your player will launch and the VOD will start playing