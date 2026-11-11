# Agent Instructions — OpenMeteoApi

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
- **Commit message format:** Conventional Commits (`feat:`, `fix:`, `docs:`, `refactor:`, `test:`, `chore:`, `build:`, `ci:`) following the 50/72 rule:
  - Line 1: subject, target 50 characters, 72 hard ceiling — GitHub truncates the title past 70–72
  - Line 2: blank (required)
  - Line 3+: short bullet points breaking down the change, hard-wrapped at 72 characters
  - A squash merge appends ` (#123)` to the subject — keep a PR title that will be squashed at roughly 65 characters or less

## Build & Test Commands

```bash
dotnet restore OpenMeteoApi.sln
dotnet build OpenMeteoApi.sln
dotnet test OpenMeteoApi.sln   # integration-style tests call live Open-Meteo endpoints; requires network and can be flaky/rate-limited
dotnet pack OpenMeteoApi/OpenMeteoApi.csproj -c Release   # produces NuGet package
```

## CI / Validation

No GitHub Actions. Run `dotnet build` and `dotnet test` and ensure they pass.
