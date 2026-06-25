# TG-A Sim Hà Thành MobileApp


## Path
https://gitlab.com/huongnx/tg-a-sim-ha-thanh-mobileapp.git


## How Run App

Step 1: Connect your Android Phone to your PC through USB (If you already have Android Emulator on Android Studio, please skip this step)
Step 2: Navigate to the root folder of project and use CMD (Command Prompt) => 
    type "yarn install" to install all ineeded packages of project
Step 3: type "expo start" commanding to start a development server and development environment of Expo Platform, allowing you to view and test your mobile application on your computer or mobile device in real time.

Step 4: When the QZ code appears, type "a" to run App on your Android Phone



## How to Build App (.apk and .aab)


Step 1: Login https://expo.dev/login
Step 2: Navigate to the root folder of project and use CMD
    "eas login" => enter email and password login at step 1
    "eas build:configure" => configure EAS project ID (app.json)
Step 3: 
    To Build .apk (Android Internal Distribution Build) => use commanding "eas build -p android --profile preview"
    To Build .aab (Android Play Store Build) => use commanding "eas build -p android"

Step 4: Reload https://expo.dev/login pages, and monitor the build process


## Check Credentials
eas credentials

## ThirdParty using in App
SendBird: https://sendbird.com/





