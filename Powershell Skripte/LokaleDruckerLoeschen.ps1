Get-WmiObject -Query "Select * From Win32_Printer Where Local = TRUE" | ForEach-Object { $_.Delete() }
