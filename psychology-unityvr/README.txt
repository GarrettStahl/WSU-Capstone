# THC-VR Project

## Project summary

This is an application in Virtual Reality (VR) that simulates two similar but different environments for a study on the long-term effects of cannibas on the brain.

### Additional information about the project

The two environments have identical layouts, but swapped assets in order to give one a "neutral" feel while making the other one a "stressful" approach. The lighting will remain the same throughout the two. There will be various key items around the environment that the participants will be asked to recall. Tokens will be strewn about that the user can pick up, and the number of tokens picked up will be recorded.

## Installation

### Prerequisites

This program requires the use of a VR Headset. This team used an Oculus Quest 2 in the initial demo to the client. Similar headsets would also run this program. A computer to download the program onto the headset will also be needed.

### Add-ons

During the initial demo to the client, we used SideQuest to upload our application onto the headset. In the future, it will become it's own separate application that will be uploaded directly from the computer to the VR headset.

### Installation Steps

In order to run this currently, the user will need a computer application to upload their build to their headset. This demo used SideQuest. Go into the project in Unity and go to File->Build Settings... then build as a(n?) .apk file. Once there, go into SideQuest and at the top, go to Install APK file from folder on computer. Navigate to the location and select the .apk file. Switch the headset to developer mode, the find the file by going to Apps and selecting the drop-down menu and go to Unrecognized Developer. The file will be seen here and will be able to be accessed and ran as an app.


## Functionality

The user will wear a VR headset on their head and will use VR handsets for each hand. The left handset will control movement while the right handset will control camera angle. Items can be interacted with and picked up using the handset buttons. 


## Known Problems

Currently the doors don't close, picking items up only sometimes works, and the door to the second bedoom on the left can shift in position, trapping the user in the bedroom. Player direction should also be determined by looking around in the headset instead of using the joystick to change camera angle.


## Contributing

TODO: Leave the steps below if you want others to contribute to your project.

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## Additional Documentation

TODO: Provide links to additional documentation that may exist in the repo, e.g.,
  * psychology-unityvr/Sprint-Reports