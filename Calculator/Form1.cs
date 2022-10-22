using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
//            int a = int.Parse(txSo1.Text);
//            int b = int.Parse(txSo2.Text);
//<<<<<<< HEAD
//            int c = a + b;
//            txKetqua.Text = c.ToString();
//=======
//            int c = a + b +a;
//            txKetqua.Text = c.ToString()    ;
//>>>>>>> master
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txSo1.Text);
            double b = double.Parse(txSo2.Text);
            double c = a - b;
            txKetqua.Text = c.ToString();
        }
    }
}
