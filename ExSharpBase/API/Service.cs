using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;
using ExSharpBase.Modules;
using ExSharpBase.Enums;

namespace ExSharpBase.API
{
    class Service
    {
        public static JObject GetActivePlayerData()
        {
            if (IsLiveGameRunning())
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/activeplayer");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    try { return JObject.Parse(reader.ReadToEnd()); }
                    catch (Exception Ex)
                    {
                        LogService.Log("PlayerDataParseFailedException", LogLevel.Error);
                        throw new Exception("PlayerDataParseFailedException");
                    }
                }
            }
            else
            {
                LogService.Log("PlayerDataParseFailedException", LogLevel.Error);
                throw new Exception("PlayerDataParseFailedException");
            }
        }

        public static JArray GetAllPlayerData()
        {
            if (IsLiveGameRunning())
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/playerlist");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    try { return JArray.Parse(reader.ReadToEnd()); }
                    catch (Exception Ex)
                    {
                        LogService.Log("AllPlayerDataParseFailedException", LogLevel.Error);
                        throw new Exception("AllPlayerDataParseFailedException");
                    }
                }
            }
            else
            {
                LogService.Log("AllPlayerDataParseFailedException", LogLevel.Error);
                throw new Exception("AllPlayerDataParseFailedException");
            }
        }

        public static JObject GetGameStatsData()
        {
            if (IsLiveGameRunning())
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/gamestats");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    try { return JObject.Parse(reader.ReadToEnd()); }
                    catch (Exception Ex)
                    {
                        Console.WriteLine("GameDataParseFailedException");
                        throw new Exception("GameDataParseFailedException");
                    }
                }
            }
            else
            {
                Console.WriteLine("GameDataParseFailedException");
                throw new Exception("GameDataParseFailedException");
            }
        }

        public static bool IsLiveGameRunning()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/allgamedata");
            System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true; // **** Always accept
            };

            request.Method = "GET";

            bool flag = false;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK) flag = true;
                }
            }
            catch (Exception Ex)
            {
                LogService.Log($"Failed To Connect To A Running Game Instance. Exiting In 10 Seconds...", LogLevel.Error);
                Thread.Sleep(10000);
                Environment.Exit(0);
            }

            return flag;
        }
    }
}
