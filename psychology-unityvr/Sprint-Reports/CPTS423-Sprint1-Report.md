# Sprint x Report (8/26/21 - 9/24/2021)

## Video: Working on it

## What's New (User Facing)
 * More 3D Models found to fill out the house environments more
 * The user is able to pick up tokens and collect them given that they are grabbable objects. 
 * Bug fix / update on the door opening
 * Main menu / pause menu for quitting the game

## Work Summary (Developer Facing)
This sprint we largely re-evaulated the work that has been done and the work that needs to still be completed in order for us to deliver a quality product to the client by the end of the semester. In line with that, we spent time looking for more 3d assets as that is what is taking the longest time for the project for us since many of the quality options are paid, which even though the client has offered a budget of about $100 to pay for 3D Models, we are trying to get by with as much free, royalty free licensed models we can. Otherwise any models we need will have to be created by hand by one of our members with 3D modeling experience.

## Unfinished Work
We rolled over work from last semester and also added new issues of lower priority, but the issues still left to be completed as a whole are:
* Timer Notification #32
* Digital Clock that Displays Real World Time #52
* Finding Creepy Assets for the stressful house #54
* House Layout: Stressful House #37
## Completed Issues/User Stories
Some of these ssues are still open, but are completed. We are having issues with merging due to how Unity handles meta data. These will be closed once that is resolved:

* Menu to select which house to explore #15
* Find Normal house assets #55
* Android Build for Release #47
* Token Pickup #4

 ## Incomplete Issues/User Stories
 Here are links to issues we worked on but did not complete in this sprint:

* Environment Detailing #50 
  
  its getting difficult to find quality assets, also merging environment scene changes is often causing merge conflicts so work completed might have to be repeated unless we find a solution, Universal Scene Discription would fix this but we have to look into how it works with any work done already along with what plug ins are needed.
 

## Code Files for Review
Please review the following code files, which were actively developed during this sprint, for quality:

 * [Token Counter.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/2de0f1f7b236bc31ec5ce772a30af347f1067e31/THC-VR-Project/Assets/Decorations-KeyItems/Token/Token%20Counter.cs)
 * [house1_render.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/a461c89da10a1f1e49296a11a6cd2d79ce964ce1/THC-VR-Project/Assets/house1_render.cs)
 * [LineRendererSettings.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/a461c89da10a1f1e49296a11a6cd2d79ce964ce1/THC-VR-Project/Assets/Menu/LineRendererSettings.cs)
 *  [DoorScript.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/62088655156fbcb627c14337b6b59c9b4d1e2b36/THC-VR-Project/Assets/Doors/DoorScript.cs)
 *  [Door_Close_Trigger.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/62088655156fbcb627c14337b6b59c9b4d1e2b36/THC-VR-Project/Assets/Doors/Door_Close_Trigger.cs)
 *  [Timer.cs](https://github.com/WSUCptSCapstone-Fall2021Spring2022/psychology-unityvr/blob/62088655156fbcb627c14337b6b59c9b4d1e2b36/THC-VR-Project/Assets/Timer/Timer.cs)
  
 
## Retrospective Summary
Here's what went well:
  * Team meeting after the client meeting to go over what needs to be done
  * Assigning Work at the team meetings for any team members not feeling particularly strongly about wanting to work on a particular issue
 
Here's what we'd like to improve:
   * We need to get unity and git to play well with eachother so we do not have merge conflicts as often as we do. In terms of editing scenes, having scenes use Universal Scene Discription likely will be one of the ways to fix this, but there are also various scripts we can implement allegedly as mentioned on online tutorials.
  
Here are changes we plan to implement in the next sprint:
   * The Unity project needs to be updated in some way such that we do not have merge conflicts as frequently. As mentioned multiple times previously in this report, there are a few ways to go about this it's just a matter of picking what's the easiest and most reliable way.
  