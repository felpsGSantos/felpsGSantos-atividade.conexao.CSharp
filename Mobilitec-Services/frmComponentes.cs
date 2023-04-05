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
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Close();
            //this.Close();
            Application.Exit();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("Selecionou masculino");
            }
            if (rdbFeminino.Checked)
            {
                MessageBox.Show("Selecionou feminino");
            }

            if (ckbLivros.Checked)
            {
                MessageBox.Show("Selecionou Livros");
            }
            if (ckbAcademia.Checked)
            {
                MessageBox.Show("Selecionou Academia");
            }
            if (ckbCultura.Checked)
            {
                MessageBox.Show("Selecionou Cultura");
            }
            if (ckbEsportes.Checked)
            {
                MessageBox.Show("Selecionou Esportes");

            }
        }

        private void cbbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrando a posição selecionada
            //int valor = cbbEstados.SelectedIndex;

            //Mostrando um valor selecionado
            string valor = cbbEstados.SelectedItem.ToString();
            MessageBox.Show("Item selecionado "+ valor);
        }

        private void ltbPreferencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrando a posição selecionada
            //int valor = ltbPreferencias.SelectedIndex;

            //Mostrando o valor selecionado da lista
            string valor = ltbPreferencias.SelectedItem.ToString();
            MessageBox.Show("Item selecionado" + valor);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbbEstados.Items.Clear();
            ltbPreferencias.Items.Clear();
            cbbEstados.Text = "";


            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;

            ckbLivros.Checked = false;
            ckbEsportes.Checked = false;
            ckbCultura.Checked = false;
            ckbAcademia.Checked = false;




        }
    }
}
