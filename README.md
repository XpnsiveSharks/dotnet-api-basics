# How to Use Visual Studio Code with .NET Web API
- ## Prerequisites
    
    > NOTE : Check first if you already installed the following
    
    - **.NET SDK** (so you can create and run Web API projects).
        - https://dotnet.microsoft.com/en-us/download
        - This is how you check if you already have .net sdk installed in your machine
        
        ```jsx
        dotnet —version
        ```
        
    
    - **Visual Studio Code** installed.
        - **C# (by Microsoft) -** adds IntelliSense, debugging, and project support for .NET.
        
        *Optional but helpful extensions:*
        
        - **REST Client** – lets you test API endpoints directly from VS Code.
        - **NuGet Package Manager** – easier package management.
        - **C# XML Documentation Comments** – for better code docs.
        - **Rainbow Brackets** – easier to read nested code.
- ## Create a .NET project using the command line
    - **Step 1.** Open a terminal or PowerShell.
    - **Step 2.** Navigate to the folder where you want the project.
    - **Step 3.** Run the command for a Web API project:
    
    ```bash
    dotnet new webapi -n MyWebApi
    ```
    
    - `webapi` is the template for a Web API.
    - `-n MyWebApi` sets the project name.
    - **Step 4.** Go into the project folder:
    
    ```bash
    **cd MyWebApi**
    ```
    
    - **Step 5.** Run the project:
    
    ```bash
    dotnet run
    ```
    
    > It will start a local server (usually at `https://localhost:5001`).
