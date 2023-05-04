# Import the Exchange Web Services DLL
Add-Type -Path "C:\Program Files\Microsoft\Exchange\Web Services\2.2\Microsoft.Exchange.WebServices.dll"

# Create an Exchange service object
$service = New-Object Microsoft.Exchange.WebServices.Data.ExchangeService -ArgumentList ([Microsoft.Exchange.WebServices.Data.ExchangeVersion]::Exchange2010_SP2)
$service.UseDefaultCredentials = $true
$service.AutodiscoverUrl((whoami /upn), { $true })

# Define the current date
$currentDate = (Get-Date).Date

# Define the folder to search
$inboxFolderId = [Microsoft.Exchange.WebServices.Data.WellKnownFolderName]::Inbox
$searchFilterCollection = New-Object Microsoft.Exchange.WebServices.Data.SearchFilter+SearchFilterCollection([Microsoft.Exchange.WebServices.Data.LogicalOperator]::And)

# Add search filters
$searchFilterCollection.Add((New-Object Microsoft.Exchange.WebServices.Data.SearchFilter+IsEqualTo([Microsoft.Exchange.WebServices.Data.ItemSchema]::DateTimeReceived, $currentDate)))
$searchFilterCollection.Add((New-Object Microsoft.Exchange.WebServices.Data.SearchFilter+IsEqualTo([Microsoft.Exchange.WebServices.Data.ItemSchema]::Subject, "Ex Post Alert: Potenzielle Bedrohung gefunden")))
$searchFilterCollection.Add((New-Object Microsoft.Exchange.WebServices.Data.SearchFilter+IsEqualTo([Microsoft.Exchange.WebServices.Data.ItemSchema]::From, "support@sievers-group.com")))

# Find emails matching the search filters
$itemView = New-Object Microsoft.Exchange.WebServices.Data.ItemView(100)
$foundItems = $service.FindItems($inboxFolderId, $searchFilterCollection, $itemView)

# Process each email
foreach ($item in $foundItems) {
    # Load the email
    $item.Load()

    # Extract email addresses ending with "@medizinisches-zentrum.de"
    $internalRecipients = @()
    foreach ($recipient in $item.ToRecipients) {
        if ($recipient.Address -like "*@medizinisches-zentrum.de") {
            $internalRecipients += $recipient.Address
        }
    }

    # Continue with the rest of the script
}


Add-Type -Path "C:\Program Files\Microsoft\Exchange\Web Services\2.2\Microsoft.Exchange.WebServices.dll"

function Send-WarningEmail($to, $externalEmails) {
    $message = [Microsoft.Exchange.WebServices.Data.EmailMessage]::new($service)
    $message.Subject = "Warnung: Gefährliche E-Mail"
    $message.Body = @"
Eine gefährliche E-Mail wurde zugestellt. Bitte öffnen Sie diese E-Mail NICHT.

Die E-Mail enthält folgende externe E-Mail-Adressen:
$($externalEmails -join ', ')

Bei Rückfragen wenden Sie sich bitte an die IT-Abteilung.
"@
    $message.ToRecipients.Add($to)
    $message.SendAndSaveCopy()
}

$Email = "your-email@medizinisches-zentrum.de"
$Password = ConvertTo-SecureString "your-password" -AsPlainText -Force

$service = New-Object Microsoft.Exchange.WebServices.Data.ExchangeService -ArgumentList ([Microsoft.Exchange.WebServices.Data.ExchangeVersion]::Exchange2010_SP2)
$service.Credentials = New-Object Microsoft.Exchange.WebServices.Data.WebCredentials -ArgumentList $Email, $Password
$service.AutodiscoverUrl($Email, {$true})

$inbox = [Microsoft.Exchange.WebServices.Data.Folder]::Bind($service, [Microsoft.Exchange.WebServices.Data.WellKnownFolderName]::Inbox)

$searchFilter = New-Object Microsoft.Exchange.WebServices.Data.SearchFilter+IsEqualTo -ArgumentList ([Microsoft.Exchange.WebServices.Data.ItemSchema]::IsRead, $false)
$itemView = New-Object Microsoft.Exchange.WebServices.Data.ItemView -ArgumentList 10
$unreadMails = $inbox.FindItems($searchFilter, $itemView)

$domain = "@medizinisches-zentrum.de"

foreach ($mail in $unreadMails) {
    $mail.Load()
    $addresses = [regex]::Matches($mail.Body.Text, '\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b') | ForEach-Object { $_.Value }
    $internalAddresses = $addresses | Where-Object { $_ -like "*$domain" }
    $externalAddresses = $addresses | Where-Object { $_ -notlike "*$domain" }

    if ($internalAddresses) {
        foreach ($internal in $internalAddresses) {
            Write-Host "Sending warning email to: $internal"
            Send-WarningEmail $internal $externalAddresses
        }
    }
}
