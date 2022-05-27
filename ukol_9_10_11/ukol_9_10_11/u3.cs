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
    public partial class u3 : Form
    {
        public u3()
        {
            InitializeComponent();
            button2.BackColor = Color.FromArgb(29, 68, 184);
        }

        private bool JePrvocislo(int vstup)
        {
            if (vstup == 2) return true;
            else if (vstup % 2 == 0 || vstup == 1) return false;
            else
            {
                for (int i = 3; i <= Math.Sqrt(vstup); i += 2)
                {
                    if (vstup % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Rozklad(int vstup, ListBox listBox)
        {
            int k = 1;
            listBox.Items.Clear();
            for (int i = 2; i <= (vstup); i += k)
            {                
                if (JePrvocislo(i) == false) continue;
                while(vstup % i == 0)
                {                    
                    listBox.Items.Add(i);
                    vstup /= i;
                }
                if (i == 3) k = 2;
            }
        }

        private int NSD(int a, int b)
        {
            while (a != b)
            {
                if(a > b) a -= b;                                                   
                else b -= a;                                                   
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int cislo1 = (int)numericUpDown1.Value;
            int cislo2 = (int)numericUpDown2.Value;


            Rozklad(cislo1, listBox1);
            Rozklad(cislo2, listBox2);

            int nsd = NSD(cislo1, cislo2);
            int nsn = (cislo1 * cislo2) / nsd;
            label1.Text = "NSD: " + nsd.ToString();
            label2.Text = "NSN: " + nsn.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu jsou dvě čísla, spočítejte NSD (největší společný dělitel), NSN (nejmenší "+
            "společný násobek).Do listboxů vypište rozklad na prvočísla.Napište metodu " +
            "JePrvocislo, která vrací zda číslo je prvočíslo a nejmenší dělitel.Napište metodu "+
            "Rozklad a metodu NS.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
