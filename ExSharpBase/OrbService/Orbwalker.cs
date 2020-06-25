using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSharpBase.Game;
using ExSharpBase.Game.Objects;
using ExSharpBase.Enums;
using ExSharpBase.Devices;
using System.Drawing;
using System.Windows.Forms;


namespace ExSharpBase.OrbService
{
    class Orbwalker
    {
        private static bool IsOrbAttackable = true;

        private static int LastAATick = 0;
        private static Point LastMovePoint;

        public static void Orbwalk()
        {
            Point EnemyPosition = ObjectManager.GetEnemyPosition();
            int AttackDelay = (int)(1000.0f / LocalPlayer.GetAttackSpeed());

            if (IsOrbAttackable && EnemyPosition != Point.Empty)
            {
                LastMovePoint = Cursor.Position;

                Engine.IssueOrder(GameObjectOrder.AttackUnit, EnemyPosition);
                Engine.IssueOrder(GameObjectOrder.AttackUnit, EnemyPosition);

                Engine.IssueOrder(GameObjectOrder.MoveTo, LastMovePoint);

                LastAATick = (int)((Engine.GetGameTime() * 1000) +  AttackDelay);

                IsOrbAttackable = false;
            }
            else
            {
                if ((Engine.GetGameTime() * 1000) >= LastAATick)
                {
                    Mouse.MouseClickRight();

                    IsOrbAttackable = true;
                }
                else
                {
                    LastMovePoint = Cursor.Position;
                    Engine.IssueOrder(GameObjectOrder.MoveTo, LastMovePoint);
                    LastMovePoint = Cursor.Position;
                }
            }
        }
    }
}
