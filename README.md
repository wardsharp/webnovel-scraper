# WebScraping C# Example
This is a barebones example of how to build a C# webscraper. You can either:

1. Build this project from scratch following my YouTube tutorial (video coming)
2. Run this project directly and modify it to make it work

I'll include instructions how to use it either way

## Building the project from scratch (without cloning)

### Install the .Net SDK
I'm using the .Net 8.0 SDK for this project. You can download it for your operating system here: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

### Create a new project
```
dotnet new console --framework net8.0 --use-program-main --name  webnovel-scraper
```
This will create a new console project using .NET 8.0 and name the project `webnovel-scraper`. Note that this creates a new folder matching your project name and puts the files there

### Install the requisite nuget packages
```
dotnet add package HtmlAgilityPack --version 1.11.57
dotnet add package Fizzler.Systems.HtmlAgilityPack --version 1.2.1
```

### Build the program
From here, you will need to reference the YouTube video (or existing code) to build the rest of the project

You may need to use the commands `dotnet restore` and then `dotnet run` to get the program running.

## Running the project directly (git clone)
To run the project directly, make sure that you have the .NET 8.0 SDK installed (see instructions above).

Then clone the repo using a command similar to the following: 

```
git clone https://github.com/wardsharp/webnovel-scraper.git
```

`cd` into the project directory
```
cd webnovel-scraper
```

Run the following dotnet commands:
```
dotnet restore
dotnet run
```
