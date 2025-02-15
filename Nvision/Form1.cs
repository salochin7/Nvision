using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using LibreHardwareMonitor.Hardware;
using System.Collections.Generic;
using HidSharp.Utility;
using System.Management;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Diagnostics.Runtime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nvision
{
    public partial class Form1 : Form
    {
        private Timer timer;
        //This is a note for a timer to update the temperatures every 2 seconds.

        public Form1()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Form1_Shown);
            this.MinimumSize = new Size(1148, 882);
            SetupTimer();
        }

        
        private void SetupTimer()
        {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            try
            {
                GetTemperatures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching temperatures: {ex.Message}\n{ex.StackTrace}");
            }

        }

        private void CheckDriveHealth()
        {
            var computer = new Computer
            {
                IsStorageEnabled = true // Enable storage monitoring
            };

            computer.Open();
            bool healthFound = false;

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Storage)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Level) // Drive health sensor
                        {
                            cmdSMART.Text = $"Drive: {hardware.Name} - Health: {sensor.Value}%";
                            healthFound = true;
                            break; // Stop once we find health data
                        }
                    }
                }
            }

            if (!healthFound)
            {
                cmdSMART.Text = "No drive health data found.";
            }

            computer.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckDriveHealth();


            //This command gets the serial number of the device
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic bios get serialnumber",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = info })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                cmdSERIAL.Text = string.IsNullOrWhiteSpace(result) ? "No output" : result;
                cmdSERIAL.Text = cmdSERIAL.Text.Replace("\r", "").Replace("\n", "");
                cmdSERIAL.Text = cmdSERIAL.Text.Replace("SerialNumber", "Serial Number:");
            }

            //This command gets the maximum memory supported by the system
            ProcessStartInfo infoMEM = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic memphysical get maxcapacityex",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = infoMEM })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                cmdMEM.Text = string.IsNullOrWhiteSpace(result) ? "No output" : result;
                cmdMEM.Text = cmdMEM.Text.Replace("\r", "").Replace("\n", "");
                cmdMEM.Text = cmdMEM.Text.Replace("MaxCapacityEx", string.Empty);
                string input = cmdMEM.Text;
                int number = int.Parse(input);
                int divisor = 1048576;
                int res = number / divisor;
                cmdMEM.Text = "Maximum RAM: " + res.ToString() + "GB";
            }
            //This command gets the current capacity of RAM in the system
            ProcessStartInfo infoMEMCAP = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C wmic memorychip get capacity",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo = infoMEMCAP })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Split lines and sum up valid values
                long totalMemory = 0;
                string[] lines = result.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (long.TryParse(line.Trim(), out long value))
                    {
                        totalMemory += value;
                    }
                }

                cmdMEMCAPACITY.Text = "Memory Capacity: " + (totalMemory / 1073741824).ToString() + " GB";
            }
            //This command gets the current speed of RAM in the system
            ProcessStartInfo infoMEMSPEED = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C wmic memorychip get speed",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo= infoMEMSPEED })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                string stripped = result.Replace(" ", "").Replace("Speed", "").Replace("\n", "").Replace("\r", "");
                string substr = stripped.Substring(0, stripped.Length - 4);
                int memspeed = int.Parse(substr);
                cmdMEMSPEED.Text = "Memory Speed: " + memspeed.ToString() + "MHz";
            }

            //This command gets the number of memory slots present in the system
            ProcessStartInfo infoMEMslots = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/C" + "wmic memphysical get MemoryDevices",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
            using (Process process = new Process { StartInfo = infoMEMslots })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                cmdMEMslots.Text = string.IsNullOrWhiteSpace(result) ? "No output" : result;
                cmdMEMslots.Text = cmdMEMslots.Text.Replace("\r", "").Replace("\n", "");
                cmdMEMslots.Text = "Memory Slots: " + cmdMEMslots.Text.Replace("MemoryDevices", string.Empty);
                
                
            }

            //This command gets the number of available slots in the system
            ProcessStartInfo infoMEMavailable = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic memorychip get devicelocator",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo = infoMEMavailable })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                cmdMEMavailable.Text = string.IsNullOrWhiteSpace(result) ? "No output" : result;
                int count = cmdMEMavailable.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Count(line => line.Trim() == "DIMM 1");
                cmdMEMavailable.Text = "Slots in use: " + count.ToString();

            }

            //This command gets the motherboard make

            string mobo1 = "";
            string mobo2 = "";
            ProcessStartInfo infoMOBOMan = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic baseboard get Manufacturer",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo = infoMOBOMan })
            {
                process.Start();
                string result1 = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                result1 = result1.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("Manufacturer", "");
                mobo1 = result1;

            }
            ProcessStartInfo infoMOBOPro = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic baseboard get Product",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo = infoMOBOPro })
            {
                process.Start();
                string result2 = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                result2 = result2.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("Product", "");
                mobo2 = result2;

            }
            cmdMOBO.Text = mobo1 + "\n" + mobo2;

            //This command gets the bios version
            string biosver = "";
            string biosdate = "";
            ProcessStartInfo infoBIOSVer = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic bios get smbiosbiosversion",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo= infoBIOSVer })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                biosver = result;
            }
            ProcessStartInfo infoBIOSdate = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C" + "wmic bios get releasedate",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process { StartInfo = infoBIOSdate })
            {
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                biosdate = result;
            }
            biosver = biosver.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("SMBIOS", "");
            biosdate = biosdate.Replace(" ", "").Replace("\r", "").Replace("\n", "");
            biosdate = biosdate.Substring(0, biosdate.Length - 17);
            cmdBIOSVER.Text = biosver + "\n" + biosdate;


            //This is run on form load so that CPU temp is immmediately shown.
            GetInitialTemperatures();


            //This is run to get battery health
            GetBatteryHealth();
        }



        private void GetBatteryHealth()
        {
            var computer = new Computer();
            computer.Open();

            bool batteryFound = false;

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Battery)
                {
                    batteryFound = true;
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Level)
                        {
                            cmdBATTERY.Text = $"Battery Wear Level: {sensor.Value}%";
                            return; // Exit once we find battery info
                        }
                    }
                }
            }

            if (!batteryFound)
            {
                cmdBATTERY.Text = "No battery detected";
            }
        }

        private void GetInitialTemperatures()
        {
            var computer = new Computer();
            computer.IsCpuEnabled = true;
            computer.IsGpuEnabled = true;
            computer.Open();
        
            var cpuTemps = new List<float>();
            var gpuTemps = new List<float>();

            var hardwareItems = computer.Hardware.Where(h => h.HardwareType == HardwareType.Cpu || h.HardwareType == HardwareType.GpuNvidia || h.HardwareType == HardwareType.GpuAmd || h.HardwareType == HardwareType.GpuIntel).ToList();

            // Added validation to ensure hardwareItems list is not empty
            if (hardwareItems == null || hardwareItems.Count == 0)
            {
                MessageBox.Show("No hardware items found. Please check your hardware configuration.");
                return;
            }

            foreach (var hardwareItem in hardwareItems)
            {
                hardwareItem.Update();
                foreach (var sensor in hardwareItem.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        float? tempValue = sensor.Value;
                        if (tempValue.HasValue) // Ensure the value is not null
                        {
                            if (hardwareItem.HardwareType == HardwareType.Cpu)
                            {
                                cpuTemps.Add(tempValue.Value);
                            }
                            else if (hardwareItem.HardwareType == HardwareType.GpuNvidia ||
                                     hardwareItem.HardwareType == HardwareType.GpuAmd ||
                                     hardwareItem.HardwareType == HardwareType.GpuIntel)
                            {
                                gpuTemps.Add(tempValue.Value);
                            }
                        }
                    }
                }

            }

            computer.Close();

            if (cpuTemps.Count > 0)
            {
                int cpuTemp = (int)Math.Round(cpuTemps[0]); // Convert float to int
                cpuTEMP.Text = "CPU Temperature: " + cpuTemp + "°C";

                // Change color based on temperature range
                if (cpuTemp < 60)
                    cpuTEMP.ForeColor = Color.Green;
                else if (cpuTemp >= 60 && cpuTemp < 80)
                    cpuTEMP.ForeColor = Color.Orange;
                else
                    cpuTEMP.ForeColor = Color.Red;
            }
            else
            {
                cpuTEMP.Text = "CPU Temperature: Data Unavailable";
                cpuTEMP.ForeColor = Color.Gray;
            }

            if (gpuTemps.Count > 0)
            {
                int gpuTemp = (int)Math.Round(gpuTemps[0]); // Convert float to int
                gpuTEMP.Text = "GPU Temperature: " + gpuTemp + "°C";

                // Change color based on temperature range
                if (gpuTemp < 60)
                    gpuTEMP.ForeColor = Color.Green;
                else if (gpuTemp >= 60 && gpuTemp < 80)
                    gpuTEMP.ForeColor = Color.Orange;
                else
                    gpuTEMP.ForeColor = Color.Red;
            }
            else
            {
                gpuTEMP.Text = "GPU Temperature: Data Unavailable";
                gpuTEMP.ForeColor = Color.Gray;
            }


        }

        private void GetTemperatures()
        {
            var computer = new Computer();
            try
            {
                computer.IsCpuEnabled = true;
                computer.IsGpuEnabled = true;
                computer.Open();
                
                var cpuTemps = new List<float>();
                var gpuTemps = new List<float>();

                var hardwareItems = computer.Hardware
                    .Where(h => h.HardwareType == HardwareType.Cpu ||
                                h.HardwareType == HardwareType.GpuNvidia ||
                                h.HardwareType == HardwareType.GpuAmd ||
                                h.HardwareType == HardwareType.GpuIntel)
                    .ToList();

                // Validation check to ensure hardwareItems is not null or empty
                if (hardwareItems == null || hardwareItems.Count == 0)
                {
                    MessageBox.Show("No hardware items found. Please check your hardware configuration.");
                    return;
                }

                foreach (var hardwareItem in hardwareItems)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            float? tempValue = sensor.Value;
                            if (tempValue.HasValue) // Ensure the value is not null
                            {
                                if (hardwareItem.HardwareType == HardwareType.Cpu)
                                {
                                    cpuTemps.Add(tempValue.Value);
                                }
                                else if (hardwareItem.HardwareType == HardwareType.GpuNvidia ||
                                         hardwareItem.HardwareType == HardwareType.GpuAmd ||
                                         hardwareItem.HardwareType == HardwareType.GpuIntel)
                                {
                                    gpuTemps.Add(tempValue.Value);
                                }
                            }
                        }
                    }

                }

                if (cpuTemps.Count > 0)
                {
                    int cpuTemp = (int)Math.Round(cpuTemps[0]); // Convert float to int
                    cpuTEMP.Text = "CPU Temperature: " + cpuTemp + "°C";

                    // Change color based on temperature range
                    if (cpuTemp < 60)
                        cpuTEMP.ForeColor = Color.Green;
                    else if (cpuTemp >= 60 && cpuTemp < 80)
                        cpuTEMP.ForeColor = Color.Orange;
                    else
                        cpuTEMP.ForeColor = Color.Red;
                }
                else
                {
                    cpuTEMP.Text = "CPU Temperature: Data Unavailable";
                    cpuTEMP.ForeColor = Color.Gray;
                }

                if (gpuTemps.Count > 0)
                {
                    int gpuTemp = (int)Math.Round(gpuTemps[0]); // Convert float to int
                    gpuTEMP.Text = "GPU Temperature: " + gpuTemp + "°C";

                    // Change color based on temperature range
                    if (gpuTemp < 60)
                        gpuTEMP.ForeColor = Color.Green;
                    else if (gpuTemp >= 60 && gpuTemp < 80)
                        gpuTEMP.ForeColor = Color.Orange;
                    else
                        gpuTEMP.ForeColor = Color.Red;
                }
                else
                {
                    gpuTEMP.Text = "GPU Temperature: Data Unavailable";
                    gpuTEMP.ForeColor = Color.Gray;
                }


            }
            catch (Exception ex)
            {
                // Handle unexpected exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Ensure the computer is closed even if an exception occurs
                computer.Close();
            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            //
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //This script makes sure all labels are centered
            //cmdSERIAL.Left = (this.ClientSize.Width - cmdSERIAL.Width) / 2;
            //cmdMEM.Left = (this.ClientSize.Width - cmdMEM.Width) / 2;
            //cmdMEMslots.Left = (this.ClientSize.Width - cmdMEMslots.Width) / 2;
            //cmdMEMavailable.Left = (this.ClientSize.Width - cmdMEMavailable.Width) / 2;
            //cmdBATTERY.Left = (this.ClientSize.Width - cmdBATTERY.Width) / 2;
            //cmdBIOSVER.Left = (this.ClientSize.Width - cmdBIOSVER.Width) / 2;
            //cmdMOBO.Left = (this.ClientSize.Width - cmdMOBO.Width) / 2;
            //cmdSMART.Left = (this.ClientSize.Width - cmdSMART.Width) / 2;
            //cmdMEMCAPACITY.Left = (this.ClientSize.Width - cmdMEMCAPACITY.Width) / 2;
            //cmdMEMSPEED.Left = (this.ClientSize.Width - cmdMEMSPEED.Width) / 2;
            //cpuTEMP.Left = (this.ClientSize.Width - cpuTEMP.Width) / 2;
            //gpuTEMP.Left = (this.ClientSize.Width - gpuTEMP.Width) / 2;

        }
        private void runSFC_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = @"C:\Windows\Sysnative\cmd.exe", // Use Sysnative to access 64-bit cmd.exe
                Arguments = "/C sfc /scannow", // Run sfc /scannow
                UseShellExecute = true,
                Verb = "runas",
                CreateNoWindow = false,
            };

            // Start the process
            using (Process process = Process.Start(info))
            {
                process.WaitForExit();
            }
        }

        private void runDISM_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = @"C:\Windows\Sysnative\cmd.exe", // Use Sysnative to access 64-bit cmd.exe
                Arguments = "/C dism /online /cleanup-image /restorehealth", // Run sfc /scannow
                UseShellExecute = true,
                Verb = "runas",
                CreateNoWindow = false,
            };

            // Start the process
            using (Process process = Process.Start(info))
            {
                process.WaitForExit();
            }
        }

        private void runPING_Click(object sender, EventArgs e)
        {
            string batchFilePath = System.IO.Path.Combine(Application.StartupPath, "pingtest.bat");

            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = @"C:\Windows\Sysnative\cmd.exe", // Use Sysnative for 64-bit cmd
                Arguments = "/c \"for /l %x in () do (ping -n 1 www.google.com || (echo Ping failed! & pause & exit)) & timeout /t 1 >nul\"",
                UseShellExecute = true,
                Verb = "runas",
                CreateNoWindow = false,
            };

            // Start the process
            Process.Start(info);
        }

        private void sourceCODE_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/salochin7/Nvision/tree/master",
                UseShellExecute = true
            });
        }

        
    }
}
