# Importiere die benötigten .Net Klassen
Add-Type -TypeDefinition @"
using System;
using System.Runtime.InteropServices;

public class DruckerEinstellungen {
    [DllImport("winspool.Drv", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool SetPrinter(IntPtr hPrinter, int Level, IntPtr pPrinter, int Command);

    [DllImport("winspool.Drv", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

    [DllImport("winspool.Drv", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool GetPrinter(IntPtr hPrinter, int Level, IntPtr pPrinter, int cbBuf, ref int pcbNeeded);
}
"@

# Setze den Namen des Druckers
$druckerName = "IhrDruckerName"

# Öffne den Drucker
$druckerGeoeffnet = [DruckerEinstellungen]::OpenPrinter($druckerName, [ref]$druckerHandle, $null)

if ($druckerGeoeffnet) {
    try {
        # Rufe die Druckereinstellungen ab
        $druckerEinstellungen = New-Object Byte[] 1024
        $pcbNeeded = New-Object Int32
        $erfolgreich = [DruckerEinstellungen]::GetPrinter($druckerHandle, 2, $druckerEinstellungen, $druckerEinstellungen.Length, [ref]$pcbNeeded)

        if ($erfolgreich) {
            # Setze die Einstellung auf doppelseitigen Druck
            $druckerEinstellungen[68] = 1

            # Aktualisiere die Druckereinstellungen
            $erfolgreich = [DruckerEinstellungen]::SetPrinter($druckerHandle, 2, $druckerEinstellungen, 0)

            if (-not $erfolgreich) {
                Write-Error "Die Druckereinstellungen konnten nicht aktualisiert werden."
            }
        }
        else {
            Write-Error "Die Druckereinstellungen konnten nicht abgerufen werden."
        }
    }
    finally {
        # Schließe den Drucker
        [void][DruckerEinstellungen]::ClosePrinter($druckerHandle)
    }
}
else {
    Write-Error "Der Drucker konnte nicht geöffnet werden."
}
