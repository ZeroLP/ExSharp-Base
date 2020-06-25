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

                LocalPlayer.DrawAllSpellRange(Color.OrangeRed);
            }
        }
    }
}
