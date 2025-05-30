# Път към файла с логове
$logFilePath = ".\File.txt"

if (-not (Test-Path -Path $logFilePath)) {
    New-Item -Path $logFilePath -ItemType File | Out-Null
}
# Изчистване на съдържанието на файла, ако съществува, за да започнем с чист файл за новите логове
Clear-Content -Path $logFilePath -Force

# Изпълнение на командата и записване на резултата в лог файла
$dotnetVersion = dotnet --version 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "The .NET version: $dotnetVersion" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"

$dotnetRestoreOutput = dotnet restore 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Restore is correct" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"

$dotnetBuildOutput = dotnet build 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Build is correct" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"

$dotnetEfOutput = dotnet-ef 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "dotnet-ef is here" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"

$dotnetEfUpdateOutput = dotnet tool update --global dotnet-ef 2>&1 | Out-File -FilePath $logFilePath -Append
Write-Host "Update dotnet-ef" -ForegroundColor Blue
Add-Content -Path $logFilePath -Value "-------------------------------------------------------------"

Start-Sleep -Seconds 10
Clear-Content -Path $logFilePath
