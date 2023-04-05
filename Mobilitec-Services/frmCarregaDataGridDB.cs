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
    public partial class frmCarregaDataGridDB : Form
    {
        public frmCarregaDataGridDB()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void btnCarregaDados_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();

            dgvFuncionarios.DataSource = null;

            string sql1 = "select * from tbFuncionarios;";

            string sql = " select codFunc as 'Código',nome as 'Nome', email as 'E-mail', cpf as 'CPF' , telefone as 'Telefone' from tbFuncionarios ;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao.obterConexao());

            da.Fill(dt);

            dgvFuncionarios.DataSource = dt;

            Conexao.fecharConexao();

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
