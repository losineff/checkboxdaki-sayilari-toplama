using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBoxtaki_sayıları_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(checkBox1.Text);
            int b = Convert.ToInt32(checkBox2.Text);
            int c = Convert.ToInt32(checkBox3.Text);
            int d = Convert.ToInt32(checkBox4.Text);
            int f = Convert.ToInt32(checkBox5.Text);
            int toplam = 0;
            if (checkBox1.Checked == true) toplam += a;
            if (checkBox2.Checked == true) toplam += b;
            if (checkBox3.Checked == true) toplam += c;
            if (checkBox4.Checked == true) toplam += d;
            if (checkBox5.Checked == true) toplam += f;
            MessageBox.Show("Toplamları:"+toplam.ToString());
        }
    }
}
