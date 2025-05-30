# Dockerfile for .NET

# Step 1: Use the official .NET SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
# Step 2: Set the working directory inside the container
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Step 3: Copy the project files (e.g., .csproj) and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Step 4: Copy the entire project directory and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Step 5: Create the runtime image using a smaller base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Step 6: Set the working directory inside the container
WORKDIR /app

# Step 7: Copy the published output from the build environment
COPY --from=build-env /app/out .

# Step 8: Set the entry point for the application
ENTRYPOINT ["dotnet", "dotnet-rpg-8.dll"]
