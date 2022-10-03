using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        void Vypis1 (ref List<string> list)
        {
            listBox1.Items.Clear();
            foreach(string slovo in list)
            {               
                listBox1.Items.Add(slovo);
            }
        }
        void Pocet (ref List<char> listznaku)
        {
            int pocet = 0;
            foreach (char znak in listznaku)
            {
                if(znak == 'a' || znak == 'e' || znak == 'A' || znak == 'E')
                {
                    pocet++;
                }
            }
            label1.Text = "Počet 'a' a 'e': " + pocet;
            if(listznaku.Contains(' '))
            {
                label2.Text = "Mezera?: " + "Ano";
            }
            else
            {
                label2.Text = "Mezera?: " + "Ne";
            }
        }
        void Vypis2(ref List<char> list)
        {
            list.Sort();
            listBox2.Items.Clear();
            foreach (char znak in list)
            {
                if (((znak >= 'A' && znak <= 'Z') || (znak >= 'a' && znak <= 'z') || (znak >= '0' && znak <= '9')) || (int) znak == 32 || (int)znak == 127)
                {
                  
                }
                else
                {
                    listBox2.Items.Add(znak);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int n = (int)numericUpDown1.Value;
            List <string> list = new List <string>();
            List <char> listznaku = new List<char>();
            List <int> listcisel = new List<int>();
            for (int i = 0; i < n; i++)
            {
                char nahodne = (char)rng.Next(32, 128);
                if ((int)nahodne != 32 || (int)nahodne != 127)
                {
                    textBox1.AppendText(nahodne.ToString());
                }
                if(nahodne >= '0' && nahodne <= '9')
                {
                    listcisel.Add(nahodne);
                }
                list.Add(nahodne.ToString());
                listznaku.Add(nahodne);
            }
            Vypis1(ref list);
            Pocet(ref listznaku);
            Vypis2(ref listznaku);

        }
    }
}
