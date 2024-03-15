# Extreme Programming (Iteration 3)

## Task & People Involved: 
- The extreme programming task focused around our `Minigame 1 & Minigame 2` deliverables, in which we are making a word unscrambling minigame as our *2nd* minigame, and polishing our first minigame
- **Task 1):** Create a bare bones interface of what Minigame 2 will look like
<img width = "200" alt = "SE320BridgePreivew" src = https://github.com/ATacoDev/SE-320/assets/146070033/15db327d-d64d-432e-8176-ce8f42963369>

- **People involved:** `Jaden Johnson & Sarah Yoon`
  - This involves all of the following `Unit tests:`
     - Ensure that the user can drag around a block
     - Add a visual so that the user can either drag around or move around blocks with the given characters
     - Create a fully active bridge if the user input the correct word
     - The bridge is broken otherwise
     - When the block is dragged into the slot, it should slot into a fixed slot in the middle
     - The block should be able to me moved back out if the user wants to
   
- **Task 2):** Finalize and Polish/Finalize Game Logic for Game 1
<img width="300" alt="MiniGame1MenuPreview" src="https://github.com/ATacoDev/SE-320/assets/146070033/b42fef1f-732a-4c26-88f3-ec40e0f6ba48">

- **People involved:** `Tanner Platt & Rory Sullivan`
     - This involved all of the following `Unit Tests:`
     - Create a loading screen that let the user know what sum they were trying to match, and be able to navigate through this screen
     - Create game logic so that each of the individual fruit have a different value when they are caught
     - Create win/lose conditions
     - Create a timer to indicate when the dash ability is available again
     - **Update:** Game feels difficult, needs to be updated to become easier. If we are struggling to do it, our predicted audience will find it *impossible*

## Working Tests (Task 1): ✅
- User can input a string and have it compare with an answer string from an array of potential strings
- Art assets are involved meaning that we can have characters on blocks
- Drag and drop functionality
## Failed Tests (Task 1): ❌
- Creating a bridge in which the user can build the bridge by typing out the string
- Gameplay mechanics to show a bridge either being built or being destroyed due to correct/incorrect answers


## Working Tests (Task 2): ✅
- Clear win/lose conditions
- Game flows from beginning to end smoothly
## Failed Tests (Task 2): ❌
- Dash timer was slightly buggy at first, and is now being iterated on
- Changing timer logic so that the game enhances more of the `mental math` instead of just adding with a sum in place
- Problem with the difficulty of the game, need to add functionality to make it easier for player to remember fruit values and also needs feedback for if you caught it or not
