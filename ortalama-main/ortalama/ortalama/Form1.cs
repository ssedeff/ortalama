using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float yazili1, yazili2, ortalama;
            yazili1=Convert.ToInt32(textBox1.Text);
            yazili2=Convert.ToInt32(textBox2.Text);
            ortalama = (yazili1 + yazili2) / 2;
            label3.Text=ortalama.ToString();
        }
    }
}
