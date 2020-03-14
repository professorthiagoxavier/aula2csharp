using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDois
{
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = double.Parse(txtSalario.Text);
            float desconto = float.Parse(txtDesconto.Text);
            double calDesconto = salario * desconto / 100; //desconto
            salario = salario - calDesconto;
            MessageBox.Show("Salário do cabra: " + Math.Round(salario, 2));
        }
    }
}
