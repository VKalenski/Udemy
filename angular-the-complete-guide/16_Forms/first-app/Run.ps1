# Set the locations
$angularProjectPath = "C:\Users\vilis\OneDrive\Documents\Kalenski_GitHub\Angular-The-Complete-Guide\16_Forms\first-app\"
Set-Location $angularProjectPath
Write-Host "Setting project location $angularProjectPath" -ForegroundColor Green
Write-Host  "--------------------------------------------------------------------------------------------------------------------------"

# Commands
Write-Host "Running 'npm install'" -ForegroundColor Green
npm install
Write-Host  "--------------------------------------------------------------------------------------------------------------------------"

Write-Host "Running 'npm update'" -ForegroundColor Green
npm update
Write-Host  "--------------------------------------------------------------------------------------------------------------------------"

Write-Host "Build the project with 'ng build'" -ForegroundColor Green
ng build
Write-Host  "--------------------------------------------------------------------------------------------------------------------------"

Write-Host "Starting the project with 'ng serve'" -ForegroundColor Green
ng serve