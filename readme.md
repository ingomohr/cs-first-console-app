![example branch parameter](https://github.com/ingomohr/cs-first-console-app/actions/workflows/dotnet.yml/badge.svg?branch=master)

This is just a small repo to get my hands warm w/ C#.

## Topics I wanted to Cover w/ this Repo
- Setup VSCode for C#
- Typical solution layout for project and tests
- NUnit (incl parameterized tests)

## Take-Aways
- DotNet and C# can be used on macOS, too
- C# projects can be created, built, executed and debugged in VSCode
- NUnit 3.x methods need to be public (as in JUnit 4 and before)

## Links
For the repo I did some surfing and yt-ing.
So far, the best to deliver answers to my questions was:

https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit

## How to Setup VSCode
- Download and install VSCode - https://code.visualstudio.com
- Download and install DotNet 6.0 SDK - https://dotnet.microsoft.com/en-us/download
- In VSCode, install C# extension (["C# for Visual Studio Code (powered by OmniSharp)"](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp&ssr=false#review-details))

## How to Build / Test
- From the Git working tree root:
```
dotnet build
dotnet test
```






