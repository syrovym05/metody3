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
    public partial class u2 : Form
    {
        public u2()
        {
            
            InitializeComponent();
            button3.BackColor = Color.FromArgb(29, 68, 184);
        }

        private void SmazCisla(ref string text)
        {           
            foreach(char c in text)
            {
                if(char.IsDigit(c))
                {                
                    text = text.Replace(c.ToString(), "");                  
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }
           
            SmazCisla(ref vstup);
            
            string[] slova = vstup.Split(' ');
            listBox1.Items.Clear();                
            foreach(string s in slova)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je dán řetězec slov, každé slovo je odděleno jednou nebo více mezerami. Napište a " +
            "zavolejte metodu, která v řetězci smaže všechny číslice.Řetězec vypište, každé slovo " +
            "napište pod sebe do komponenty ListBox.","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
