using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSharpBase.Modules;
using SharpDX;
using Newtonsoft.Json.Linq;

namespace ExSharpBase.Game.Objects
{
    class LocalPlayer
    {
        public static JObject UnitRadiusData;

        public static string GetSummonerName()
        {
            return API.ActivePlayerData.GetSummonerName();
        }

        public static int GetLevel()
        {
            return API.ActivePlayerData.GetLevel();
        }

        public static float GetCurrentGold()
        {
            return API.ActivePlayerData.GetCurrentGold();
        }

        public static void DrawAttackRange(Color Colour, float Thickness)
        {
            if (IsVisible() && GetCurrentHealth() > 1.0f)
            {
                Overlay.Drawing.DrawFactory.DrawCircleRange(GetPosition(), GetBoundingRadius() + GetAttackRange(), Colour, Thickness);
            }
        }

        public static void DrawSpellRange(Spells.SpellBook.SpellSlot Slot, Color Colour, float Thickness)
        {
            if (IsVisible() && GetCurrentHealth() > 1.0f)
            {
                Overlay.Drawing.DrawFactory.DrawCircleRange(GetPosition(), Spells.SpellBook.GetSpellRadius(Slot), Colour, Thickness);
            }
        }

        private static List<string> RangeSlotList = new List<string>() { "Q", "W", "E", "R" };
        private static List<float> UsedRangeSlotsList = new List<float>();
        public static void DrawAllSpellRange(Color RGB)
        {
            foreach (string RangeSlot in RangeSlotList)
            {
                float SpellRange = Spells.SpellBook.SpellDB[RangeSlot].ToObject<JObject>()["Range"][0].ToObject<float>();

                if(UsedRangeSlotsList.Count != 0)
                {
                    if (!UsedRangeSlotsList.Contains(SpellRange))
                    {
                        UsedRangeSlotsList.Add(SpellRange);
                    }
                }
                else
                {
                    UsedRangeSlotsList.Add(SpellRange);
                }
            }

            foreach(float Range in UsedRangeSlotsList)
            {
                Overlay.Drawing.DrawFactory.DrawCircleRange(GetPosition(), Range, RGB, 2.5f);
            }
        }

        public static bool IsVisible()
        {
            return Memory.Read<bool>(Engine.GetLocalPlayer + OffsetManager.Object.Visibility);
        }

        public static Vector3 GetPosition()
        {
            float posX = Memory.Read<float>(Engine.GetLocalPlayer + OffsetManager.Object.Pos);
            float posY = Memory.Read<float>(Engine.GetLocalPlayer + OffsetManager.Object.Pos + 0x4);
            float posZ = Memory.Read<float>(Engine.GetLocalPlayer + OffsetManager.Object.Pos + 0x8);

            return new Vector3() { X = posX, Y = posY, Z = posZ };
        }

        public static string GetChampionName()
        {
            return Memory.ReadString(Engine.GetLocalPlayer + OffsetManager.Object.ChampionName, Encoding.ASCII);
        }

        public static float GetAttackRange()
        {
            return Memory.Read<float>(Engine.GetLocalPlayer + OffsetManager.Object.AttackRange);
        }

        public static int GetBoundingRadius()
        {
            return int.Parse(UnitRadiusData[GetChampionName()]["Gameplay radius"].ToString());
        }

        public static float GetCurrentHealth()
        {
            return API.ActivePlayerData.ChampionStats.GetCurrentHealth();
        }

        public static float GetMaxHealth()
        {
            return API.ActivePlayerData.ChampionStats.GetMaxHealth();
        }

        public static float GetHealthRegenRate()
        {
            return API.ActivePlayerData.ChampionStats.GetHealthRegenRate();
        }

        public string GetResourceType()
        {
            return API.ActivePlayerData.ChampionStats.GetResourceType();
        }

        public static float GetCurrentMana()
        {
            return API.ActivePlayerData.ChampionStats.GetResourceValue();
        }

        public static float GetCurrentManaMax()
        {
            return API.ActivePlayerData.ChampionStats.GetResourceMax();
        }

        public static float GetAbilityPower()
        {
            return API.ActivePlayerData.ChampionStats.GetAbilityPower();
        }

        public static float GetArmor()
        {
            return API.ActivePlayerData.ChampionStats.GetArmor();
        }

        public static float GetArmorPenetrationFlat()
        {
            return API.ActivePlayerData.ChampionStats.GetArmorPenetrationFlat();
        }

        public static float GetArmorPenetrationPercent()
        {
            return API.ActivePlayerData.ChampionStats.GetArmorPenetrationPercent();
        }

        public static float GetAttackSpeed()
        {
            return API.ActivePlayerData.ChampionStats.GetAttackSpeed();
        }

        public static float GetBonusArmorPenetrationPercent()
        {
            return API.ActivePlayerData.ChampionStats.GetBonusArmorPenetrationPercent();
        }

        public static float GetBonusMagicPenetrationPercent()
        {
            return API.ActivePlayerData.ChampionStats.GetBonusMagicPenetrationPercent();
        }

        public static float GetCooldownReduction()
        {
            return API.ActivePlayerData.ChampionStats.GetCooldownReduction();
        }

        public static float GetCritChance()
        {
            return API.ActivePlayerData.ChampionStats.GetCritChance();
        }

        public static float GetCritDamage()
        {
            return API.ActivePlayerData.ChampionStats.GetCritDamage();
        }

        public static float GetLifeSteal()
        {
            return API.ActivePlayerData.ChampionStats.GetLifeSteal();
        }

        public static float GetMagicLethality()
        {
            return API.ActivePlayerData.ChampionStats.GetMagicLethality();
        }

        public static float GetMagicPenetrationFlat()
        {
            return API.ActivePlayerData.ChampionStats.GetMagicPenetrationFlat();
        }

        public static float GetMagicPenetrationPercent()
        {
            return API.ActivePlayerData.ChampionStats.GetMagicPenetrationPercent();
        }

        public static float GetMagicResist()
        {
            return API.ActivePlayerData.ChampionStats.GetMagicResist();
        }

        public static float GetMoveSpeed()
        {
            return API.ActivePlayerData.ChampionStats.GetMoveSpeed();
        }

        public static float GetPhysicalLethality()
        {
            return API.ActivePlayerData.ChampionStats.GetPhysicalLethality();
        }

        public static float GetSpellVamp()
        {
            return API.ActivePlayerData.ChampionStats.GetSpellVamp();
        }

        public static float GetTenacity()
        {
            return API.ActivePlayerData.ChampionStats.GetTenacity();
        }
    }
}
