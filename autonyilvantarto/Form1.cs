using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace autonyilvantarto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string auto = "Rendszám: " + textBox_rendszam.Text + "\n";
            auto += "Gyártmány: " + textBox_Gyartmany.Text + "\n";
            auto += "Tipus: " + textBox_Tipus + "\n";
            auto += "Dátum: " + Datum.Value +" Év";
            auto += " " + ho.Value + ". Hónap\n";
            if(comboBox_Szin.SelectedIndex == 0)
            {
                auto += "szine Fekete \n";
            }
            else if (comboBox_Szin.SelectedIndex == 1)
            {
                auto += "szine ezüst \n";
            }
            else if (comboBox_Szin.SelectedIndex == 2)
            {
                auto += "szine piros \n";
            }
            else if (comboBox_Szin.SelectedIndex == 3)
            {
                auto += "szine zöld \n";
            }
            else if (comboBox_Szin.SelectedIndex == 4)
            {
                auto += "egyéb szinü \n";
            }

            if(radioButton_igen.Checked)
            {
                auto += "Érvényes a müszaki \n";
            }
            else if(radioButton_nem.Checked)
            {
                auto += "Nem érvényes a müszaki \n";
            }

            kiir.Text = auto;

            StreamWriter ir = new StreamWriter("Autok.txt",true,Encoding.Default);
            ir.WriteLine(auto);
            ir.Close();

            MessageBox.Show("A adatok kiirása megtörtént a Autok.txt fájlba", "Fájlirás megtörtént");
        }
    }
}
