# Filter-Definition: Event-ID 4625 steht für fehlgeschlagene Anmeldeversuche
$filter = @{
    LogName = 'Security'
    Id = 4625
    StartTime = (Get-Date).AddHours(-1)
}

# Abrufen der Ereignisse basierend auf dem Filter
$events = Get-WinEvent -FilterHashtable $filter

# Überprüfen, ob fehlgeschlagene Anmeldeversuche gefunden wurden
if ($events) {
    Write-Output "Fehlgeschlagene Anmeldeversuche erkannt!"
    foreach ($event in $events) {
        # Ausgabe der Details des fehlgeschlagenen Anmeldeversuchs
        Write-Output $event.Message
    }
} else {
    Write-Output "Keine fehlgeschlagenen Anmeldeversuche in der letzten Stunde gefunden."
}
