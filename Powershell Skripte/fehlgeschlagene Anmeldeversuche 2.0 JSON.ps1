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
    "channelid" = 0
    "unit"      = "Count"
    "mode"      = "Absolute"
    "showChart" = "1"
    "showTable" = "0"
    "warning"   = "0"
    "float"     = "0"
    "value"     = $events.Count
}
$jsonResultsNode += $resultHashTableItem

$statusHashTableItem = @{
    "text"   = "Script completed successfully"
}
$jsonResultsNode += $statusHashTableItem

$jsonPrtgNode.Add("result",$jsonResultsNode)
$jsonRoot.Add("prtg",$jsonPrtgNode)

$jsonRoot | ConvertTo-Json -Depth 3
