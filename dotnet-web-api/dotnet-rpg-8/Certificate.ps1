$location = Get-Location

$certificate = Get-ChildItem -Path Cert:LocalMachine\MY | Select-Object FriendlyName, Thumbprint | Where-Object { $_.FriendlyName -match "KalenskiCert" }

if ($null -eq $certificate) {
    Write-Host "Creating new certificate."
    $certificate = New-SelfSignedCertificate -FriendlyName "KalenskiCert" -DnsName "localhost" -CertStoreLocation "Cert:\LocalMachine\My"
}
else{
    Write-Host "Certificate already exists."
}


# Export and add to Trust root
$trustedCert = Get-ChildItem -Path Cert:LocalMachine\Root | Select-Object FriendlyName, Thumbprint | Where-Object { $_.FriendlyName -match "KalenskiCert" }

if (($null -eq $trustedCert) -or ($trustedCert.Thumbprint -ne $certificate.Thumbprint)){
$certToExport = Get-ChildItem -Path "cert:\LocalMachine\My\$($certificate.Thumbprint)"
$exportedCert = Export-Certificate -Cert $certToExport -FilePath "$($location)\localhost.cer" # create variable to not add message
$certToImport = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2("$($location)\localhost.cer") -Property @{ FriendlyName = "KalenskiCert" }
$rootStore = Get-Item cert:\LocalMachine\Root
$rootStore.Open("ReadWrite")
$rootStore.Add($certToImport)
$rootStore.Close()
Write-Host "Certificate imported in Trusted Root"
}
else{
Write-Host "Certificate is already trusted."
}

if (Test-Path "$($location)\localhost.cer") {
    Remove-Item "$($location)\localhost.cer"
}

$certificate.Thumbprint