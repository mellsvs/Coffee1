using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffee1
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void Open_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.009;
                if (this.Opacity == 0)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
