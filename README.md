Beef's Stationeers Gameplay Fixes<a name="TOP"></a>
===================

## Determining your own values for hunger/hydration ##

https://www.desmos.com/calculator/aswgq5e1gk

Graphs the % of hunger and % of hydration over time.

- Set your desired world hunger rate (as you will establish in-game). This is a global multiplier applied to everything and ultimately determines your total food consumption.
- Set your desired max nutrition storage, max hydration storage, and metabolism/dehydration rate.
- Put those values into the config.

## Completed features ##

  - Changes to Rover max speed and torque values. Felt like the rover was useless once you had Hardsuit jetpack because it was so slow? Frustrated because a single 22.5 degree slope could stall out your sophisticicated space-exploring rover? Now you can explore much better. Just be careful not to fall off the edge of the map... (if you do, just wait inside the rover and once the terrain generates you'll be teleported back up to safety and can continue your mission)
  - Default Settings are now 24m/s maximum speed and 2x torque of vanilla. Adjustable under BepInEx/configs once you run the game once.

  - Changes to hydration / hunger. Your character can now fit a bunch of water bottles and several soup cans into his stomach at once so that you put more of a strain on your food/water supply. When you hear the rumble in your belly, you can bet you'll want to eat everything in sight....
  - Default Settings are now 8x the storage of food nutrition in your body, and 6x the hydration storage. Adjustable under BepInEx/configs once you run the game once.
  
## Planned Features ##
 
#### Short term: ####
  
#### Long term: ####

## Compatibility ##

This mod is compatible with existing saves and will not corrupt them when you install or uninstall the mod

However, it could interfere with other plugin based mods that alter rover speeds

## Installation ##

    Download the latest release https://github.com/TheRealBeef/Beefs-Stationeers-Gameplay-Fixes/releases/latest
    Drop BepInEx to your Stationeers folder in SteamApps/Common/Stationeers/
    Run Stationeers once to complete the BepInEx installation
    Drop Beef's Stationeers Gameplay Fixes.dll to the Stationeers/BepInEx/plugins folder
    Run Stationeers to generate the configuration file
    Edit org.bepinex.plugins.beeffixes.cfg under configs if desired to change the values
    Enjoy

## Contributions ##

    Please, feel free to contribute either in issues or in pull requests, or to fork 
    this repo for your own take on Stationeers visuals.
