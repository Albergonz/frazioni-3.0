using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frazioni_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (!Fraction.TryParse(textBox1.Text, out var f1))
            { MessageBox.Show("Frazione errata"); }
           
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("ERRORE", "NESSUN ELEMENTO");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("ERRORE", "NESSUN ELEMENTO");
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { Fraction somma = new Fraction(0, 1);

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("ERRORE", "NESSUN ELEMENTO");
            }
                foreach (Fraction fra in listBox1.Items)
            {
                somma = somma.Somma(fra);
            }
        }
    }
}
