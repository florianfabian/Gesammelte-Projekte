$Verzeichnis = "C:\Backup" 
$Tage = 7
$Datumsgrenze = (Get-Date).AddDays(-$Tage)

Get-ChildItem -Path $Verzeichnis -Recurse -File | Where-Object { $_.LastWriteTime -lt $Datumsgrenze } | Remove-Item -Force
