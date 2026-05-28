# Copilot Agent Instructions — OpenMeteoApi

Trust these instructions. Only search the codebase if information here is incomplete or appears incorrect.

## What This Repo Is

A C# NuGet library (`OpenMeteoApi`) providing a typed client for the [Open-Meteo](https://open-meteo.com/) weather API. Supports current weather, daily forecasts, hourly forecasts, and air quality data. Published to NuGet.

- **Solution:** `OpenMeteoApi.sln`
- **Main project:** `OpenMeteoApi/`
- **Test project:** `OpenMeteoApi.Tests/`

## Languages, Frameworks & Runtimes

- **C#** — .NET (see `OpenMeteoApi.csproj` for target framework)
- **xUnit** — test framework
- **NuGet package** — published to nuget.org

## Coding Conventions

- **Always use tabs** (not spaces) for indentation
- **Commit message format:**
  - Line 1: Single-line summary, 250 characters max
  - Line 2: Blank
  - Line 3+: Shortened bullet-point sentences that break apart the full summary

## Build & Test Commands

```bash
dotnet restore OpenMeteoApi.sln
dotnet build OpenMeteoApi.sln
dotnet test OpenMeteoApi.sln
dotnet pack OpenMeteoApi/OpenMeteoApi.csproj -c Release   # produces NuGet package
```

## CI / Validation

No GitHub Actions. Manual validation: `dotnet build` + `dotnet test` — zero errors, all tests pass.
