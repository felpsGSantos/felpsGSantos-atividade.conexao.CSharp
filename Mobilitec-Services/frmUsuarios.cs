using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            carregarCabecalho();
        }

        DataTable dt = new DataTable();



        public void carregarCabecalho()
        {
            dt.Columns.Add("Código", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));

            dgvRegistro.DataSource = dt;
        }

        public void limparDados()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mkdCPF.Text = "";
            mkdTelefone.Text = "";
            txtCodigo.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ;
            dt.Rows.Clear();
            dgvRegistro.DataSource = dt;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtCodigo.Text, txtNome.Text, txtEmail.Text, mkdCPF.Text, mkdTelefone.Text);
            dgvRegistro.DataSource = dt;
            limparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.CurrentRow != null)
            {
                int linha = dgvRegistro.CurrentCell.RowIndex;
                dgvRegistro.Rows.RemoveAt(linha);
            }
            else
            {
                MessageBox.Show("Dados excluídos");
            }
        }

        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvRegistro.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvRegistro.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dgvRegistro.CurrentRow.Cells[2].Value.ToString();
                mkdCPF.Text = dgvRegistro.CurrentRow.Cells[3].Value.ToString();
                mkdTelefone.Text = dgvRegistro.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
