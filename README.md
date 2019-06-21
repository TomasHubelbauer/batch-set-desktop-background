# Batch Set Desktop Background

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

## Tickets

- Fix the `user32.dll` doing nothing (it used to work I swear)
