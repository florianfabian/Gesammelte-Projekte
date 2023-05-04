$dellCommandUpdatePath = "C:\Program Files\Dell\CommandUpdate\dcu-cli.exe"


if (Test-Path $dellCommandUpdatePath) {
    & $dellCommandUpdatePath /ApplyUpdates
    Write-Host "Dell Command Update wurde ausgeführt" -ForegroundColor Green


  
    $result = [System.Windows.Forms.MessageBox]::Show("Updates wurden installiert, und ein Neustart ist zwingend erforderlich. Möchten Sie jetzt neu starten? Wenn Sie auf Nein klicken, wird die Meldung in 30 Minuten erneut angezeigt.", "Neustart erforderlich", [System.Windows.Forms.MessageBoxButtons]::YesNo)

    if ($result -eq 'Yes') {

        Restart-Computer
    } else {

        Start-Sleep -Seconds 1800
        & $MyInvocation.MyCommand.Definition
    }
} else {
    Write-Host "Dell Command Update ist nicht unter dem Pfad installiert" -ForegroundColor Red
}