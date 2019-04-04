using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetworkConfigApp
{
    class NetworkCodeComments
    {
        DateTime _routerResetFinishTime = DateTime.MaxValue;

        #region Program Startup Function Bools
        string _routerOutput = "";
        bool _answeredDialog = false;
        bool _answeredTerminateAuto = false;
        bool _answeredPressReturn = false;
        bool _rommonBreak = false;
        bool _rommonMode = false;
        bool _delayTimerRun = false;
        bool _reloadFunction = false;
        #endregion

        #region Startup Delay
        async Task StartupDelay()
        {
            await Task.Delay(10000);
        }
        #endregion

        #region SSH Delay Timer
        async Task SshDelay()
        {
            await Task.Delay(15000);
        }
        #endregion

        #region NVRAM Delay Timer
        async Task NvramDelay()
        {
            await Task.Delay(10000);
        }
        #endregion

        #region Rommon Delay Timer
        async Task RommonDelay()
        {
            await Task.Delay(120000);
        }
        #endregion

        #region SecondDelay
        async Task SecondDelay()
        {
            await Task.Delay(1000);
        }
        #endregion

        string _ipAddress = "";

        public Form1()
        {
            InitializeComponent();
        }

        #region SerialPort
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] serialPorts = SerialPort.GetPortNames();
            foreach (string serialPort in serialPorts)
            {
                comboBoxSerialPorts.Items.Add(serialPort);
            }

            if (comboBoxSerialPorts.Items.Count > 0)
                comboBoxSerialPorts.SelectedIndex = 0;

            serialPort1.Open();
        }

        private void comboBoxSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxSerialPorts.SelectedItem.ToString();
        }
        #endregion

        #region CiscoConfig

        #region Interface Configuration
        private void buttonConfInterface_Click(object sender, EventArgs e)
        {
            #region Variables
            _ipAddress = textBoxIpAddress.Text;
            int hosts = Convert.ToInt32(textBoxAmountOfHosts.Text);
            #endregion

            #region Interface Configuration
            if (radioButtonRIP.Checked)
            {
                if (comboBoxInterfaces.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    WriteToRouter("");
                    StartInterface(hosts);
                    CallFunctionRip(hosts);
                }
            }

            else if (radioButtonEIGRP.Checked)
            {
                if (comboBoxInterfaces.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    WriteToRouter("");
                    StartInterface(hosts);
                    CallFunctionEigrp(hosts);
                }
            }

            else //if (radioButtonNone.Checked)
            {
                if (comboBoxInterfaces.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    WriteToRouter("");
                    StartInterface(hosts);
                }
            }
            #endregion
        }

        private void StartInterface(int hosts)
        {
            string interfaceName = GetInterface(comboBoxInterfaces.SelectedIndex);
            string subnet = GetSubnetMask(hosts);
            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("interface " + interfaceName + "");
            WriteToRouter("ip address " + _ipAddress + " " + subnet + "");
            WriteToRouter("no shutdown");
            WriteToRouter("end");
        }

        private void CallFunctionEigrp(int hosts)
        {
            string subnet = GetSubnetMask(hosts);
            string wildCard = GetWildCardMask(hosts);

            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("router eigrp 1");
            WriteToRouter("network " + _ipAddress + " " + wildCard + "");
            WriteToRouter("no auto-summary");
            WriteToRouter("end");
        }

        private void CallFunctionRip(int hosts)
        {
            string subnet = GetSubnetMask(hosts);

            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("router rip");
            WriteToRouter("version 2");
            WriteToRouter("network " + _ipAddress + " " + subnet + "");
            WriteToRouter("no auto-summary");
            WriteToRouter("end");
        }

        private string GetInterface(int interFace)
        {
            string interfaceName = "";

            switch (interFace)
            {
                case (0):
                    interfaceName = "FastEthernet 0/0";
                    break;

                case (1):
                    interfaceName = "FastEthernet 0/1";
                    break;

                case (2):
                    interfaceName = "FastEthernet 0/2";
                    break;

                case (3):
                    interfaceName = "FastEthernet 0/3";
                    break;

                case (4):
                    interfaceName = "FastEthernet 0/4";
                    break;

                case (5):
                    interfaceName = "FastEthernet 0/5";
                    break;

                case (6):
                    interfaceName = "FastEthernet 0/6";
                    break;

                case (7):
                    interfaceName = "FastEthernet 0/7";
                    break;

                case (8):
                    interfaceName = "FastEthernet 0/8";
                    break;

                case (9):
                    interfaceName = "FastEthernet 0/9";
                    break;

                case (10):
                    interfaceName = "FastEthernet 0/10";
                    break;

                case (11):
                    interfaceName = "FastEthernet 0/11";
                    break;

                case (12):
                    interfaceName = "FastEthernet 0/12";
                    break;

                case (13):
                    interfaceName = "FastEthernet 0/13";
                    break;

                case (14):
                    interfaceName = "FastEthernet 0/14";
                    break;

                case (15):
                    interfaceName = "FastEthernet 0/15";
                    break;

                case (16):
                    interfaceName = "FastEthernet 0/16";
                    break;

                case (17):
                    interfaceName = "FastEthernet 0/17";
                    break;

                case (18):
                    interfaceName = "FastEthernet 0/18";
                    break;

                case (19):
                    interfaceName = "FastEthernet 0/19";
                    break;

                case (20):
                    interfaceName = "FastEthernet 0/20";
                    break;

                case (21):
                    interfaceName = "FastEthernet 0/21";
                    break;

                case (22):
                    interfaceName = "FastEthernet 0/22";
                    break;

                case (23):
                    interfaceName = "FastEthernet 0/23";
                    break;

                case (24):
                    interfaceName = "Serial 0/0/0";
                    break;

                case (25):
                    interfaceName = "Serial 0/0/1";
                    break;

                case (26):
                    interfaceName = "Serial 0/1/0";
                    break;

                case (27):
                    interfaceName = "Serial 0/1/1";
                    break;

                case (28):
                    interfaceName = "Serial 0/2/0";
                    break;

                case (29):
                    interfaceName = "Serial 0/2/1";
                    break;

                case (30):
                    interfaceName = "Serial 0/3/0";
                    break;

                case (31):
                    interfaceName = "Serial 0/3/1";
                    break;


            }

            return interfaceName;
        }

        private string GetSubnetMask(int hosts)
        {
            string subnetMask = "";

            switch (hosts)
            {

                case 1 when hosts < 7:
                    subnetMask = "255.255.255.248";
                    break;

                case 2 when hosts < 15:
                    subnetMask = "255.255.255.240";
                    break;

                case 3 when hosts < 31:
                    subnetMask = "255.255.255.224";
                    break;

                case 4 when hosts < 63:
                    subnetMask = "255.255.255.192";
                    break;

                case 5 when hosts < 127:
                    subnetMask = "255.255.255.128";
                    break;

                case 6 when hosts < 254:
                    subnetMask = "255.255.255.0";
                    break;

                case 7 when hosts < 511:
                    subnetMask = "255.255.254.0";
                    break;

                case 8 when hosts < 1023:
                    subnetMask = "255.255.252.0";
                    break;

                case 9 when hosts < 2047:
                    subnetMask = "255.255.248.0";
                    break;

                case 10 when hosts < 4095:
                    subnetMask = "255.255.240.0";
                    break;

                case 11 when hosts < 8191:
                    subnetMask = "255.255.224.0";
                    break;

                case 12 when hosts < 16383:
                    subnetMask = "255.255.192.0";
                    break;

                case 13 when hosts < 32767:
                    subnetMask = "255.255.128.0";
                    break;

                case 14 when hosts < 65535:
                    subnetMask = "255.255.0.0";
                    break;
            }

            return subnetMask;
        }

        private string GetWildCardMask(int hosts)
        {
            string wildCardMask = "";

            switch (hosts)
            {

                case 1 when hosts < 7:
                    wildCardMask = "0.0.0.7";
                    break;

                case 2 when hosts < 15:
                    wildCardMask = "0.0.0.15";
                    break;

                case 3 when hosts < 31:
                    wildCardMask = "0.0.0.31";
                    break;

                case 4 when hosts < 63:
                    wildCardMask = "0.0.0.63";
                    break;

                case 5 when hosts < 127:
                    wildCardMask = "0.0.0.127";
                    break;

                case 6 when hosts < 254:
                    wildCardMask = "0.0.0.255";
                    break;

                case 7 when hosts < 511:
                    wildCardMask = "0.0.1.255";
                    break;

                case 8 when hosts < 1023:
                    wildCardMask = "0.0.3.255";
                    break;

                case 9 when hosts < 2047:
                    wildCardMask = "0.0.7.255";
                    break;

                case 10 when hosts < 4095:
                    wildCardMask = "0.0.15.255";
                    break;

                case 11 when hosts < 8191:
                    wildCardMask = "0.0.31.255";
                    break;

                case 12 when hosts < 16383:
                    wildCardMask = "0.0.63.255";
                    break;

                case 13 when hosts < 32767:
                    wildCardMask = "0.0.127.255";
                    break;

                case 14 when hosts < 65535:
                    wildCardMask = "0.0.255.255";
                    break;
            }
            return wildCardMask;
        }
        #endregion

        #region Configure Host name and MOTD
        private void buttonConfHost_Click(object sender, EventArgs e)
        {
            #region Variables
            string hostName = textBoxHostName.Text;
            string motd = textBoxMOTD.Text;
            #endregion

            #region Hostname/MOTD
            WriteToRouter("");
            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("hostname " + hostName + "");
            WriteToRouter("banner motd" + motd + "");
            WriteToRouter("end");
            #endregion
        }
        #endregion

        #region Configure Password
        private void buttonConfPass_Click(object sender, EventArgs e)
        {
            if (radioButtonNormalPass.Checked)
            {
                WriteToRouter("");
                ConfigureNormalPass();
            }
            else if (radioButtonSecretPass.Checked)
            {
                WriteToRouter("");
                ConfigureSecretPass();
            }
            else
            {
                MessageBox.Show("Please select normal or secret password.");
            }
        }

        private void ConfigureNormalPass()
        {
            string passWord1 = textBoxPassword1.Text;
            string passWord2 = textBoxPassword2.Text;

            if (passWord1 != passWord2)
            {
                MessageBox.Show("Your password do not match.");
            }
            else
            {
                WriteToRouter("enable");
                WriteToRouter("conf t");
                WriteToRouter("enable password " + passWord1 + "");
                WriteToRouter("login");
                if (checkBoxPassEncryption.Checked)
                {
                    WriteToRouter("service password encryption");
                }
                WriteToRouter("end");
            }
        }

        private void ConfigureSecretPass()
        {
            string passWord1 = textBoxPassword1.Text;
            string passWord2 = textBoxPassword2.Text;

            if (passWord1 != passWord2)
            {
                MessageBox.Show("Your password do not match.");
            }
            else
            {
                WriteToRouter("enable");
                WriteToRouter("conf t");
                WriteToRouter("enable secret " + passWord1 + "");
                WriteToRouter("login");
                if (checkBoxPassEncryption.Checked)
                {
                    WriteToRouter("service password encryption");
                }
                WriteToRouter("end");
            }
        }
        #endregion

        #region Login Block-For
        private void buttonLoginBlock_Click(object sender, EventArgs e)
        {
            string lockoutTime = textBoxLockoutTime.Text;
            string attempts = textBoxAttempts.Text;
            string loginTime = textBoxLoginTime.Text;

            WriteToRouter("");
            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("login block-for " + lockoutTime + " attempts " + attempts + " within " + loginTime + "");
            WriteToRouter("end");
        }
        #endregion

        #region Configure DHCP and DNS
        private void buttonConfDHCP_Click(object sender, EventArgs e)
        {
            string poolName = textBoxPoolName.Text;
            string dhcpNetwork = textBoxNetworkDHCP.Text;
            string domainName = textBoxDomainName.Text;
            string dnsServerAddrPrimary = textBoxDNSServerPrimary.Text;
            string dnsServerAddrSecondary = textBoxDNSServerSecondary.Text;
            string defaultGateway = textBoxDefaultGateway.Text;
            string leaseDuration = textBoxLeaseDuration.Text;
            string excludedAddr = textBoxExcludedAddresses.Text;

            WriteToRouter("");
            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("ip dhcp pool " + poolName + "");
            WriteToRouter("network " + dhcpNetwork + "");
            WriteToRouter("domain-name " + domainName + "");
            WriteToRouter("dns-Server " + dnsServerAddrPrimary + " " + dnsServerAddrSecondary + "");
            WriteToRouter("default-router " + defaultGateway + "");
            WriteToRouter("lease " + leaseDuration + "");
            WriteToRouter("exit");
            WriteToRouter("ip dhcp excluded-address " + excludedAddr + "");
            WriteToRouter("end");
        }
        #endregion

        #region Configure SSH/Telnet
        private async void buttonSSHTelnet_Click(object sender, EventArgs e)
        {
            string domainNameSsh = textBoxDomainNameSSH.Text;
            string userNameSsh = textBoxUserNameSSH.Text;
            string passwordSsh = textBoxPasswordSSH.Text;
            string keyModulus = textBoxKeyModulus.Text;
            string vtyLines = textBoxVtyLines.Text;

            WriteToRouter("");
            WriteToRouter("enable");
            WriteToRouter("conf t");
            WriteToRouter("username " + userNameSsh + " secret " + passwordSsh + "");
            WriteToRouter("ip domain-name " + domainNameSsh + "");
            WriteToRouter("crypto key generate rsa");
            WriteToRouter(keyModulus + "");
            await SshDelay();
            WriteToRouter("line vty " + vtyLines + "");

            if (radioButtonSSH.Checked)
                WriteToRouter("transport input ssh");

            if (radioButtonTelnet.Checked)
                WriteToRouter("transport input telnet");

            WriteToRouter("login local");
            WriteToRouter("end");
        }
        #endregion

        #region Save Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            WriteToRouter("");
            WriteToRouter("enable");
            WriteToRouter("copy running-config startup-config");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region Erase NVRAM
        private async void buttonEraseNvram_Click(object sender, EventArgs e)
        {
            WriteToRouter("");
            WriteToRouter("enable");
            WriteToRouter("erase nvram");
            await NvramDelay();
            WriteToRouter("reload");
        }
        #endregion

        #region ROMmon Reset
        private async void buttonROMmon_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            _routerResetFinishTime = now.AddSeconds(170);
            timerRouterReset.Enabled = true;

            tabControl.Enabled = false;

            WriteToRouter("");
            await SecondDelay();

            ReadFromRouter();

            if (_routerOutput.Contains(">") && _reloadFunction == false)
            {
                WriteToRouter("enable");
                WriteToRouter("reload");
                WriteToRouter("");
                await StartupDelay();
                ReadFromRouter();
                _reloadFunction = true;
            }

            if (_routerOutput.Contains("Readonly ROMMON initialized") && _rommonBreak == false)
            {
                serialPort1.BreakState = true;
                serialPort1.BreakState = false;
                _rommonBreak = true;
                await SecondDelay();
                await SecondDelay();
                ReadFromRouter();
            }

            if (_routerOutput.Contains("rommon 1>") && _rommonMode == false)
            {
                _rommonMode = true;
                WriteToRouter("confreg 0x2142");
                WriteToRouter("reset");
                await RommonDelay();
                WriteToRouter("no");
                await SshDelay();
                WriteToRouter("no");
                await SshDelay();
                WriteToRouter("enable");
                WriteToRouter("conf t");
                WriteToRouter("config-register 0x2102");
                serialPort1.BreakState = true;
                serialPort1.BreakState = false;
                await NvramDelay();
                WriteToRouter("exit");
                WriteToRouter("copy running-config startup-config");
                WriteToRouter("end");
                tabControl.Enabled = true;
                timerRouterReset.Enabled = false;
            }
        }

        private void WriteToRouter(string input)
        {
            serialPort1.Write(input + "\r\n");
            Console.WriteLine(input);
        }

        private void ReadFromRouter()
        {
            //string routerOutputTemp = serialPort1.ReadExisting();
            //routerOutput = routerOutput + routerOutputTemp;
            //Console.WriteLine(routerOutputTemp);
        }
        #endregion

        #region Program Startup Function
        private async void timer1_Tick(object sender, EventArgs e)
        {
            ReadFromRouter();

            if (_routerOutput.Contains("dialog? [yes/no]:") && _answeredDialog == false)
            {
                WriteToRouter("no");
                _answeredDialog = true;
            }

            else if (_routerOutput.Contains("terminate autoinstall? [yes]:") && _answeredTerminateAuto == false)
            {
                WriteToRouter("yes");
                _answeredTerminateAuto = true;
            }

            else if (_routerOutput.Contains("Press RETURN to get started!") && _answeredPressReturn == false)
            {
                if (_delayTimerRun == false)
                {
                    WriteToRouter("");
                    _delayTimerRun = true;
                    await StartupDelay();
                    WriteToRouter("");
                }

                buttonConfDHCP.Enabled = true;
                buttonConfHost.Enabled = true;
                buttonConfInterface.Enabled = true;
                buttonConfPass.Enabled = true;
                buttonEraseNvram.Enabled = true;
                buttonLoginBlock.Enabled = true;
                buttonROMmon.Enabled = true;
                buttonSaveConf.Enabled = true;
                buttonSSHTelnet.Enabled = true;
                _answeredPressReturn = true;
            }

            if (_routerOutput.Contains(">"))
                timer1.Enabled = false;

        }
        #endregion

        private void timerRouterReset_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeLeft = _routerResetFinishTime - now;
            labelTimer.Text = timeLeft.TotalSeconds.ToString();
        }

        private void buttonOverride_Click(object sender, EventArgs e)
        {
            buttonConfDHCP.Enabled = true;
            buttonConfHost.Enabled = true;
            buttonConfInterface.Enabled = true;
            buttonConfPass.Enabled = true;
            buttonEraseNvram.Enabled = true;
            buttonLoginBlock.Enabled = true;
            buttonROMmon.Enabled = true;
            buttonSaveConf.Enabled = true;
            buttonSSHTelnet.Enabled = true;
            timer1.Enabled = false;
        }
        #endregion

        #region HPConfig






        #endregion

        private void button1_Click_2(object sender, EventArgs e)
        {
            string interFaceVlan = GetInterface(vlanInterface.SelectedIndex);
            int vlan = Convert.ToInt32(vlanNumBox);
            string vlanName = vlanNameBox.Text;

            WriteToRouter("enable");
            WriteToRouter("configure terminal");
            WriteToRouter("vlan " + vlan);
            WriteToRouter("name " + vlanName);
            WriteToRouter("exit");

            if (accessRadio.Checked)
            {
                WriteToRouter("interface " + interFaceVlan);
                WriteToRouter("switchport mode access");
                WriteToRouter("switchport access vlan " + vlan);
            }
            else if (dynamicRadio.Checked)
            {
                WriteToRouter("interface " + interFaceVlan);
                WriteToRouter("switchport mode dynamic");
                WriteToRouter("switchport dynamic vlan " + vlan);
            }
            else if (trunkRadio.Checked)
            {
                WriteToRouter("interface " + interFaceVlan);
                WriteToRouter("switchport mode trunk");
                WriteToRouter("switchport trunk vlan " + vlan);
            }
        }

        private void routeStatic_Click(object sender, EventArgs e)
        {
            string targetNet = targetNetwork.Text;
            string targetSub = targetSubnet.Text;
            string nextJump = nextJumpAddr.Text;

            WriteToRouter("enable");
            WriteToRouter("configure terminal");
            WriteToRouter("ip route " + targetNet + " " + targetSub + " " + nextJump);
        }
    }
}
}
