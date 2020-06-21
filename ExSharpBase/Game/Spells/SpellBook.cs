using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExSharpBase.Modules;
using ExSharpBase.Devices;

namespace ExSharpBase.Game.Spells
{
    class SpellBook
    {
        public static int GetSpellBookInstance { get; } = Engine.GetLocalPlayer + OffsetManager.Instances.SpellBook;

        public static int SpellArray
        {
            get
            {
                return 0x508;
            }
        }

        public static SpellClass GetSpellClassByID(SpellSlotID ID)
        {
            SpellClass SClass = new SpellClass();
            SClass.CurrentSpell = Memory.Read<int>(GetSpellBookInstance + SpellArray + (0x4 * (int)ID));
            return SClass;
        }

        public static int GetActiveSpell()
        {
            return Memory.Read<int>(GetSpellBookInstance + 0x24);
        }

        public static void CastSpell(SpellSlot Slot)
        {
            if (Utils.IsGameOnDisplay()) Keyboard.SendKey((short)Slot);
        }

        public static void CastSpell(SpellSlot Slot, int X, int Y)
        {
            if (Utils.IsGameOnDisplay())
            {
                Mouse.MouseMove(X, Y);
                Keyboard.SendKey((short)Slot);
            }
        }

        public static void CastSpell(SpellSlot Slot, Point SpellLocation)
        {
            if (Utils.IsGameOnDisplay())
            {
                Mouse.MouseMove((int)SpellLocation.X, (int)SpellLocation.Y);
                Keyboard.SendKey((short)Slot);
            }
        }

        public static void CastMultiSpells(SpellSlot[] SlotArray)
        {
            foreach (SpellSlot Spell in SlotArray)
            {
                CastSpell(Spell);
            }
        }

        public static void CastMultiSpells(SpellSlot[] SlotArray, int X, int Y)
        {
            foreach (SpellSlot Spell in SlotArray)
            {
                CastSpell(Spell, X, Y);
            }
        }

        public static void CastMultiSpells(SpellSlot[] SlotArray, Point SpellLocation)
        {
            foreach (SpellSlot Spell in SlotArray)
            {
                CastSpell(Spell, SpellLocation);
            }
        }

        public static void CastSummonerSpell(SummonerSpellSlot Slot)
        {
            if (Utils.IsGameOnDisplay()) Keyboard.SendKey((short)Slot);
        }

        public static void CastSummonerSpell(SummonerSpellSlot Slot, int X, int Y)
        {
            if (Utils.IsGameOnDisplay())
            {
                Mouse.MouseMove(X, Y);
                Keyboard.SendKey((short)Slot);
            }
        }

        public static void CastSummonerSpell(SummonerSpellSlot Slot, Point SpellLocation)
        {
            if (Utils.IsGameOnDisplay())
            {
                Mouse.MouseMove((int)SpellLocation.X, (int)SpellLocation.Y);
                Keyboard.SendKey((short)Slot);
            }
        }

        public enum SpellSlot
        {
            Q = Keyboard.KeyBoardScanCodes.KEY_Q,
            W = Keyboard.KeyBoardScanCodes.KEY_W,
            E = Keyboard.KeyBoardScanCodes.KEY_E,
            R = Keyboard.KeyBoardScanCodes.KEY_R
        }

        public enum SpellSlotID
        {
            Q = 0,
            W = 1,
            E = 2,
            R = 3,
            Summoner1 = 4,
            Summoner2 = 5,
            Item1 = 6,
            Item2 = 7,
            Item3 = 8,
            Item4 = 9,
            Item5 = 10,
            Item6 = 11,
            Trinket = 12,
            Recall = 13
        }

        public enum SummonerSpellSlot
        {
            Summoner1 = Keyboard.KeyBoardScanCodes.KEY_D,
            Summoner2 = Keyboard.KeyBoardScanCodes.KEY_F,
            Recall = Keyboard.VirtualKeyCodes.KEY_B
        }
    }
}
