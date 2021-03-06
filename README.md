# Frogger 2.0
PIGS Game Jam where I remade Frogger in Unity!

## Frogger Screens
First part of the project was creating the screens for Frogger. Each were made within Unity, and movement between them was controlled by using buttons and a SceneLoader Prefab.

Transition from start screen to level screen with fade-in and out thanks to SceneLoader Prefab:

![](https://media.giphy.com/media/w7WZft8znYU7P13PB7/giphy.gif)

## Frogger Movement
Player movement is controlled through the arrow keys. Scripts are included to prevent the player from exiting the scene and going off screen. Player is able to move up, down, left, and right and the goal is for them to avoid getting hit by cars in order to make it to the other side of the road.

Example of Frogger getting hit by a car and getting the "Game Over" screen:
![](https://media.giphy.com/media/EQw7LUeYrOMzthoXSC/giphy.gif)

Example of Frogger winning the level and transitioning to the "YOU WIN!" screen:
![](https://media.giphy.com/media/HLIA0d91PHEc055qg1/giphy.gif)

## Car Movement and Spawning (Object Pooling)
Car speed is manipulated within Unity, and at first the cars would simply spawn whenever needed. However, this filled up the Hierarchy window within Unity quickly, so object pooling was implemented to keep the cars at a fixed amount of 10 (which can also be manipulated within Unity). Now only 10 cars will ever be present at a time, with the oldest car being moved to where a new car is needed. This de-clutters the Hierarchy window as well as prevents lag from happening. 

Example of cars spawning having a limit due to the object pooling. Shows that there are 10 preloaded car slots that can be filled, meaning only 10 cars can ever be present:

![](https://media.giphy.com/media/lCUZPNmXmsdH80sJ0w/giphy.gif)

Close up of Hierarchy tab:

![](https://media.giphy.com/media/gR1duHqnRXNJ0UnWMH/giphy.gif)

## Timer and Score
In order to add extra difficulty, a timer was added to incentivise the player to move forward. Timer can be manipulated within Unity. A score function was added as well, and player scores are displayed on the end screen whether they win or lose. Future implementation will keep track of player high scores during a single session.

![](https://media.giphy.com/media/VfeZCJpFXDgXbeWyIw/giphy.gif)

![](https://media.giphy.com/media/J9BJ5u7wm3oJmWoH4y/giphy.gif)

## Spritework
The frog, car, and yellow lines were all made by me within Aseperite.

![image](https://user-images.githubusercontent.com/79771326/123156059-b625c200-d41d-11eb-98a0-aeb45e0ae01a.png)
![image](https://user-images.githubusercontent.com/79771326/123156293-f9803080-d41d-11eb-9c22-1cedf39934c3.png)
![image](https://user-images.githubusercontent.com/79771326/123156338-06048900-d41e-11eb-95fd-b776ccce9405.png)

