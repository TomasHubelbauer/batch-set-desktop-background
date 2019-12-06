# Batch Set Desktop Background

[**LIVE**](https://tomashubelbauer.github.io/batch-set-desktop-background)

This repository contains a Batch code snippet which demonstrates how to manipulate
the Windows registry to set the desktop wallpaper and desktop backgroud color
settings and invoke `user32.dll` in order to make the changes take effect.

The Batch file demonstrating this is [`src/set-desktop-background.bat`](src/set-desktop-background.bat).

Additionally, if you are a user of Windows Sandbox and want to see the script in
action without affecting your main system, there is a way to create a Windows
Sandbox launcher which executes the said script upon startup.

Unfortunately, Windows Sandbox configuration files (`*.wsb`) do not support relative
paths when mapping host to guest paths so instead I have provided VB .NET Core
program which generates the WSB XML with an absolute path of the current directory
when run so that you can generate the WSB and run it.

I used VB .NET because it has language support for XML literals.

`dotnet run` and then run `.\set-desktop-background.wsb`.

[A PowerShell version can be found here.](https://github.com/TomasHubelbauer/powershell-wallpaper)

## To-Do

### Fix the `user32.dll` doing nothing

It used to work, I swear.
It probably needs a little time after being invoked.
Maybe add a sleep or loop-monitor the registry to see the new value first and only then call it.
Or see if the Win32 method has a callback hook or listen for it.
Or find another way to see if the wallpaper has changed.
