# .NET API Project

This project is a .NET API. Below are the common commands to build and run the project.

## Common Commands

### Building the Project
To build the project, use the following command:

```bash
dotnet build dotnet-api.csproj
```

### Running the Project
To run the project, use the following command:

```bash
dotnet run --project dotnet-api.csproj
```

### Building and Running with Solution File
If you have a solution file (`.sln`) and plan to expand your project, it is recommended to use the solution file for building and running:

```bash
dotnet build dotnet-api-basics.sln
dotnet run --project dotnet-api-basics.sln
```

## Notes
- If you only have a `.csproj` file, you can safely use `dotnet build` and `dotnet run` without any issues.
- If both `.sln` and `.csproj` files are present, using the solution file is recommended for better project management.