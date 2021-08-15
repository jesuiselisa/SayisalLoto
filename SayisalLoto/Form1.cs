using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            lbl1.Text = rnd.Next(1, 49).ToString();
            lbl2.Text = rnd.Next(1, 49).ToString();
            lbl3.Text = rnd.Next(1, 49).ToString();
            lbl4.Text = rnd.Next(1, 49).ToString();
            lbl5.Text = rnd.Next(1, 49).ToString();
            lbl6.Text = rnd.Next(1, 49).ToString();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lbl1.Text = "*";
            lbl2.Text = "*";
            lbl3.Text = "*";
            lbl4.Text = "*";
            lbl5.Text = "*";
            lbl6.Text = "*";
        }
    }
}
