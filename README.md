## csd3120-tp-team21
Team Project Team 21

## Team Members

* Name: TAN ZHUO YAO, JOEL, Student ID: 2000672
* Name: CELINE LEONG JIA YI, Student ID: 2002392
* Name: MIRA D/O LANKATHARAN, Student ID: 2002678
* Name: JEMIMAH CHAN SHU XIAN, Student ID: 2001827
* Name: PAN MINGXING, Student ID: 2002197
* Name: LIAO RUIQI RICKY, Student ID: 2001151
* Name: DARRION AW WEI TING, Student ID: 2000735


## Details
* Executable on: Desktop Chrome + Meta Quest 2*
* Locomotion method: Teleportation * 
* Controls : Keyboard + Mouse / HMD Controller or Hand Tracking*


## Interactive VR scene using Unity
This project is a web application that creates and renders an interactive VR scene using the Unity Vr Toolkit library. 
The app uses the Unity Engine to create a default XR experience which includes:
Interactable Molecule Models - H2, 02, H20, Mg, MgO, C, CO2
Skybox - classroom setting
3D Audio Chemistry Lesson Video
Quiz on Chemistry 
Whiteboard - Drawing/writing what the user have learnt
Interactions - Combining H2 & 02 models forms a H20 model + Using hand gestures



## Running the project
1. Install Web-XR emeulator
2. Open the command terminal (cmd) in the root directory of the repository.
3. Update your node packet manager by calling 'npm update'
4. In the terminal, type 'npm run serve' to start the server.
5. Open the project in your browser at http://localhost:3000
6. Refresh the page to reload the scene


## Files
- Source files
  https://github.com/barnarnarpowar/CSD3120_IPA/tree/main/HELLO-XR/src
- Asset files
  https://github.com/barnarnarpowar/CSD3120_IPA/tree/main/HELLO-XR/public/assets


* Demo Video :
https://drive.google.com/file/d/1Gd9466Sjmk9IfL0B2MR2JDWp96ENWRKM/view?usp=sharing


### Setup and Acess
1.Clone this github repo through GitLink
GitLink - https://github.com/joeltan99/csd3120-tp-team21
2.Built files
download.....
Controller - hand tracking 
Devices - Meta Quest 2, WebXR
Platform - unity
Language - C-sharp (C#)
3.

## Issues & solve
1.Rebuild
how to rebuild
2.

#### Directory Structure/Architecture
Current Directory
|-Assets
|-Packages
|	|-package-lock.json
|	
|-ProjectSettings
|-UserSettings
|
component diagram later^^^^
Assets: contains all the assets in the application
ProjectSettings: contains required settings for project setup
UserSettings: contains the layout settings for project setup
package-lock.json: handle by npm and the version will be use is configue in package.json 

## VR - Unity
- Teaching chemistry
- video 
- interactables of molecules and atoms
- UI - scroll view, poke components, scroll view, manipulation, touch
1. Interact with Poke to Start VR activity
2. Chemistry lesson plays (3D Audio)
3. Interact with grab to manipulate models (related to the lesson taught) (W/ Haptic Feedback)
4. Quiz Session (MCQ)
5. End
