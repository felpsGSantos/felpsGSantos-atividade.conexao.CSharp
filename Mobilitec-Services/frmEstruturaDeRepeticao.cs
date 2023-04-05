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
    public partial class frmEstruturaDeRepeticao : Form
    {
        public frmEstruturaDeRepeticao()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int contador, repeticoes;
            double soma, valor;

            contador = Convert.ToInt32(txtContador.Text);

            repeticoes = Convert.ToInt32(txtRepeticoes.Text);

            soma = Convert.ToDouble(txtSoma.Text);

            valor = Convert.ToDouble(txtValor.Text);

            ltbSomatoria.Items.Clear();
            cbbSomatoria.Items.Clear();

            while (contador <= repeticoes)
            {
                contador++;
                soma = soma + valor;
                ltbSomatoria.Items.Add("A soma:" + soma + "reais" + contador);
                cbbSomatoria.Items.Add(soma);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtContador.Clear();
            txtSoma.Clear();
            txtValor.Clear();
            txtRepeticoes.Clear();
            ltbSomatoria.Items.Clear();
            txtContador.Focus();
            cbbSomatoria.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisando");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ltbSomatoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
