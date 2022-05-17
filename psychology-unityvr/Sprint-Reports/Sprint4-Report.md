# Sprint 4 Report (11/12/2021 - 12/09/2021)
* Video https://youtu.be/ux8pQ1_1AvI

## What's New (User Facing)
 * Doors Open
 * Low-stress furniture layout
 * Texturing the house
 * Token counter and token model
 * House appliances and decorations

## Work Summary (Developer Facing)
Starting with the doors, the doors currently have two positions of "open" and "closed." The doors are the main way to prevent the user from moving forward through the level faster than intended and they also exist to prevent the user from going back in the level, as our client would like each user to spend only 10 minutes in the environment and only wants participants to be in a certain room at a certain time. This took longer than expected to implement and is currently only about half implemented, as the doors open but don't close. They do, however, prevent unwanted prograss as requested by the client. Next, the house layouts are both finalized, as both are using the same layout but with different assests. Only the non-stressful environment is made at the moment, creating the stressful environment will be simple as it's simply copying and pasting the non-stressful one and swapping out assets to be creepier. Also along these lines, the house has been textured, given wooden floors and wall colors although the client requested that we change the wall color in each room to help distinguish it from the next. House appliances such as a fridge, toilets, couches and so on have been implemented, although not to the fullest extent (the house is only about half-full of what needs to be put in). Lastly, the tokens now have a visual model and a script to count tokens, although picking up tokens as a feature has not been implemented yet.

## Unfinished Work
 * Pause Menu #42 - we will need to double check to see if pausing needs to be implemented
 * Timer Notification #32
 * Selection Menu #15
 * Token Pickup #4

## Completed Issues/User Stories
 * Oculus Screen Sharing #43
 * Create and Event to Open Doors #39
 * Tokens: Counter Script #38
 * Client Prototype Demo #33
 * Tokens: 3D Model #28
 * House Items: Appliances #24
 
 ## Incomplete Issues/User Stories
 Here are links to issues we worked on but did not complete in this sprint:
 
 * Pause Menu #42; The clients have decided that they will not be testing halfway through the demo, so it is unclear if we need to pause or not.
 * Prevent the User From Going Back #41: Incomplete because there was troubles getting scripts based on proximity to work, more testing with proximity will need to be done. Code to clor doors is finshed, code to call this is not.
 * House Layout: Stressful house #37: Incomplete because it is the same layout as the non-stressful house; once this is done, the stressful house will simlpy need asset swaps.
 * Halfway  Timer #32: Participants will not be pausing halfway through so it is unclear if we will need a halfway timer notification or not.
 * Selection Menu #15: Implementing a menu in VR is more complicated than originally thought: we also don't have two environments to explore yet so testing an implemented menu is diffuclt at the moment.
 * Token Pickup #4: Items can be picked up and put down but tokens will be counted, so handling these is different from what we have already implemented for picking up objects.

## Code Files for Review
Please review the following code files, which were actively developed during this sprint, for quality:
 * DoorScript.cs (https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/main/THC-VR-Project/Assets/Doors/DoorScript.cs)
 * TokenCounter.cs (https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/tree/main/THC-VR-Project/Assets/Decorations-KeyItems/Token/Token%20Counter)
 * The rest of what was implemented was the house layout and client demo, so no other code needed to be reviewed.
 
## Retrospective Summary
Here's what went well:
  * Better Communication
  * The Client Demo
  * Team Members Were Quick to Respond to Cries for Help
 
Here's what we'd like to improve:
 * None
Overall we felt that this was a productive sprint, as most of the work was simply code and/or improving on issues from previous sprints.
  
Here are changes we plan to implement in the next sprint:
 * Closing doors
 * Opening doors at specific times instead of over the first 5 seconds
 * Spreading out VR Headset work to be more even so more member get the chance to test with the headset(s)
 
