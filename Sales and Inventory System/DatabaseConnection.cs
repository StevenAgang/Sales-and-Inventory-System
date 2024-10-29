using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Management.Instrumentation;

namespace Sales_and_Inventory_System
{
    public class DatabaseConnection
    {
    }

    // Pinging CloudFlare DNS
    public class Internet
    {
        public static bool CheckInternet()
        {
            string host = "1.1.1.1";
            Ping pinger = null;
            byte[] buffer = new byte[32];
            PingOptions option = new PingOptions();

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(host, 3000, buffer, option);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine(reply.Status.ToString());
                    return true;
                }
                else
                {
                    Console.WriteLine(reply.Status.ToString());
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
        }
    }
}
