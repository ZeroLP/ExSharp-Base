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

        public static void DrawAttackRange(Color Colour, float Thickness)
        {
            if (IsVisible())
            {
                Overlay.Drawing.DrawFactory.DrawCircleRange(GetPosition(), GetBoundingRadius() + GetAttackRange(), Colour, Thickness);
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

        public static int GetBoundingRadius()
        {
            return int.Parse(UnitRadiusData[GetChampionName()]["Gameplay radius"].ToString());
        }

        public static float GetAttackRange()
        {
            return Memory.Read<float>(Engine.GetLocalPlayer + OffsetManager.Object.AttackRange);
        }
    }
}
