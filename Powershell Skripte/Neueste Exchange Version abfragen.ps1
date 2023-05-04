param(
    $ExchangeServer = "EXCH2"
)

function Get-LatestExchangeVersion {
    $url = "https://docs.microsoft.com/de-de/exchange/new-features/build-numbers-and-release-dates?view=exchserver-2019"
    $pageContent = Invoke-WebRequest -Uri $url -UseBasicParsing
    $pattern = 'Exchange Server 2016[^<]*<[\s\S]*?<td style="text-align: center;">([\d.]+)</td>'
    $matches = [regex]::Matches($pageContent.Content, $pattern)
    $versions = $matches | ForEach-Object { $_.Groups[1].Value }
    return $versions | Sort-Object {[Version]$_} -Descending | Select-Object -First 1
}

$currentVersionResult = Invoke-Command -ComputerName $ExchangeServer -ScriptBlock {
    $query = Get-Command Exsetup.exe | Select-Object Version
    $query
}

if ($currentVersionResult -ne $null) {
    $currentVersion = $currentVersionResult.Version.ToString()
}

$latestVersion = Get-LatestExchangeVersion

if (![string]::IsNullOrEmpty($currentVersion) -and ![string]::IsNullOrEmpty($latestVersion)) {
    try {
        $currentVersionObj = [Version]$currentVersion
        $latestVersionObj = [Version]$latestVersion

        if ($currentVersionObj -lt $latestVersionObj) {
            Write-Host "Es ist ein Update verfügbar. Aktuelle Version: $currentVersion, Neueste Version: $latestVersion"
        } else {
            Write-Host "Die aktuelle Version ist bereits die neueste: $currentVersion"
        }
    } catch {
        Write-Host "Fehler beim Vergleichen der Versionen. Überprüfen Sie die Versionszeichenfolgen: Aktuelle Version: $currentVersion, Neueste Version: $latestVersion"
    }
} else {
    Write-Host "Eine oder beide Versionszeichenfolgen sind leer: Aktuelle Version: $currentVersion, Neueste Version: $latestVersion"
}
