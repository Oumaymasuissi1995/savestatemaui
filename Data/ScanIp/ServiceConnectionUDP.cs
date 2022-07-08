using SAFE_S68_S360_RemoteComm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.ScanIp
{
    public class ServiceConnectionUDP
    {
        public Communication ServiceCommunication;

        public ServiceConnectionUDP()
        {
            ServiceCommunication = new Communication();
        }

        public void OpenConnectionToRemote(IPAddress remoteIP, string remotePort)
        {
            if (ServiceCommunication == null || ServiceCommunication.ChannelStatus == ChannelStatus.Closed)
            {
                UdpChannelParameter udpChPar;
                udpChPar.TimeOut = 20;
                udpChPar.Host = remoteIP.ToString();
                udpChPar.Port = remotePort;
                ServiceCommunication.Open(udpChPar);
                //ServiceCommunication.scanSystemRx += new Communication.ScanSystemRxHandler(connectionChannelStatusHandler);
            }
        }

        void connectionChannelStatusHandler(object communication, ScanSystemRxEventArgs channelStatus)
        {
            try
            {
                string ip = channelStatus._ip_Source.ToString();
                //dtImpianto.LoadDataRow(new object[] { 0, b }, true);
                ServiceCommunication.scanSystemRx -= new Communication.ScanSystemRxHandler(connectionChannelStatusHandler);
                ServiceCommunication.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                ServiceCommunication = null;
            }
        }

        public void CloseConnectionToRemote()
        {
            try
            {
                if (ServiceCommunication != null)
                {
                    //ServiceCommunication.scanSystemRx -= new Communication.ScanSystemRxHandler(connectionChannelStatusHandler);
                    ServiceCommunication.Close();
                    ServiceCommunication = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// @todo Bisogna introidurre un dispose????
    }
}
