using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExSharpBase.Modules;

namespace ExSharpBase.Game.Objects
{
    class ObjectManager
    {
        private static Color RGB_PLAYER_HP_BAR_COLOUR = Color.FromArgb(49, 134, 33);

        private static Color RGB_CHAMPION_NAME_COLOR = Color.FromArgb(0xE3, 0xE3, 0xE3);
        private static Color RGB_LOSED_HP_BAR_COLOR = Color.FromArgb(0x0A, 0x0E, 0x11);
        private static Color RGB_MANA_BAR_COLOR = Color.FromArgb(0x42, 0xAA, 0xDE);

        private static Color RGB_ALLY_HP_BAR_COLOR = Color.FromArgb(0x31, 0x8A, 0x21);
        private static Color RGB_ALLY_LEVEL_COLOR = Color.FromArgb(0x00, 0x1C, 0x2C);
        private static Color RGB_ALLY_MINION_HP_BAR_COLOR = Color.FromArgb(0x2B, 0x5D, 0x79);

        private static Color RGB_ENEMY_HP_BAR_COLOR = Color.FromArgb(0x94, 0x24, 0x18);
        private static Color RGB_ENEMY_LEVEL_COLOR = Color.FromArgb(0x35, 0x03, 0x00);
        private static Color RGB_ENEMY_MINION_HP_BAR_COLOR = Color.FromArgb(0x79, 0x39, 0x37);

        public static Point GetEnemyPosition()
        {
            var W2S = Renderer.WorldToScreen(LocalPlayer.GetPosition());
            int Range = (int)(LocalPlayer.GetAttackRange() + LocalPlayer.GetAttackRange());

            Rectangle FOV = new Rectangle((int)W2S.X - Range / 2, (int)W2S.Y - Range / 2, Range + 60, Range - 100);
            Point[] Searched = PixelSearch.Search(FOV, RGB_ENEMY_LEVEL_COLOR, 1);

            Point result = new Point();

            if (Searched.Length != 0)
            {
                Point[] OrderedY = Searched.OrderBy(t => t.Y).ToArray<Point>();

                List<Tuple<SharpDX.Vector2, double>> list = new List<Tuple<SharpDX.Vector2, double>>();
                Point[] array3 = OrderedY;

                for (int i = 0; i < array3.Length; i++)
                {
                    Point point = array3[i];
                    SharpDX.Vector2 current = new SharpDX.Vector2((float)point.X, (float)point.Y);
                    if ((from t in list where (t.Item1 - current).Length() < 25f || Math.Abs(t.Item1.X - current.X) < 25f select t).Count<Tuple<SharpDX.Vector2, double>>() < 1)
                    {
                        list.Add(new Tuple<SharpDX.Vector2, double>(current, (double)(current - new SharpDX.Vector2((float)FOV.X, (float)FOV.Y)).Length()));
                        if (list.Count > 2)
                        {
                            break;
                        }
                    }
                }

                Tuple<SharpDX.Vector2, double> tuple = (from t in list orderby t.Item2 select t).ElementAt(0);
                Point point2 = new Point((int)tuple.Item1.X, (int)tuple.Item1.Y);

                result.X = point2.X + 43;
                result.Y = point2.Y + 85;
            }

            return result;
        }
    }
}
