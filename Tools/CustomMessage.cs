using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
    public partial class CustomMessage : Form //hateme/wizatek fade
    {
        private int tickCount;

        public CustomMessage(string Text)
        {
            InitializeComponent();
            label1.Text = Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++tickCount;
            if (tickCount <= 30)
                return;
            Opacity -= 0.0350000001490116;
            if (Opacity > 0.0)
                return;
            Close();
        }

        private void CustomMessage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
