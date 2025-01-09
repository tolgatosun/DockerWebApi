# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy DockerWebApi project file and restore dependencies
COPY ../../src/DockerWebApi/DockerWebApi.csproj ../../src/DockerWebApi/DockerWebApi.csproj
RUN dotnet restore ../../src/DockerWebApi/DockerWebApi.csproj

# Copy DockerLibrary project file and restore dependencies
COPY ../../src/DockerLibrary/DockerLibrary.csproj ../../src/DockerLibrary/
RUN dotnet restore ../../src/DockerLibrary/DockerLibrary.csproj

# Copy the rest of the application files and build the project
COPY ../../src/ ./src/
WORKDIR /source/src/DockerWebApi
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DockerWebApi.dll"]