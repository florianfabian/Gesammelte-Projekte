$TeamsInstallPath = "${env:LOCALAPPDATA}\Microsoft\Teams"
$UninstallScript = "$TeamsInstallPath\Update.exe"

if (Test-Path $TeamsInstallPath) {
    if (Test-Path $UninstallScript) {
        # Deinstallation von Microsoft Teams
        Start-Process -FilePath $UninstallScript -ArgumentList '--uninstall' -Wait
        Write-Host "Microsoft Teams wurde erfolgreich deinstalliert."
    } else {
        Write-Host "Deinstallationsskript für Microsoft Teams wurde nicht gefunden."
    }
} else {
    Write-Host "Microsoft Teams ist nicht installiert."
}
