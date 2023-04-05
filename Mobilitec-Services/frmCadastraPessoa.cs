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
    public partial class frmCadastraPessoa : Form
    {
        public frmCadastraPessoa()
        {
            InitializeComponent();
            carregarCabecalho();
        }

        DataTable dt = new DataTable();

        public void bancoInclementado()
        {
            
        }

        public void carregarCabecalho()
        {
            dt.Columns.Add("Código", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));

            dgvDadosPessoais.DataSource = dt;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtCodigo.Text, txtNome.Text, txtEmail.Text, mkdCPF.Text, mkdTelefone.Text );
            dgvDadosPessoais.DataSource = dt;
            limparDados();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDadosPessoais.CurrentRow != null)
            {
                int linha = dgvDadosPessoais.CurrentCell.RowIndex;
                dgvDadosPessoais.Rows.RemoveAt(linha);
            }
            else
            {
                MessageBox.Show("Dados excluídos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dgvDadosPessoais.DataSource = dt;

        }

        private void dgvDadosPessoais_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvDadosPessoais.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvDadosPessoais.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dgvDadosPessoais.CurrentRow.Cells[2].Value.ToString();
                mkdCPF.Text = dgvDadosPessoais.CurrentRow.Cells[3].Value.ToString();
                mkdTelefone.Text = dgvDadosPessoais.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}








