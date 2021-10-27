# LoginApi

A ASP.NET sample project with login api.

## Getting Started

This project is a sample code for a Login Web API.

The API will do following tasks:
1. Receive credential data in JSON format in the body of request.
2. Store credential to [user.txt] file. You'll see the file path in console log.
3. Mockup user object with that credential.
4. Return user object (with asscociated data)

For help getting started with .Net Web Api, view
[online tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio).

## Prerequisites
If you already have your environment set-up, please ignore this. Otherwise please prefer following:
1. Visual Studio Code
2. C# for Visual Studio Code
3. .NET 5.0 SDK

## How to Run
1. Open source code in Visual Studio Code
2. Run -> Start Debugging (F5)

## Working APIs
[POST] https://localhost:5001/Login
More details about the API: https://localhost:5001/swagger
