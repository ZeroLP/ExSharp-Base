using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSharpBase.Modules;

namespace ExSharpBase.Game
{
    class OffsetManager
    {
        public static int BaseAddress = Utils.GetLeagueProcess().MainModule.BaseAddress.ToInt32();

        public class Instances
        {
            //Version 10.12.324.5925 [PUBLIC]
            public static int LocalPlayer = BaseAddress + 0x34F489C; //blueHero -> Above "hero" function //10.5
            public static int Renderer = BaseAddress + 0x351507C; //8B 15 ? ? ? ? 83 EC 08 F3 //["blurKernelSigma", +0x27F] // xref the string, move -0x27f there should be a dword.
            public static int ViewMatrix = BaseAddress + 0x35109F8; //B9 ? ? ? ? E8 ? ? ? ? B9 ? ? ? ? E9 ? ? ? ?  //unk_0x....

            public static int SpellBook = 0x2AD8;

            public static int UnderMouseObject = 0x289E898; //8B 0D ? ? ? ? 89 0D //Detected?
        }

        public class Object
        {
            public static int ChampionName = 0x3594;
            public static int Pos = 0x1D8;
            public static int Name = 0x6C;
            public static int Visibility = 0x39C;
            public static int AttackRange = 0x1484;
        }
    }
}
