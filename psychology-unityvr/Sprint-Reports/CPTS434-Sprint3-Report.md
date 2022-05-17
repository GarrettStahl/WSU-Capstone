# Sprint 3 Report (3/2/2022 - 4/2/2022)

## Video: https://youtu.be/izlLH2KH4ZM

## What's New (User Facing)
* Neutral House scene completed
* Assets for the stressful version of the house found
* Tutorial Room added to the house to allow the player to learn the controls before
starting to explore the environment
* Unit testing for the scripts we developed personally
* Bug fix with tokens, adding gravity to them and changing their placement

## Work Summary (Developer Facing)
We finished up the neutral house by placing more assets into the house and making it feel more "lived in" as requested by the client. We then sent screenshots of the house to the cleint for approval where it was accepted as a final state for the purporses of the project. 

We implemented unit testing using the Unity Test framework. Unity has two different kinds of tests we can define, edit mode tests or play mode tests. All of our tests are defined in the play mode test setting as all of our scripts need to be ran while the application is running, i.e in play mode.

## Unfinished Work

The menu system is finished, but not merged into main. The stressful version of the evnrionment was started, but was advised by the client to be held off until the final version of the non stressful house was approved. Lastly the opening and closing of cabinents were also not finished, but should be a realatively quick task given there are tutorials on how to do this in a VR environment online.

## Completed Issues/User Stories
Here are links to the issues that we completed in this sprint:

 * [Fix token placement and add gravity](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/76)
 * [Find Creepy Assets ](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/54)
 * [Send Images to Dr. Cuttler For Their Grant Application](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/69)
 * [Send Aria renders of the key memory items so they can begin coming up with the memory test](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/68)

 ## Incomplete Issues/User Stories
 Here are links to issues we worked on but did not complete in this sprint:
 
 * [Interactive Cabinents and Drawers](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/53)
   * Not completed due to Nik handling merge conflicts with this proejct and leading other projects in other classes. Planning to complete very early in the upcoming sprint
 * [Stressful House Layout](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/37)
   * Same as above, also waiting for client approval on the non-stressful house so we can match the item placements as closely as possible as requested by the client.
 * [Fix Nausea Issue](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/79)
   * Not marked as completed due to nothing being done to the project in regards to this issue. However, we are fairly certain the nausea issue reported at the last demo was due to the demo running off of Nik's oculus rift which is older and runs at a lower refresh rate. If the nausea issue persists we will look into implementing a possible fix.
* [Bathroom Key Item Placement](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/issues/74)
  * Not completed because was handled by the [final decorations](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/pull/83) pull request instead. Likely will close the issue next sprint since the work was completed outside that assigned issue.
 

## Code Files for Review
Please review the following code files, which were actively developed during this sprint, for quality:
 * [DoorTestScript.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/main/THC-VR-Project/Assets/Tests/PlayMode/DoorScriptTests.cs)
 * [TimerTest.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/main/THC-VR-Project/Assets/Tests/PlayMode/TimerTest.cs)
 * [TokenTest.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/main/THC-VR-Project/Assets/Tests/PlayMode/TokenTest.cs)
 
## Retrospective Summary
Here's what went well:
  * Switching to weekly client meetings for the last few weeks of the semester is seeming to be beneficial since we can get quicker feedback on work items, also keeping work ethic a little higher than before.
  * Nik handling merge requests have been working well as well since he can diagnose what's important and what can be ignored quickly so items can be merged.
 
Here's what we'd like to improve:
   * Splitting up work evenly between members seems to be going well, but some issues are lingering a little too long for this point of the semester and should be compelted in a more timely matter, especially since we are approaching the final sprint.
   * Merge conflicts are getting a bit annoying, but its just the nature of this project by the looks of it
  
Here are changes we plan to implement in the next sprint:
   * If a team member is assigned to an issue, and have not been providing updates or are not showing progess being made on the GitHub, that issue is going to be handed to someone else to work on.
   * Nik advised that work should made be done on main more often so merge conflcits do not occur. Branches are still highly encouraged but by doing this we can get more content into main without needing to work out merge conflicts and fixing anything that breaks after the merge.