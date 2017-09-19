using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaGlowna ListaKontahentow = new ListaGlowna();
            ListaKontahentow.nazwaOkna = "Kontrahenci";
            listBox1.Items.Add(ListaKontahentow.nazwaOkna);
           
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaGlowna ListaTowarow = new ListaGlowna();
            ListaTowarow.nazwaOkna = "Towary";
            listBox1.Items.Add(ListaTowarow.nazwaOkna);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaGlowna ListaFaktur = new ListaGlowna();
            ListaFaktur.nazwaOkna = "Faktury";
            listBox1.Items.Add(ListaFaktur.nazwaOkna);
            
            
        }
    }
}
