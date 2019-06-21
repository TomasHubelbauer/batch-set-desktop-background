REM Remove the desktop wallpaper (clear a path to a BMP file)
reg add "HKEY_CURRENT_USER\Control Panel\Desktop" /v WallPaper /t REG_SZ /d " " /f

REM Set the desktop background color to black (RGB 0 0 0)
reg add "HKEY_CURRENT_USER\Control Panel\Colors" /v Background /t REG_SZ /d "0 0 0" /f

REM Refresh the registry settings to make them take an effect
RUNDLL32.EXE user32.dll, UpdatePerUserSystemParameters

REM Close the command prompt
REM exit
