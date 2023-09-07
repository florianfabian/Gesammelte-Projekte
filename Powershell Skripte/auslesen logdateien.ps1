# Der Pfad zur Log-Datei
$logFile = "Pfad-zur-Log-Datei"

# Laden der Log-Datei
$logContent = Get-Content $logFile

# Zählen der Anzahl der Log-Einträge
$numberOfLogEntries = ($logContent | Measure-Object -Line).Lines

# Anzahl der Log-Einträge für PRTG 
write-Host "$($numberOfLogEntries):Log Entries"
