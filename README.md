# Unity-Live-Project
Unity live project completed through The Tech Academy where I recreated Frogger in the Unity engine.

## Frogger Screens
First part of the project was creating the screens for Frogger. Each were made within Unity, and movement between them was controlled by using buttons and a SceneLoader Prefab

## Frogger Movement
Player movement is controlled through the arrow keys. Scripts are included to prevent the player from exiting the scene and going off screen. Player is able to move up, down, left, and right and the goal is for them to avoid getting hit by cars in order to make it to the other side of the road.
![](https://i.gyazo.com/f4890c038284816d8bb64797d9704bfe.mp4)

## Car Movement and Spawning
Car speed is manipulated within Unity, and at first the cars would simply spawn whenever needed. However, this filled up the Hierarchy window within Unity quickly, so object pooling was implemented to keep the cars at a fixed amount of 10 (which can also be manipulated within Unity). Now only 10 cars will ever be present at a time, with the oldest car being moved to where a new car is needed. This de-clutters the Hierarchy window as well as prevents lag from happening. 

## Spritework
All spritework was created by me, and it was made within Aseprite. The frog, car, and yellow lines were all made within Aseperite.

## Timer and Score
In order to add extra difficulty, a timer was added to incentivise the player to move forward. Timer can be manipulated within Unity. A score function was added as well, and player scores are displayed on the end screen whether they win or lose. Future implementation will keep track of player high scores during a single session.
