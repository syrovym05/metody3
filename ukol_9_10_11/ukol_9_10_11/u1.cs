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
    public partial class u1 : Form
    {
        public u1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum(TextBox textBox, ref int malapisemna, ref int velkapismena, ref int cisla, ref int ostatni)
        {          
            string mala = "abcdefghijklmnopqrstuvwxyz";
            string velka = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nums = "0123456789";

            foreach(char c in textBox.Text)
            {
                if (mala.Contains(c)) malapisemna++;
                else if (velka.Contains(c)) velkapismena++;
                else if (nums.Contains(c)) cisla++;
                else ostatni++;
            }
            if (ostatni == 0) return true;
            else return false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int malapisemna = 0, velkapismena = 0, cisla = 0, ostatni = 0;
            bool jealfanum = JeAlfanum(textBox1, ref malapisemna, ref velkapismena, ref cisla, ref ostatni);
            label1.Text = String.Format("Text {0} alfanumercký",jealfanum ? "je" : "není");
            label2.Text = "Počet velkých písmen: " + velkapismena;
            label3.Text = "Počet malých písmen: " + malapisemna;
            label4.Text = "Počet čísel: " + cisla;
            label5.Text = "Počet ostatních znaků: " + ostatni;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napište metodu JeAlfanum, která pro zadaný řetězec zjistí, zda je alfanumerický " +
            "(obsahuje pouze písmena a číslice), kolik obsahuje malých písmen, kolik obsahuje " +
            "velkých písmen a kolik obsahuje jiných znaků než alfanumerických.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
