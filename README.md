# ASP.NET Core Minimal API – Project Structure (Basic Setup)

This document explains each file and folder in the current project.
The project uses the **minimal API template**.

---

## Project Structure

```
📦 day-one
 ┣ 📂 obj
 ┣ 📂 Properties
 ┃ ┗ 📜 launchSettings.json
 ┣ 📜 appsettings.Development.json
 ┣ 📜 appsettings.json
 ┣ 📜 day-one.csproj
 ┣ 📜 day-one.http
 ┗ 📜 Program.cs
```

---

## Program.cs

This is the **main file** of the app.

In a minimal API:

* there are no controllers
* routes are defined here
* the app starts here

What it does:

* builds the app
* defines endpoints like GET or POST
* starts the web server

Example idea:

```csharp
app.MapGet("/", () => "Hello World");
```

Request flow:

```
client → Program.cs → response
```

---

## day-one.csproj

This is the **project definition file**.

It controls:

* .NET version (example: net10.0)
* NuGet packages
* build rules

You touch this when:

* adding libraries
* changing framework version

---

## appsettings.json

This is the **global configuration file**.

Used for:

* logging settings
* app configuration
* future database connections

Loaded in all environments.

---

## appsettings.Development.json

This is **development-only config**.

Used when running locally.

Usually contains:

* more detailed logs
* debug-friendly settings

Overrides values from `appsettings.json`.

---

## Properties/launchSettings.json

This controls **how the app runs locally**.

Used by:

* `dotnet run`
* VS Code debugger

It defines:

* HTTP / HTTPS ports
* environment name (Development)

You rarely change this early on.

---

## day-one.http

This file is for **testing your API**.

VS Code can send requests from here.

Example:

```http
GET https://localhost:7xxx/
```

Click **Send Request** to see the response.

Good for quick testing without Postman.

---

## obj folder

This is **auto-generated build output**.

Contains:

* compiled files
* NuGet cache
* temp build data

Rules:

* never edit
* safe to delete
* always ignored in version control
