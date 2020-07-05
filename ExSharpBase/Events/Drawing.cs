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
        public static Dictionary<string, bool> DrawingProperties = new Dictionary<string, bool>()
        {
            { "DrawRange", true }
        };

        public static bool IsMenuBeingDrawn = false;

        public static void OnDeviceDraw()
        {
            if (Utils.IsGameOnDisplay())
            {
                //When ~ key is pressed...
                DrawMenu();

                if (DrawingProperties["DrawRange"] == true)
                {
                    LocalPlayer.DrawAttackRange(Color.Cyan, 2.5f);

                    LocalPlayer.DrawAllSpellRange(Color.OrangeRed);
                }
            }
        }

        private static void DrawMenu()
        {
            if (Utils.IsKeyPressed(System.Windows.Forms.Keys.Oemtilde))
            {
                Program.MenuBasePlate.Show();
                IsMenuBeingDrawn = true;
            }
            else
            {
                Program.MenuBasePlate.Hide();
            }
        }
    }
}
