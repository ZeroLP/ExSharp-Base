using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ExSharpBase.API
{
    public class AllPlayerData
    {
        public class FirstPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[0]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[0]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[0]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[0]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[0]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[0]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[0]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[0]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[0]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[0]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[0]["items"].ToObject<Items>();
            }
        }

        public class SecondPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[1]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[1]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[1]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[1]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[1]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[1]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[1]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[1]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[1]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[1]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[1]["items"].ToObject<Items>();
            }
        }

        public class ThirdPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[2]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[2]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[2]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[2]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[2]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[2]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[2]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[2]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[2]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[2]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[2]["items"].ToObject<Items>();
            }
        }

        public class ForthPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[3]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[3]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[3]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[3]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[3]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[3]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[2]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[3]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[3]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[3]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[3]["items"].ToObject<Items>();
            }
        }

        public class FifthPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[4]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[4]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[4]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[4]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[4]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[4]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[4]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[4]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[4]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[4]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[4]["items"].ToObject<Items>();
            }
        }

        public class SixthPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[5]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[5]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[5]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[5]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[5]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[5]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[5]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[5]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[5]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[5]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[5]["items"].ToObject<Items>();
            }
        }

        public class SeventhPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[6]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[6]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[6]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[6]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[6]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[6]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[6]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[6]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[6]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[6]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[6]["items"].ToObject<Items>();
            }
        }

        public class EighthPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[7]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[7]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[7]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[7]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[7]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[7]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[7]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[7]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[7]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[7]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[7]["items"].ToObject<Items>();
            }
        }

        public class NinethPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[8]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[8]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[8]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[8]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[8]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[8]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[8]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[8]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[8]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[8]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[8]["items"].ToObject<Items>();
            }
        }

        public class TenthPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[9]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[9]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[9]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[9]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[9]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[9]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[9]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[9]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[9]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[9]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[9]["items"].ToObject<Items>();
            }
        }

        public class EleventhPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[10]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[10]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[10]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[10]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[10]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[10]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[10]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[10]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[10]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[10]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[10]["items"].ToObject<Items>();
            }
        }

        public class TwelvethPlayer
        {
            public static string ChampionName { get; } = Service.GetAllPlayerData()[11]["championName"].ToString();
            public static bool IsBot { get; } = Service.GetAllPlayerData()[11]["isBot"].ToObject<bool>();
            public static bool IsDead { get; } = Service.GetAllPlayerData()[11]["isDead"].ToObject<bool>();
            public static int Level { get; } = Service.GetAllPlayerData()[11]["level"].ToObject<int>();
            public static string RolePosition { get; } = Service.GetAllPlayerData()[11]["position"].ToString();
            public static string RawChampionName { get; } = Service.GetAllPlayerData()[11]["rawChampionName"].ToString();
            public static float RespawnTimer { get; } = Service.GetAllPlayerData()[11]["respawnTimer"].ToObject<float>();
            public static int SkinID { get; } = Service.GetAllPlayerData()[11]["skinID"].ToObject<int>();
            public static string SummonerName { get; } = Service.GetAllPlayerData()[11]["summonerName"].ToString();
            public static string Team { get; } = Service.GetAllPlayerData()[11]["team"].ToString();

            public static Items GetItems()
            {
                return Service.GetAllPlayerData()[11]["items"].ToObject<Items>();
            }
        }

        public class Items
        {

        }
    }
}
