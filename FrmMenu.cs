using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirint
{
    public partial class FrmMenu : Form
    {

        public int[] m = new int[5];
        string[] s = new string[5];

        private void NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            int a = (int)nud.Value;
            int n = panel1.Controls.IndexOf(nud);
            m[n] = a;
            Bitmap b = (Bitmap)Properties.Resources.ResourceManager.GetObject(s[n]+a.ToString());
            panel2.Controls[n].BackgroundImage = b;
        }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            s[0] = "grass";
            s[1] = "kir";
            s[2] = "money";
            s[3] = "bomb";
            s[4] = "hero";
            for(int i = 0; i < 5; i++)
            {
                if (m[i] == 0) {m[i] = 1; }
                Bitmap b = (Bitmap)Properties.Resources.ResourceManager.GetObject(s[i] + m[i].ToString());
                panel2.Controls[i].BackgroundImage = b;
                NumericUpDown nud = (NumericUpDown)panel1.Controls[i];
                nud.Value = m[i];
            }
        }

    }
}
