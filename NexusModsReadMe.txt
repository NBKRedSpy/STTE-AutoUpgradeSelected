[b][size=5]Auto Upgrade Selected Crew[/size][/b] 
 
 
Allows the user to invoke the "auto upgrade skills" on only selected crew members.
 
Press the mod's hotkey (by default Left Bracket) to upgrade.  Can be changed in the config.
 
This allows the user to be selective on which crew are upgraded, or auto upgrade even after the "auto upgrade" dialog has been closed.
 
[b][size=5]Steam Workshop[/size][/b] 
 
For Steam Users, subscribing to this mod does not install the mod.
Follow the instructions in [font=Courier New]Installation section[/font] below.
 
[b][size=5]Compatibility[/size][/b] 
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[*]Safe to add and remove from existing saves.
[/list]
 
[b][size=5]Configuration[/size][/b] 
 
The configuration file will be created on the first game run and can be found at [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\AutoUpgradeSelectedCrew.cfg[/font].  The changes will take effect the next time the game is run.
[font=Courier New]+------------+-------------+-------------------------------------------------+
| Name       | Default     | Description                                     |
|============+=============+=================================================|
| UpgradeKey | LeftBracket | The hotkey to upgraded the selected crewmembers |
+------------+-------------+-------------------------------------------------+
[/font]
 
[b][size=5]Support[/size][/b] 
 
If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!
 
[b][size=5]Installation[/size][/b] 
 
This section covers how to install the BepInEx mod loader and the mod itself.
 
[b][size=4]BepInEx Setup[/size][/b] 
 
If BepInEx has already been installed, skip to the [font=Courier New]Mod Install[/font] section.
[list]
[*]Download BepInEx from [url=https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip]https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip[/url]
[*]Extract of the BepInEx zip file into the game's directory:
[font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/font]
[*]Move all of the files in the new [font=Courier New]BepInEx_win_x64_5.4.23.2[/font] folder to the game's root directory.
[*]If installed correctly, the following folders and files will exist in the game's directory:
[/list]
[code]
<Game Directory>
│   doorstop_config.ini
│   ST Earth.exe
├───BepInEx
├───Data
[/code]
[list]
[*]Run the game.  Once the main menu is shown, exit the game.
[*]If the install was successful, there will now be a [font=Courier New]<Game Directory>/BepInEx/plugins[/font] directory.
[/list]
 
[b][size=4]Mod Install[/size][/b] 
[list]
[*]Download the AutoUpgradeSelectedCrew.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from [url=https://github.com/NBKRedSpy/STTE-AutoUpgradeSelectedCrew/releases/]https://github.com/NBKRedSpy/STTE-AutoUpgradeSelectedCrew/releases/[/url]
[/list]
[*]Extract the contents of the zip file into the [font=Courier New]<Game Dir>/BepInEx/plugins[/font] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]
 
[b][size=5]Uninstalling[/size][/b] 
 
[b][size=4]Uninstalling This Mod Only[/size][/b] 
 
This method removes this mod, but keeps the BepInEx mod loader and any other mods.
 
Delete the directory [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\AutoUpgradeSelectedCrew[/font].
 
[b][size=4]Uninstall the Mod and BepInEx[/size][/b] 
 
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.
 
Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]
 
[b][size=5]Credits[/size][/b] 
 
[url=https://www.flaticon.com/free-icons/arrows]Arrows icons created by Pixel perfect - Flaticon[/url]
 
[b][size=5]Change Log[/size][/b] 
 
[b][size=4]1.0.0[/size][/b] 
[list]
[*]Release
[/list]
 
[b][size=5]Source Code[/size][/b] 
 
Source code is available on GitHub at [url=https://github.com/NBKRedSpy/STTE-AutoUpgradeSelectedCrew]https://github.com/NBKRedSpy/STTE-AutoUpgradeSelectedCrew[/url]
