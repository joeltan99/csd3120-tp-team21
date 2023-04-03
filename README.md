# csd3120-tp-team21

# Team Members
Name: DARRION AW WEI TING, Student ID: 2000735
Name: MIRA D/O LANKATHARAN, Student ID: 2002678
Name: CELINE LEONG JIA YI, Student ID: 2002392
Name: JEMIMAH CHAN SHU XIAN, Student ID: 2001827
Name: PAN MINGXING, Student ID: 2002197
Name: LIAO RUIQI RICKY, Student ID: 2001151
Name: TAN ZHUO YAO, JOEL, Student ID: 2000672


* Executable on: Desktop Chrome + Meta Quest 2 *
* Locomotion method: Teleportation * 
* Controls : HMD Controller or Hand Tracking *


* Interactive VR scene using Unity
This project is a web application that creates and renders an interactive VR scene using the Unity Vr Toolkit library. 
The app uses the Unity Engine to create a default XR experience which includes:
Interactable Molecule Models - H2, 02, H20, Mg, MgO, C, CO2 (w/ haptic feedback)
Skybox 
3D Audio Chemistry Lesson Video
Quiz on Chemistry 
Whiteboard - Drawing/writing what the user have learnt
Interactions - Combining models using hand gestures / controllers (grab interactions) + Poke interaction to answer quizzes + Drawing (grab interaction)


* Running the project
1. Install Web-XR emulator
2. Download the "Submission" folder (Folder is too huge to be pushed to GitHub) - https://drive.google.com/file/d/13Mpdt8ps8ZABouuSLuz1YKszOyEh0QoD/view?usp=sharing
3. Unzip & Place folder in the Main Repository
4. Open the command terminal (cmd) in the "Submission" folder of the repository.
5. In the terminal, type 'python -m http.server' to start the server.
6. Open the project in your browser at http://localhost:8000


* Files
- GitHub Folder
  https://github.com/joeltan99/csd3120-tp-team21
- Submission Folder
  https://github.com/joeltan99/csd3120-tp-team21/Submission
- Asset files
  https://github.com/joeltan99/csd3120-tp-team21/tree/Submission/Assets


* Demo Video :
https://drive.google.com/file/d/1wtA3SbQa9aLBQmjM0-uHs28lgswdq249/view?usp=sharing

* Trello Link (Member's Contribution)
https://trello.com/invite/b/qJ7CvoXq/ATTIf66e740d9b9b252c2f8df75b806e08a0A5353526/vr-tp



#### Directory Structure/Architecture
"Submission" / Current Directory
| -Build
|   |-Submission.data
|   |-Submission.framework.js
|   |-Submission.loader.js
|   |-Submission.wasm
|
| -TemplateData
|   |-favicon.ico
|   |-fullscreen-button.png
|   |-MemoryProfiler.png
|   |-progress-bar-empty-dark.png
|   |-fprogress-bar-empty-light.png
|   |-progress-bar-full-dark.png
|   |-fprogress-bar-full-light.png
|   |-style.css
|   |-unity-logo-dark.png
|   |-punity-logo-light.png
|   |-webgl-logo.png
|   |-webmemd-icon.png
|
| dependencies.txt
| GUID.txt
| index.html
| ProjectVersion.txt

Build: Builds the XR project
TemplateData: Assets for the WebXR website 
index.html: Website



* Flow of the VR activity
1. Audio Instructions
2. Chemistry Lesson Video
3. interacting & exploring with molecules and atoms (related to the lesson taught)
4. Quiz Session (MCQ)
5. Notes session (Whiteboard) - Write/Draw/Reflect on what you have learnt
6. End
