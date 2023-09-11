using System;
using System.Management;
using System.Management.Automation;
using System.Windows.Forms;

namespace USB_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_prt_Click_1(object sender, EventArgs e)
        {
            lb_Info.HorizontalScrollbar = true;
            lb_Info.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");

            foreach (ManagementObject device in searcher.Get())
            {
                string deviceId = device["DeviceID"].ToString();

                // PowerShell 스크립트를 사용하여 USB 장치의 마지막 연결 시각을 찾습니다.
                using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                    PowerShellInstance.AddScript(
                        "Get-WinEvent -FilterHashTable @{ProviderName='Microsoft-Windows-DriverFrameworks-UserMode'; Id=2101} | " +
                        "Where-Object { $_.Message -match '.*" + deviceId.Replace("\\", "\\\\") + ".*' } | " +
                        "Select-Object -First 1 | " +
                        "ForEach-Object { $_.TimeCreated }"
                    );

                    var timeCreated = PowerShellInstance.Invoke();
                    string lastConnectedTime = (timeCreated.Count > 0) ? timeCreated[0].ToString() : "Unknown";

                    lb_Info.Items.Add($"DeviceID: {deviceId}, Last Connected Time: {lastConnectedTime}");
                }
            }
        }
    }
}
