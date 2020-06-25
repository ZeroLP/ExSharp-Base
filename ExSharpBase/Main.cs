using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSharpBase.Modules;
using ExSharpBase.Game;
using ExSharpBase.Game.Objects;
using ExSharpBase.Game.Spells;
using System.Windows.Forms;
using System.Drawing;

namespace ExSharpBase
{
    class Main
    {
        public static void OnMain()
        {
            if (Utils.IsKeyPressed(Keys.Space) && Utils.IsGameOnDisplay())
            {
                OrbService.Orbwalker.Orbwalk();

                /*Point EnemyPosition = ObjectManager.GetEnemyPosition();

                if (EnemyPosition != Point.Empty)
                {
                    SpellBook.CastSpell(SpellBook.SpellSlot.Q, EnemyPosition);

                    SpellBook.SpellSlot[] SpellArray = new SpellBook.SpellSlot[]
                    {
                        SpellBook.SpellSlot.Q,
                        SpellBook.SpellSlot.W,
                        SpellBook.SpellSlot.E
                    };

                    SpellBook.CastMultiSpells(SpellArray, EnemyPosition);
                }
                else
                {
                    Engine.IssueOrder(Enums.GameObjectOrder.MoveTo, Cursor.Position);
                }*/
            }
        }
    }
}
