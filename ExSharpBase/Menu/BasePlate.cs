using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ExSharpBase.Modules;
using ExSharpBase.Events;
using ExSharpBase.Game.Spells;

namespace ExSharpBase.Menu
{
    public partial class BasePlate : Form
    {
        public BasePlate()
        {
            InitializeComponent();
        }

        private void BasePlate_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeImport.ReleaseCapture();
                NativeImport.SendMessage(Handle, NativeImport.WM_NCLBUTTONDOWN, NativeImport.HTCAPTION, 0);
            }
        }

        private void DrawRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawRangeCheckBox.Checked) Drawing.DrawingProperties["DrawRange"] = true;
            else Drawing.DrawingProperties["DrawRange"] = false;
        }

        private void MoveToMouseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MoveToMouseCheckBox.Checked)
            {
                this.Hide();

                NativeImport.SetForegroundWindow(Utils.GetLeagueProcess().MainWindowHandle);

                Thread.Sleep(1000); //Prevents instant IssueOrder when League window isn't active.

                Game.Engine.IssueOrder(Enums.GameObjectOrder.MoveTo);
            }
        }
    }
}
