$ComputerName = "172.16.33.54"
$Credentials = Get-Credential

try {
    Restart-Computer -ComputerName $ComputerName -Credential $Credentials -Force -ErrorAction Stop
    Write-Host "Das Netzwerkgerät $ComputerName wurde erfolgreich neu gestartet."
} catch {
    Write-Host "Fehler beim Neustarten des Netzwerkgeräts $ComputerName"
    Write-Host $_.Exception.Message
}
