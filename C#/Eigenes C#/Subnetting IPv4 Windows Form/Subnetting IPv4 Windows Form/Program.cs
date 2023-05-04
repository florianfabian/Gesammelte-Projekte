using System;
using System.Windows.Forms;

namespace IP_Subnet_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string ipAddress = ipAddressTxtBox.Text;
            string subnetSuffix = subnetSuffixTxtBox.Text;

            // Split IP address into octets
            string[] ipOctets = ipAddress.Split('.');

            // Calculate subnet mask
            int maskLength = Convert.ToInt32(subnetSuffix);
            int subnetMask = 0xFFFFFFFF << (32 - maskLength);

            // Calculate number of subnets and hosts per subnet
            int subnets = 1 << maskLength;
            int hostsPerSubnet = 0x7FFFFFFF >> maskLength;

            // Output results
            resultTxtBox.AppendText("Subnet Mask: " + ((subnetMask >> 24) & 0xFF) + "." + ((subnetMask >> 16) & 0xFF) + "." + ((subnetMask >> 8) & 0xFF) + "." + (subnetMask & 0xFF) + "\r\n");
            resultTxtBox.AppendText("Number of Subnets: " + subnets + "\r\n");
            resultTxtBox.AppendText("Hosts per Subnet: " + hostsPerSubnet + "\r\n\r\n");

            for (int i = 0; i < subnets; i++)
            {
                int networkAddress = (i << (32 - maskLength)) & subnetMask;
                int broadcastAddress = networkAddress | ~subnetMask;
                int firstUsableAddress = networkAddress + 1;
                int lastUsableAddress = broadcastAddress - 1;

                resultTxtBox.AppendText("Subnet " + (i + 1) + ":\r\n");
                resultTxtBox.AppendText("Network Address: " + ((networkAddress >> 24) & 0xFF) + "." + ((networkAddress >> 16) & 0xFF) + "." + ((networkAddress >> 8) & 0xFF) + "." + (networkAddress & 0xFF) + "\r\n");
                resultTxtBox.AppendText("Broadcast Address: " + ((broadcastAddress >> 24) & 0xFF) + "." + ((broadcastAddress >> 16) & 0xFF) + "." + ((broadcastAddress >> 8) & 0xFF) + "." + (broadcastAddress & 0xFF) + "\r\n");
                resultTxtBox.AppendText("First Usable Address: " + ((firstUsableAddress >> 24) & 0xFF) + "." + ((firstUsableAddress >> 16) & 0xFF) + "." + ((firstUsableAddress >> 8) & 0xFF) + "." + (firstUsableAddress & 0xFF) + "\r\n");
                resultTxtBox.AppendText("Last Usable Address: " + ((lastUsableAddress >> 24) & 0xFF) + "." + ((lastUsableAddress >> 16) & 0xFF) + "." + ((lastUsableAddress >> 8) & 0xFF) + "." + (lastUsableAddress & 0xFF) + "\r\n\r\n");
            }
        }
