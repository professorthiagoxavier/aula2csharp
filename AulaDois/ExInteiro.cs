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
    public partial class ExInteiro : Form
    {
        public ExInteiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                   //converter para short
            short idade = short.Parse(txtIdade.Text);
            int cep = int.Parse(txtCEP.Text);
            long telefone = long.Parse(txtTelefone.Text);

            string mensagem = "Idade: " + idade;
            mensagem += "Cep: " + cep;
            mensagem += "Telefone: " + telefone;

            MessageBox.Show(mensagem);

        }
    }
}
