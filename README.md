# SURVIVAL MODE
Survival, a new gamemode for H3. You've been stranded and nobody is coming. How long can you survive?

## FEATURES
 - *Infinite* wave-based gameplay
 - Custom shops for weapons, ammo, attachments, grenades, etc
 - Recyclers to sell off all your unwanted guns, mags, and other goodies
 - Limited/Unlimited ammo modes to dictate your play experience
 - Persistent highscore saving
 - **Boss waves**

## MAPPING
 - Download Meatkit [on Github.](https://github.com/H3VR-Modding/MeatKit)
 - Download the survival mapping package available [on Github.](https://github.com/localpcnerd/H3VR-Survival-Mode/)
 - Import Atlas [(Available here)](https://github.com/H3VR-Modding/AtlasSampleScenes/) into your Meatkit project.
 - Import the survival mapping package into a Meatkit project.
 - Open the example scene and copy all the objects under the --SURVIVAL-- object into your scene.
 - Reposition and tweak settings to your liking.
 - Build as an Atlas sandbox scene.
 - If you have any questions, feel free to DM or ping me @reallocal

### NOTES + TIPS
 - Make sure that **localpcnerd-Survival_Mode-1.0.0** is added as a dependency!!
 - **READ THE TOOLTIPS!!!!**
 - The *SurvivalObjects* prefab contains everything you need to take your sandbox map to a survival map. Drop it in and reposition, tweak, or change as needed.
 - Shops will autofill the item's text field with the name and price you filled out, so you don't need to set those manually. This includes the Ammo Supplier and Randomized Spawner.
 - You can have as many or as little shops as you want, there is no ceiling on the number. I typically stick with 3 split between Weapons, Attachments, and Consumables.
 - Shop items are *fully* customizable, anything can be spawned as long as you have its ItemID. Use MetaViewer/Ripper to find these.

### TODO
 - Rewrite shops to automate the creation process for shops, ex. Gun Game weapon lists (Highest Priority)
 - Wrist follower to display the minimap, various counters/data, etc etc.
 - Rewrite spawning system to allow for custom vaulted weapons.
 - Custom vaulted loadouts.
 - Some other cool stuff probably.

### Credits
- Nathan: Atlas
- Devyn: Ammo spawner script
- Packer: QA testing + making SM_Department_Of_Meat
- Catcher: QA testing
- NotWolfie: QA testing
- McGram: QA testing
- Okkim: QA testing + organizing modmas

### Changelog
1.0.0 - Initial Upload
