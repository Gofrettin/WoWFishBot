# WoWFishBot
Automatically fish in WoW (retail & classic). 

Do not use this, it will almost certainly get you banned (like me). This is not a maintained project.

## Anti-cheat Features
- Every action has a realistic random delay
- Real mouse movement
- Uses system sound to detect spash
- No memory reading/writing
- Natural mouse movement between two points
- Natural mouse sway when waiting for catch

## Requirments
Windows

## How to use
1. Clone and build
2. Add settings:
   - Cast button: Location of cast button on action bars
   - lure button: Location of lure button on action bars (if enabled)
   - bobber color: After casting, mouse over a unique distinctive color on the bobber to capture the color to be used by the bot
   - Screen region: Define the top left and bottom right corner for the bot to search. The bot will calculate the rectangle from these two points to search within.
3. Press start. Note, you cannot use you computer while it is running since it is actually using your mouse to run.

## How it works
Once configured and started, it will run in this order:
1. If needed & enabled, apply lure
2. Click on cast button
3. Search for bobber (via configured color)
4. Move mouse to bobber (uses natural mouse movement)
5. Waits for splash noise (will randomly sway mouse over bobber)
6. Repeat
