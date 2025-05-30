# Path to log file
$logFilePath = ".\File.txt"


# Check if the log file exists, if not, create a new file
if (-not (Test-Path -Path $logFilePath)) {
    New-Item -Path $logFilePath -ItemType File | Out-Null
}


# Clear the contents of the file if it exists to start with a clean file for the new logs
Clear-Content -Path $logFilePath -Force


# Execute the command and write the result to the log file
# Get the .NET version and write it to the log file
$dotnetVersion = dotnet --version 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "The .NET version: $dotnetVersion" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Restore dependencies and write the output to the log file
$dotnetRestoreOutput = dotnet restore 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Restore is correct" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Build the project and write the output to the log file
$dotnetBuildOutput = dotnet build 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Build is correct" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Check if dotnet-ef is installed and write the output to the log file
dotnet-ef 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "dotnet-ef is installed!" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Update dotnet-ef tool and write the output to the log file
dotnet tool update --global dotnet-ef
Write-Host "Update dotnet-ef" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Add migrations and write the output to the log file
dotnet-ef migrations add "Initial-create"
Write-Host "Added migrations" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Update the database and write the output to the log file
dotnet-ef database update
Write-Host "Updated database" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Check Docker version and write the output to the log file
$dockerVersion = docker --version 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Docker version: $dockerVersion" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Build Docker image and write the output to the log file
docker build -t vilislavkalenski/dotnet-rpg-8 . 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Built Docker image" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Run Docker container and write the output to the log file
docker run -p 8080:80 vilislavkalenski/dotnet-rpg-8 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Ran Docker container" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"


# Wait for 10 seconds (for demonstration purposes)
Start-Sleep -Seconds 30


# Clear the contents of the log file
Clear-Content -Path $logFilePath
