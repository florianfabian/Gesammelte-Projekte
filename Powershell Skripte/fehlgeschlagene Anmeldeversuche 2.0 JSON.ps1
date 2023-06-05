# Filter-Definition: Event-ID 4625 steht für fehlgeschlagene Anmeldeversuche
$filter = @{
    LogName = 'Security'
    Id = 4625
    StartTime = (Get-Date).AddHours(-1)
}

# Abrufen der Ereignisse basierend auf dem Filter
$events = Get-WinEvent -FilterHashtable $filter

# Erstellen eines Hash-Objekts für die JSON-Ausgabe
$jsonRoot = @{}
$jsonPrtgNode = @{}
$jsonResultsNode = @()

$resultHashTableItem = @{
    "channel"   = "Failed Logins"
    "unit"      = "Count"
    "mode"      = "Absolute"
    "showChart" = "1"
    "showTable" = "0"
    "warning"   = "0"
    "float"     = "0"
    "value"     = $events.Count
}
$jsonResultsNode += $resultHashTableItem

$jsonPrtgNode.Add("result",$jsonResultsNode)
$jsonPrtgNode.Add("text", "Script completed successfully")

$jsonRoot.Add("prtg",$jsonPrtgNode)

$jsonRoot | ConvertTo-Json -Depth 3
