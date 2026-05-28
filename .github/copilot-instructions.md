# Copilot Agent Instructions — OpenMeteoApi

Trust these instructions. Only search the codebase if information here is incomplete or appears incorrect.

## What This Repo Is

A C# NuGet library (`OpenMeteoApi`) providing a typed client for the [Open-Meteo](https://open-meteo.com/) weather API. Supports current weather, daily forecasts, hourly forecasts, minutely forecasts, air quality data, geocoding, and historical weather data. Published to NuGet.

- **Solution:** `OpenMeteoApi.sln`
- **Main project:** `OpenMeteoApi/`
- **Test project:** `OpenMeteoApi.Tests/`

## Languages, Frameworks & Runtimes

- **C#** — .NET (see `OpenMeteoApi/OpenMeteoApi.csproj` for target framework)
- **MSTest** — test framework
- **NuGet package** — published to nuget.org

## Coding Conventions

- **Follow the existing file’s indentation/style**
- **Commit message format:**
  - Line 1: Single-line summary, 250 characters max
  - Line 2: Blank
  - Line 3+: Shortened bullet-point sentences that break apart the full summary

## Build & Test Commands

```bash
dotnet restore OpenMeteoApi.sln
dotnet build OpenMeteoApi.sln
dotnet test OpenMeteoApi.sln   # integration-style tests call live Open-Meteo endpoints; requires network and can be flaky/rate-limited
dotnet pack OpenMeteoApi/OpenMeteoApi.csproj -c Release   # produces NuGet package
```

## CI / Validation

No GitHub Actions. Run `dotnet build` and `dotnet test` and ensure they pass.
