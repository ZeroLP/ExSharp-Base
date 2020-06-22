using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSharpBase.Modules;
using ExSharpBase.Game.Objects;
using SharpDX;

namespace ExSharpBase.Events
{
    class Drawing
    {
        public static void OnDeviceDraw()
        {
            //Maybe add ImGui.NET?

            if (Utils.IsGameOnDisplay())
            {
                LocalPlayer.DrawAttackRange(Color.Cyan, 2.5f);

                //Kinda laggy, TODO: Check and draw only when each of spell radius doesn't equal to each other.
                LocalPlayer.DrawSpellRange(ExSharpBase.Game.Spells.SpellBook.SpellSlot.Q, Color.OrangeRed, 2.5f);
                LocalPlayer.DrawSpellRange(ExSharpBase.Game.Spells.SpellBook.SpellSlot.W, Color.OrangeRed, 2.5f);
                LocalPlayer.DrawSpellRange(ExSharpBase.Game.Spells.SpellBook.SpellSlot.E, Color.OrangeRed, 2.5f);
                LocalPlayer.DrawSpellRange(ExSharpBase.Game.Spells.SpellBook.SpellSlot.R, Color.OrangeRed, 2.5f);
            }
        }
    }
}
