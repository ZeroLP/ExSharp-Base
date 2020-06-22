using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ExSharpBase.Modules;
using ExSharpBase.Enums;
using ExSharpBase.Devices;

namespace ExSharpBase.Game
{
    class Engine
    {
        public static int GetLocalPlayer { get; } = Memory.Read<int>(OffsetManager.Instances.LocalPlayer);

        public static float GetGameTime()
        {
            return API.GameStats.GetGameTime();
        }

        public static void IssueOrder(GameObjectOrder Order, Point Vector2D = new Point())
        {
            if (Utils.IsGameOnDisplay())
            {
                switch (Order)
                {
                    case GameObjectOrder.HoldPosition:
                        Keyboard.SendKey((short)Keyboard.KeyBoardScanCodes.KEY_S);
                        break;
                    case GameObjectOrder.MoveTo:
                        if (Vector2D.X == 0 && Vector2D.Y == 0)
                        {
                            Mouse.MouseClickRight();
                            break;
                        }
                        if (Vector2D == new Point(Cursor.Position.X, Cursor.Position.Y))
                        {
                            Mouse.MouseClickRight();
                            break;
                        }
                        Mouse.MouseMove(Vector2D.X, Vector2D.Y);
                        Mouse.MouseClickRight();
                        break;
                    case GameObjectOrder.AttackUnit:
                        if (Vector2D.X == 0 && Vector2D.Y == 0)
                        {
                            Mouse.MouseMove(Cursor.Position.X, Cursor.Position.Y);
                            Mouse.MouseClickRight();
                            break;
                        }
                        Mouse.MouseMove(Vector2D.X, Vector2D.Y);
                        Mouse.MouseClickRight();
                        break;
                    case GameObjectOrder.AutoAttack:
                        Keyboard.SendKey((short)Keyboard.KeyBoardScanCodes.KEY_OPENING_BRACKETS);
                        break;
                    case GameObjectOrder.Stop:
                        Keyboard.SendKey((short)Keyboard.KeyBoardScanCodes.KEY_S);
                        break;
                }
            }
        }
    }
}
