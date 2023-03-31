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
    public partial class Form2 : Form
    {
        double salario = 0d;
        double novoSalario = 0d;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);

            novoSalario = salario * 1.05;

            label2.Text = String.Format("Novo Salário = {0:c}", novoSalario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);

            novoSalario = salario * 1.1;

            label2.Text = String.Format("Novo Salário = {0:c}", novoSalario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);

            novoSalario = salario * 1.15;

            label2.Text = String.Format("Novo Salário = {0:c}", novoSalario);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);

            novoSalario = salario * 1.20;

            label2.Text = String.Format("Novo Salário = {0:c}", novoSalario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
