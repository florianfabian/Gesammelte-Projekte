$dellCommandUpdatePath = "C:\Program Files\Dell\CommandUpdate\dcu-cli.exe"


if (Test-Path $dellCommandUpdatePath) {

    & $dellCommandUpdatePath /ApplyUpdates
    Write-Host "Dell Command Update wurde ausgeführt" -ForegroundColor Green

    Add-Type -AssemblyName PresentationFramework, PresentationCore, WindowsBase


    $xaml = @"
<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Neustart erforderlich" Height="150" Width="450">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>
        <TextBlock Grid.Row="0" Text="Die Updates wurden installiert, und ein Neustart ist ZWINGEND erforderlich. Möchten Sie jetzt neu starten? Wenn Sie auf 'Später' klicken, wird die Meldung in 30 Minuten erneut angezeigt." TextWrapping="Wrap" Margin="10"/>
        <StackPanel Grid.Row="1" Orientation="Horizontal" HorizontalAlignment="Center" Margin="0,10">
            <Button x:Name="RestartNow" Content="Jetzt neu starten" Margin="0,0,10,0"/>
            <Button x:Name="RestartLater" Content="Später"/>
        </StackPanel>
    </Grid>
</Window>
"@


    $window = [Windows.Markup.XamlReader]::Parse($xaml)


    $window.RestartNow.Add_Click({
        Restart-Computer
    })

    $window.RestartLater.Add_Click({
        $window.Close()
        Start-Sleep -Seconds 1800
        $window.ShowDialog() | Out-Null
    })

    $window.ShowDialog() | Out-Null
} else {
    Write-Host "Dell Command Update ist nicht unter dem Pfad installiert" -ForegroundColor Red
}
