# 3D Endless Runner
## Description
An Endless runner game made in Unity which can be played on PC and on the web. The player takes the role of a human charecter who runs on the road collecting coins, avoiding obstacles and dodging enemies who smartly come to attack you.

## How to run the game from Github onto Unity
1. Ensure you have installed Git LFS, Github Desktop Unity and Unity Hub 
2. Go to GitHub Desktop and click File -> Clone Repository 
3. Select the URL option and copy the repository link (https://github.com/mrsurya1304/3DEndlessRunnerV2.git)
4. Select a path to create the local repository and click Clone (Your local repository folder will be created)
5. Open Unity hub, ensure you have an activated license and click on Add 
6. Click to the folder where you created your local repository and click on 3DEndlessRunner folder (Your project will be added)
7. Click on the project which opens it on Unity.
8. Go to the project folder. Click on Scenes -> 3DEndlessRunner and click on the play button to play the game

Demo : https://youtu.be/s7rI0d7cxUU

## How to play the game
- Use the up arrow to move forward
- Use left and right arrows to move across the road to dodge obstacles and enemies
- Use the up arrow to jump
- Run over the coins to collect them
- Use the try again button to play again

## Game features
1. Efficient endless road spawning without using much resources to boost performance
2. Town environment creation, obstacle and enemy instantiation with optimized resource spawning techniques
3. Realistic charecter with animations for running, jumbing, turning, and death
4. Distance measurement of how far the charecter runs and also coin collection amount (Displayed on screen)
5. Smart enemy which attempts to attack the charecter (Enemy knows where the charecter is on the road and moves towards it)

## Game Concepts
1. Road moving - When we pass a road after some time that road gets moved to the front providing an endless road
2. Rigidbodies and gravity
3. Enemy, Road and Obstacle prefab creation- Many unique configurations of obstacles are created to spawn in the game to give uniqueness
4. Object pools and random spawning for enemies and obstacles
5. EnemyAI to make challenging enemies
6. Particle effects and Ragdoll for death animations
7. Canvas and UI to display basic information to the player

## What the game looks like


## Gameplay demo
Link : https://youtu.be/B8jHsXRwGcI

## Link to play the game
You can play this game on the browser
Link : https://mrsurya1304.itch.io/3d-endless-runner?secret=An9WVLzPfrz4aUfMdA4YiG12E

## Future ideas
1. Addition of power ups
2. Addition of more levels with varying difficulty
3. Addition of more charecters
4. Better optimization of resources used for spawning
5. System to store coins collected so the player can buy some accessories which could help play the game better

## Acknowledgement
This game takes lots of inspiration from Subway Surfers. It is basically Subway Surfers in a town environment
I also used ideas from the Youtube channel Quick 'n Dirty who have an amazing series on how to build an endless runner on Unity 3D
Playlist link: https://www.youtube.com/watch?v=Fn1Pm6nnPVk&list=PL2xbYe8TgQDPsXgVmd8RJdoIJ3eLio7R6


