# Path to Dell Command Update executable
$dellCommandUpdatePath = "C:\Program Files\Dell\CommandUpdate\dcu-cli.exe"

# Check if Dell Command Update exists on the local computer
if (Test-Path $dellCommandUpdatePath) {
    # Run Dell Command Update locally
    & $dellCommandUpdatePath /ApplyUpdates
    Write-Host "Dell Command Update wurde ausgeführt" -ForegroundColor Green

    # Set the timer to check for inactivity every minute
    $timer = New-Object System.Timers.Timer
    $timer.Interval = 60 * 1000
    $timer.AutoReset = $true

    # Define the timer elapsed event
    $timerElapsedEvent = Register-ObjectEvent -InputObject $timer -EventName Elapsed -Action {
        $lastInputInfo = New-Object -TypeName Windows.Win32.SystemInformation.LastInputInfo
        $null = [Windows.Win32.SystemInformation.GetLastInputInfo]::Invoke($lastInputInfo)

        $idleTime = ((Get-Date).ToFileTime() - $lastInputInfo.LastInputTime) / 60000000

        if ($idleTime -ge 35) {
            $timer.Stop()
            Restart-Computer
        }
    }

    # Start the timer
    $timer.Start()

} else {
    Write-Host "Dell Command Update ist nicht unter dem Pfad installiert" -ForegroundColor Red
}
