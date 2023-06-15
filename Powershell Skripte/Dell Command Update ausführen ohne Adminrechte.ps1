# Pfad zum Dell Command Update-Programm
$dellCommandUpdatePath = "C:\Program Files\Dell\CommandUpdate\dcu-cli.exe"

# Erstelle ein neues ScheduledTaskAction-Objekt für das Update
$aktion = New-ScheduledTaskAction -Execute $dellCommandUpdatePath -Argument "/ApplyUpdates"

# Erstelle ein neues ScheduledTaskPrincipal-Objekt, um die Aufgabe mit höchsten Berechtigungen auszuführen
$principal = New-ScheduledTaskPrincipal -UserId "NT AUTHORITY\SYSTEM" -LogonType ServiceAccount -RunLevel Highest

# Erstelle und registriere die Aufgabe
Register-ScheduledTask -Action $aktion -Principal $principal -TaskName "DellCommandUpdate" -Description "Führt das Dell Command Update als der aktuell angemeldete Benutzer aus"

# Starte die Aufgabe
Start-ScheduledTask -TaskName "DellCommandUpdate"
