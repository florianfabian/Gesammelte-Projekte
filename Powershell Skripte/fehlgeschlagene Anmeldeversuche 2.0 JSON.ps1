# Filter-Definition: Event-ID 4625 steht für fehlgeschlagene Anmeldeversuche
$filter = @{
    LogName = 'Security'
    Id = 4625
    StartTime = (Get-Date).AddHours(-1)
}

# Abrufen der Ereignisse basierend auf dem Filter
$events = Get-WinEvent -FilterHashtable $filter

# Erstellen eines Hash-Objekts für die JSON-Ausgabe
$output = @{
    prtg = @{
        result = @(
            @{
                Channel = "Failed Logins"
                Value = $events.Count
                Unit = "Count"
            }
        )
    }
}

# Konvertieren des Ausgabe-Objekts in JSON
$output | ConvertTo-Json
