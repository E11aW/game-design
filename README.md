# Performance Considerations
By Ella Williams
## Frames Per Second
### Description
Low frames per second can have a significant impact on the visuals of a game, rendering far fewer images per second. This can be caused when the game’s rendering loop is overloaded, often because of too many sprites or effects happening at once.
### Common Strategy to Address Concern
Rendering sprites and tilemaps together can help reduce how many draw calls are made and how many different objects need to be rendered. Specifically combining multiple static tiles into a single texture or layer can minimize the amount of work done per frame.
## Load Time
### Description
A lot of 2D RPG games need to load new screens, enemies, or levels. Whether there are network issues or just slow internet connection, long load times can really ruin a player’s immersion in the game and take them out of the action. The game can also contribute to long load times by loading assets that are too large.
### Common Strategy to Address Concern
Loading assets asynchronously can save a lot of time, especially when preloading levels. Games that prepare assets for an upcoming level ahead of time can greatly reduce the amount of time it takes for a player to switch between those two levels, leading to a more seamless transition.
## Memory Usage
### Description
When levels are really involved including large tilemaps, music, player data, and enemy data, a lot of memory can be required to store all of this. This can be really detrimental to lower-end devices with limited memory available that may be unable to store all the game’s data.
### Common Strategy to Address Concern
To work around the memory storage required, 2D RPG games can unload unused assets between levels and keep entity pools available for common objects like basic enemies, items, or chests. This reduces the amount of individual assets that need to be stored in memory.
## Summary
A lot of the performance issues that I found come from rendering the game inefficiently and using too many assets. My team and I are already planning how to render tilemaps more efficiently in our game to not only make it easier to design levels but also reduce load time. Another strategy I believe should be implemented is grouping similar assets together to avoid storing too many individual enemies or items. Both of these changes will help us render our levels and store data more efficiently.
