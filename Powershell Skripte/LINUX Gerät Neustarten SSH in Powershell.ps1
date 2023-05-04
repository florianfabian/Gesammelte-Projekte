$RemoteHost = "172.16.33.54"
$RemoteUser = "admin"

plink.exe -ssh -t -t -batch -l $RemoteUser -hostkey "ssh-rsa 2048 XX:XX:XX:XX:XX:XX:XX:XX:XX:XX:XX:XX:XX:XX:XX:XX" $RemoteHost "sudo systemctl reboot"
