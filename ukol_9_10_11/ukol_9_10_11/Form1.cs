using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_9_10_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form u1 = new u1();
            this.Hide();
            u1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form u2 = new u2();
            this.Hide();
            u2.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form u3= new u3();
            this.Hide();
            u3.ShowDialog();
            this.Close();
        }
    }
}
