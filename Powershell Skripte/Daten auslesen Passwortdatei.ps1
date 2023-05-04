# Parameter
$wordFilePath = "\\fs1\users$\fabflo\Documents\PowerShell Skripte\KopieLastPass.docx"
$wordFilePassword = "&texas&"
$csvOutputPath = "\\fs1\users$\fabflo\Documents\PowerShell Skripte\export.csv"

# Erstellen einer Word-Instanz und Öffnen der passwortgeschützten Datei
$wordApp = New-Object -ComObject Word.Application
$wordApp.Visible = $false
$document = $wordApp.Documents.Open($wordFilePath, $false, $true, $false, $wordFilePassword)

# Extrahieren des Textes aus der Word-Datei
$wordText = $document.Content.Text

# Schließen der Word-Datei und Beenden der Word-Instanz
$document.Close()
$wordApp.Quit()

# Bereinigen der Textzeichenkette und Aufteilen in Zeilen
$lines = ($wordText -replace '\r', '').Split([Environment]::NewLine, [System.StringSplitOptions]::RemoveEmptyEntries)

# Extrahieren der Daten (Benutzername, Kennwort, Bemerkungen) und Speichern in einer Liste von benutzerdefinierten Objekten
$dataList = @()
foreach ($line in $lines) {
    $splitLine = $line -split ';'
    $username = $splitLine[0].Trim()
    $password = $splitLine[1].Trim()
    $remarks = $splitLine[2].Trim()

    $dataList += New-Object -TypeName PSObject -Property @{
        Benutzername = $username
        Kennwort     = $password
        Bemerkungen  = $remarks
    }
}

# Exportieren der Daten in eine CSV-Datei (mit Komma und Semikolon als Trennzeichen)
$dataList | Export-Csv -Path $csvOutputPath -Delimiter ';' -Encoding UTF8 -NoTypeInformation

Write-Host "Daten wurden erfolgreich in die CSV-Datei exportiert: $csvOutputPath"
