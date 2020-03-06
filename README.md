# Windows Audio Switcher - Standalone

* This is a newer version than  "luizbossoi/windows-audio-switcher", an "all-in-one" solution and does not depend on any additional software *

-----
##

This software was made to help users switching the default output audio device on Windows based on the working process.
One of many cases of use: you have two (or more) audio output devices on Windows, a desktop audio speakers and a headset. You're the kind of person that likes to hear music on your computer using your desktop desk speakers, but sometimes you like to play games using your headset. Everytime you need to change your audio output, and that's what this application does!
You can configure a set of processes that you wish to change automaticaly the audio output for you and when you're not using those processes, your audio output will be set as default back again.


## How to use
Open the process you want to make it switch, for example, open PUBG Lite, or another software you wish. Once opened, click on the "+" button, find your process in the list, select your preferred audio device to switch and save! That's it.

If you just want to use this software, just the latest release from https://github.com/luizbossoi/windows-audio-switcher-standalone/releases


## How does it work?
When you start to use the specified process (on foreground), this software will get this information and switch the default audio output for you.

![application main screen](https://github.com/luizbossoi/windows-audio-switcher-standalone/blob/master/img/screenshot.png?raw=true)

## Does it work on background or start on boot?
You can configure it to start on boot, just tick the box "Start on Boot".
This also can run on background, just minimize the application.

## Why does it ask elevation as administrator?
Some processes started as administrator does not allow this software to monitor the process state, in that case it will not be possible to make it work with all processes. For example, PUBG LITE is a game that starts elevated (as administrator), it would not be possible to check this process from this application running in user-mode.


Tested on Windows 10, only
