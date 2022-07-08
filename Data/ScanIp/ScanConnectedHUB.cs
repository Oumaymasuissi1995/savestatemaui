using SAFE_S68_S360_RemoteComm;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Data.ScanIp
{
    public static class ScanConnectedHUB
    {
        private static Thread ThreadScanSystem;
        private static ServiceConnectionUDP service;
        private static string hostname = string.Empty;
        private static string udpPort = "9898";
        public static List<MacIpPair> allMacAddressesAndIppairs = new List<MacIpPair>();
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);
        public struct MacIpPair
        {
            public string MacAddress;
            public string IpAddress;
        }
        public static void ScanSystem()
        {

            string requestScan;
            byte[] requestPayload;

            allMacAddressesAndIppairs = GetAllMacAddressesAndIppairs();
            // prepare request scan-------------------------------------------------------------------------------------------
            hostname = "HL32";
            requestScan = string.Format("whois {0}?", hostname);
            requestPayload = Encoding.ASCII.GetBytes(requestScan);


            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties properties = netif.GetIPProperties();
                foreach (UnicastIPAddressInformation unicast in properties.UnicastAddresses)
                {
                    try
                    {
                        if (unicast.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            service = new ServiceConnectionUDP();
                            //MessageBox.Show("GetBroadcastAddress("+ unicast.Address + ") == "+GetBroadcastAddress(unicast));
                            service.OpenConnectionToRemote(GetBroadcastAddress(unicast), udpPort);
                            service.ServiceCommunication.scanSystemRx -= new Communication.ScanSystemRxHandler(ScanSystemResponseEventHandler);
                            service.ServiceCommunication.scanSystemRx += new Communication.ScanSystemRxHandler(ScanSystemResponseEventHandler);
                            // send Request --------------------------------------------------------------------------------------------------
                            service.ServiceCommunication.ScanSystem(requestPayload);
                            Thread.Sleep(1000);
                        }
                    }
                    catch (Exception e)
                    {
                        // MessageBox.Show("Scan System : " + e.Message);
                    }
                }
            }

        }

        public static List<IpSecurHUB> ipSecurHUBs = new List<IpSecurHUB>();

        private static void ScanSystemResponseEventHandler(object communication, ScanSystemRxEventArgs scanSystemRxEventArgs)
        {
            /*if (this.InvokeRequired)
            {
                this.Invoke(new ScanSystemResponseEventHandler_DELEGATE(ScanSystemResponseEventHandler),
                                                            new object[] { communication, scanSystemRxEventArgs });
                return;
            }
            */
            try
            {
                string ip_ResponseSource = scanSystemRxEventArgs._ip_Source.ToString();

                if (ipSecurHUBs.Count > 0)
                {
                    foreach (IpSecurHUB IPAddress in ipSecurHUBs)
                    {
                        if (IPAddress.IPAddress == ip_ResponseSource)
                        {
                            return;
                        }
                    }
                    AddItemsToTable(scanSystemRxEventArgs._ip_Source);
                }
                else
                {
                    AddItemsToTable(scanSystemRxEventArgs._ip_Source);
                }
                //this.Refresh();
            }
            catch (Exception)
            {
                // MessageBox.Show(CommonResource.SCAN_SYSTEM_Failed, Globals.SW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                StopScanSystem();
            }
        }
        private static void AddItemsToTable(IPAddress ipAddress)
        {

            ipSecurHUBs.Add(new IpSecurHUB() { ID = ipSecurHUBs.Count + 1, HostName = hostname, IPAddress = ipAddress.ToString(), MacAddress = GetMacAddress(ipAddress) });

        }
        private static string GetMacAddress(IPAddress ipAddress)
        {
            byte[] macBytes = new byte[6];
            int macLength = macBytes.Length;

            int r = SendARP((int)ipAddress.Address, 0, macBytes, ref macLength);
            if (macLength > 0)
            {
                return BitConverter.ToString(macBytes, 0, 6).Replace('-', ':');
            }

            return string.Empty;
        }
        private static void StopScanSystem()
        {
            try
            {
                //TmrStop();
                if (service.ServiceCommunication != null)
                {
                    service.ServiceCommunication.scanSystemRx -= new Communication.ScanSystemRxHandler(ScanSystemResponseEventHandler);
                    service.CloseConnectionToRemote();
                }
                //EnableButton(true);
            }
            catch
            { }
        }

        private static List<MacIpPair> GetAllMacAddressesAndIppairs()
        {
            List<MacIpPair> mip = new List<MacIpPair>();
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a ";
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string cmdOutput = pProcess.StandardOutput.ReadToEnd();
            string pattern = @"(?<ip>([0-9]{1,3}\.?){4})\s*(?<mac>([a-f0-9]{2}-?){6})";

            foreach (Match m in Regex.Matches(cmdOutput, pattern, RegexOptions.IgnoreCase))
            {
                mip.Add(new MacIpPair()
                {
                    MacAddress = m.Groups["mac"].Value,
                    IpAddress = m.Groups["ip"].Value
                });
            }

            return mip;
        }
        private static IPAddress GetBroadcastAddress(UnicastIPAddressInformation unicastAddress)
        {
            return GetBroadcastAddress(unicastAddress.Address, unicastAddress.IPv4Mask);
        }

        private static IPAddress GetBroadcastAddress(IPAddress address, IPAddress mask)
        {
            uint ipAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
            uint ipMaskV4 = BitConverter.ToUInt32(mask.GetAddressBytes(), 0);
            uint broadCastIpAddress = ipAddress | ~ipMaskV4;

            return new IPAddress(BitConverter.GetBytes(broadCastIpAddress));
        }
    }
}