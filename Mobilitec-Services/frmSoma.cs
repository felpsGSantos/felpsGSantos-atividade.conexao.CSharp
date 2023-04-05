using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando uma variável
            double num1, num2, resp;
            int valor;
            char sexo;
            string nome;
            bool acesso;

            //inicializar as variáveis ou atribuir valor

           
            valor = 3;
            sexo = 'F';
            nome = "Senac largo Treze";
            acesso = true;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 + num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja sair do sistema?","Mensagem do Sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 - num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 * num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 / num2;

            lblResposta.Text = resp.ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
