# FFX Field Item Randomizer - Standalone

This randomizer shuffles around field items.
While this works perfectly fine, there are some things that you will need to know!

URGENT!!! 
There seems to be an odd issue, at least on my end with the randomizer. When injecting the file back into the main data .VBF, a lot of the files(for some reason) pad out evenly and the whole thing breaks the main file. I have NO idea why this is, but this is being looked into.

1. This randomizer does NOT shuffle the following items.
 - Withered Bouquet
 - Flint
 - Jecht's Spheres (*)
 - Celestial Mirror

2. While this does shuffle everything around, the Cloudy Mirror will NEVER be in
   the Celestial Mirror-required locations(in other words, if the location requires
   it, the Mirror will not appear there).

3. The Rusty Sword will NEVER be randomized where it's used to earn Auron's Celestial Weapon.

4. This does not change the quantity or type of consumable items received(at least not yet).

5. This randomizer doesn't affect the Al Bhed Primers, as those are stored in a different location.

6. This randomizer doesn't have a spoiler log to generate(yet!), so locating items in the whole
 - game hasn't been fully documented quite yet(but it's mostly done. this will be updated next!).


(*) - There's only one entry for Jecht's Sphere. This location is read 4x in the game.
    If this is changed, there will need to be 4x Jecht's Spheres located elsewhere.
    This can also break things. It's unsure if this is safe to modify currently.


## How to Use

1. Open up VBF Browser and navigate to and extract the following file.
 - \ffx_ps2\ffx\master\jppc\battle\kernel\takara.bin
 - Critical! Keep this file safe from modification/deletion or make a backup of the file!

2. Open up Field Item Randomizer.exe.

3. Select this file and a location to save the new file.
 - The randomizer will write out the file as 'takara(<seed>).bin', where <seed> is the
   value used for randomization.

4. Type out a seed value, leave blank(or accidentally type a letter in the box) for a random seed.

5. Click 'RANDOMIZE'.

6. Make sure your new file is named 'takara.bin' without the quotes.

7. In your VBF Browser, navigate back to the directory mentioned in step 1, then inject the newly randomized 'takara.bin' file.

8. Enjoy!


## To Revert Changes

Follow Step 7 in the above process, but instead use your backup, the unmodified version of the 'takara.bin' file you extracted in step 1.


### Version History

 - 1.0.0.0 - Initial release. Shuffles items around.


### Final Thoughts

Why don't people make simple to understand steps in readme's anymore?
