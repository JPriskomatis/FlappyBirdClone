This is my online browser flappy bird clone game with a backened database for the purpose of storing leaderboard stats using Danial Jumagaliyev's Leaderboard creator which can be found here https://danqzq.itch.io/leaderboard-creator.
Exported as webgl and hosted on my own ubuntu server.

Game can be played here:
https://fridaynight.gr

This relatively simple game served as a learning experience to implement advanced programming patterns like the following:

  1. Factory Pattern: The factory pattern allowed me to easily spawn different kind of obstacles without having breaking the S.O.L.I.D principles. Now, creating a new obstacle type is relatively fast and can be added in the game with little effort.

  2. Observer Pattern: Using this pattern I'm able to control the game throughout the use of events which allows me to avoid tightly coupled connections between my gameobjects. By registering listeners and activating events I can condifently create new additions to my workflow without having to modify anything else.

Future Implementation:
Implement ci/cd pipeline for automated and clean deployment.
