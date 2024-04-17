

# SMW Music Minifier

## Who?

Copyright (c) 2024 Christopher James Allinson

## What?

Super Mario World rom hacks are very popular. They are free, fan made games based on the original snes video game, but can also include custom features and music created by [SMW Central](https://smwcentral.net) community members.

Music in a Super Mario World rom hack is read from a text file that you create while making/porting a song.

This application reduces the size and complexity of said text file. It outputs a separate minified file, keeping the original file in tact for future edits.

## When?

This application was created in April, 2024.

## Where?

[SMW Central](https://smwcentral.net) is the hub for Super Mario World rom hacks.

## Why?

I created this application to help me reduce the size of the music text file associated with creating a song. I run my text file through this app just before submitting it to SMW Central.

## How?

#### How It Works

This app finds patterns in your text file and replaces them with simplifications. An example: a16^16^16 -> a8.

#### How To Use

Copy your text file into the root folder of the application. Run the application (which opens in a terminal window). Enter the filename of the text file and press enter. A minified file will be created in the root folder of the application.
