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
        result = @()
    }
}

if ($events) {
    # Anzahl der fehlgeschlagenen Anmeldeversuche
    $output.prtg.result += @{
        channel = "Failed Logins"
        value = $events.Count
    }

    # Details der fehlgeschlagenen Anmeldeversuche
    $output.prtg.result += $events | ForEach-Object {
        return @{
            channel = "Login Failure Detail"
            value = $_.Message
        }
    }
} else {
    # Keine fehlgeschlagenen Anmeldeversuche
    $output.prtg.result += @{
        channel = "Failed Logins"
        value = 0
    }
}

# Konvertieren des Ausgabe-Objekts in JSON
$output | ConvertTo-Json



################
#
#In diesem Skript wird ein Hash-Objekt $output erstellt, 
#um die Ergebnisse zu speichern. Die Anzahl der fehlgeschlagenen Anmeldeversuche und die Details zu 
#jedem Versuch werden im $output-Objekt gespeichert. Am Ende des Skripts wird 
#das $output-Objekt in ein JSON-Format konvertiert und ausgegeben.
#
################