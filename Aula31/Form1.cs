using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = 0d;
            double nota2 = 0d;
            double nota3 = 0d;
            double nota4 = 0d;
            double media = 0d;

            nota1 = double.Parse(textBox1.Text);
            nota2 = double.Parse(textBox2.Text);
            nota3 = double.Parse(textBox3.Text);
            nota4 = double.Parse(textBox4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            label1.Text = String.Format("Média = {0:0.0}", media);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
