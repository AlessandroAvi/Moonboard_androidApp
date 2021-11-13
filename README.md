# CUSTOM MOONBOARD ANDROID APP

This repo contains the Unity project that I developed in order to create an Android app that allows me to control the LED mounted on my MoonBoard. Other related project to this one can be found at these links:

- [STM32 project](https://github.com/AlessandroAvi/Moonboard_LED_DIY) for controlling LED lights through manual keypad or bluetooth connection to the FishBoard app
- [Python code](https://github.com/AlessandroAvi/Moonboard_Dataset) that I developed for generating the moonboard boulder problems dataset. This uses some computer vision and automatic scrolling throught the problems in order to create a json that contains all the info of the boulder problems (because the original dataset is private)

The main purpose of this app is to allow the user to filter throught the JSON file and select the boulder problems with filters applied on grade/benckmarks/problem sent. The app also allows the user to see the holds used by the problem and also separates them in start/top holds. 

When the boulder have been selected by the user is possible to sent all the relevant informations to the STM32 microcontroller via bluetooth. This allows the microcontroller to correctly set up the LEDs and light up the holds used by the boulder problem.
