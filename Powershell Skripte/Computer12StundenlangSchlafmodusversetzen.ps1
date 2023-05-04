Add-Type -TypeDefinition @"
using System;
using System.Runtime.InteropServices;

public class PowerManager {
    [DllImport("Powrprof.dll", SetLastError=true)]
    public static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);
}
"@

[PowerManager]::SetSuspendState($true, $false, $false)

Start-Sleep -Seconds (12 * 60 * 60)

$rtcWakeupTime = (Get-Date).AddSeconds(1)
$wakeupTime = $rtcWakeupTime.ToString("HH:mm:ss")
powershell -Command "Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\TimeZoneInformation' -Name 'RealTimeIsUniversal' -Value 1"
shutdown.exe /h /t 1 /c "Scheduled wake up" /fw /rtc:$wakeupTime
