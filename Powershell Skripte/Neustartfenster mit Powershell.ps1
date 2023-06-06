Add-Type -TypeDefinition @"
using System;
using System.Windows.Forms;
using System.Drawing;

public class RestartDialog : Form
{
    Button restartButton;
    Button cancelButton;
    Label lastRestartLabel;
    Label infoLabel;

    public RestartDialog()
    {
        this.Text = "System Neustart";
        this.Width = 500;
        this.Height = 200;

        this.restartButton = new Button();
        this.restartButton.Text = "Jetzt neustarten";
        this.restartButton.Location = new Point(75, 130);
        this.restartButton.Click += new EventHandler(this.RestartButton_Click);

        this.cancelButton = new Button();
        this.cancelButton.Text = "Neustart abbrechen";
        this.cancelButton.Location = new Point(275, 130);
        this.cancelButton.Click += new EventHandler(this.CancelButton_Click);

        this.lastRestartLabel = new Label();
        this.lastRestartLabel.Text = "Letzter Neustart: " + GetLastRestartTime();
        this.lastRestartLabel.Location = new Point(30, 50);
        this.lastRestartLabel.Font = new Font(FontFamily.GenericSerif, 12.0F, FontStyle.Bold);
        
        this.infoLabel = new Label();
        this.infoLabel.Text = "Regelmäßige Neustarts sind wichtig für die Sicherheit und Leistung Ihres Computers. Wenn Sie Fragen haben, wenden Sie sich bitte an die IT-Abteilung.";
        this.infoLabel.Location = new Point(30, 80);
        this.infoLabel.Size = new Size(400, 40);
        
        this.Controls.Add(restartButton);
        this.Controls.Add(cancelButton);
        this.Controls.Add(lastRestartLabel);
        this.Controls.Add(infoLabel);
    }

    private void RestartButton_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private string GetLastRestartTime()
    {
        DateTime lastBootUpTime = DateTime.ParseExact(System.Management.ManagementDateTimeConverter.ToDateTime(
            new System.Management.ManagementObject("Win32_OperatingSystem=@").Properties["LastBootUpTime"].Value.ToString()).ToString(), 
            "MM/dd/yyyy HH:mm:ss", null);

        TimeSpan diff = DateTime.Now - lastBootUpTime;

        return string.Format("{0} Tage, {1} Stunden, {2} Minuten", diff.Days, diff.Hours, diff.Minutes);
    }
}
"@

[void][RestartDialog]::new().ShowDialog()
