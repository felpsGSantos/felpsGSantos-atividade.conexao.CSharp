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
    public partial class frmPesquisarFuncionarios : Form
    {
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            txtDescricao.Enabled = false;
        }


        public void inclementandoPesquisa()
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "insert into tbFuncionarios (nome) values(@nome)";

            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;
        }
        //pesquisa por código
        public void pesquisaPorCodigo(int codFunc)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "select * from tbFuncionarios where codFunc = " + codFunc + ";";
            conn.CommandType = CommandType.Text;

            conn.Connection = Conexao.obterConexao();



            MySqlDataReader DR;

            DR = conn.ExecuteReader();
            DR.Read();
            ltbResultadoPesquisa.Items.Clear();

            ltbResultadoPesquisa.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }

        public void pesquisaPorNome(string nome)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "select * from tbFuncionarios where nome like '%" + nome + "%';";
            conn.CommandType = CommandType.Text;

            conn.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = conn.ExecuteReader();
            DR.Read();
            ltbResultadoPesquisa.Items.Clear();
            ltbResultadoPesquisa.Items.Add(DR.GetString(1));

            while (DR.Read())
            {
                ltbResultadoPesquisa.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();


        }
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbResultadoPesquisa.Items.Clear();
            txtDescricao.Enabled = false;

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();



        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            ltbResultadoPesquisa.Items.Clear();
            ltbResultadoPesquisa.Items.Add(txtDescricao.Text);

            if (rdbCodigo.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa ",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                txtDescricao.Focus();
            }
            if (rdbNome.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa ",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {


                if (rdbCodigo.Checked)
                {
                    pesquisaPorCodigo(Convert.ToInt32(txtDescricao.Text));
                }
                if (rdbNome.Checked)
                {
                    pesquisaPorNome(txtDescricao.Text);
                }
            }





        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void ltbResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resp = ltbResultadoPesquisa.SelectedItem.ToString();

            frmFuncionarios abrir = new frmFuncionarios(resp);
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
