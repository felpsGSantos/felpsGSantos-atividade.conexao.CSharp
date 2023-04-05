using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmFuncionarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
       
        public frmFuncionarios()
        {
            InitializeComponent();
            
            desabilitarCampos();
            desabilitarBotoes();
            escolhaSexo();
        }

        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            desabilitarBotoes();
            txtNome.Text = nome;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            habilitarCamposPesquisa();
            habilitarBotoesPesquisa();
            pesquisaPorNomeFuncionario(txtNome.Text);

        }
        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        

        public void escolhaSexo()
        {
            cbbSexo.Items.Add("Masculino");
            cbbSexo.Items.Add("Feminino");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void alterandoInf(int codFunc)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "update tbFuncionarios set nome = '@nome' , email = '@email' , cpf = '@cpf', telefone = '@telefone' , sexo , = @sexo , endereco = @endereco , numero = @numero , cep = @cep , bairro = @bairro , cidade = @cidade , estado = @estado where codFunc = " + codFunc + ";";
            conn.CommandType = CommandType.Text;

            conn.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            conn.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            conn.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkdCPF.Text;
            conn.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkdTelefone.Text;
            conn.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            conn.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            conn.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            conn.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkdCEP.Text;
            conn.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            conn.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            conn.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;


            conn.Connection = Conexao.obterConexao();
            int res = conn.ExecuteNonQuery();
            MessageBox.Show("registro alterado com sucesso.");

            Conexao.fecharConexao();
        }
        public void limparDados()
        {
            txtNome.Focus();
            txtCodigo.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            mkdCPF.Clear();
            mkdCEP.Clear();
            mkdTelefone.Clear();
            cbbSexo.Text = "";
            txtNumero.Clear();
            txtBairro.Clear();
            cbbEstado.Text = "";
            txtCidade.Clear();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparDados();
            txtNome.Focus();

        }
        //criando método para desabilitarCampos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mkdCPF.Enabled = false;
            mkdTelefone.Enabled = false;
            cbbSexo.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            mkdCEP.Enabled = false;
            cbbEstado.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;

        }

        public void desabilitarBotoes()
        {

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mkdCPF.Enabled = true;
            mkdTelefone.Enabled = true;
            cbbSexo.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            mkdCEP.Enabled = true;
            cbbEstado.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;


        }

        public void habilitarBotoes()
        {

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;


        }

        public void habilitarCamposPesquisa()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mkdCPF.Enabled = true;
            mkdTelefone.Enabled = true;
            cbbSexo.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            mkdCEP.Enabled = true;
            cbbEstado.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
        }

        public void habilitarBotoesPesquisa()
        {
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            habilitarBotoes();
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mkdCPF.Text.Equals("   .   .   -")
               || mkdTelefone.Text.Equals("(  )      -") || cbbSexo.Text.Equals("") || txtEndereco.Text.Equals("")
               || txtNumero.Text.Equals("") || mkdCEP.Text.Equals("     -") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("")
               || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("preencha", "Mensagem do Sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error
                );


            }
            else
            {
                /*MessageBox.Show("Cadastro co sucesso");
                limparDados();
                desabilitarCampos();
                desabilitarBotoes();
                btnNovo.Enabled = false;*/

                cadastrarFuncionario();
            }
        }
        public void cadastrarFuncionario()
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "insert into tbFuncionarios (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)" +
                "values(@nome,@email,@cpf,@telefone,@sexo,@endereco,@numero,@cep,@bairro,@cidade,@estado)";

            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            conn.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            conn.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkdCPF.Text;
            conn.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkdTelefone.Text;
            conn.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            conn.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            conn.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            conn.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkdCEP.Text;
            conn.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            conn.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            conn.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;

            conn.Connection = Conexao.obterConexao();
            int res = conn.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso!!!");

            Conexao.fecharConexao();

        }

        public int excluirFuncionario(int codFunc)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "delete from tbFuncionarios where codFunc =   @codFunc ;";
            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codFunc;

            conn.Connection = Conexao.obterConexao();

            int resp = conn.ExecuteNonQuery();

            if (resp == 1)
            {
                return resp;
            }
            else
            {
                return resp;
            }
            Conexao.fecharConexao();
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.ShowDialog();
            this.Hide();
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterandoInf(Convert.ToInt32(txtCodigo.Text));
            desabilitarCampos();
            desabilitarBotoes();
            limparDados();
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja excluir?", "Mensagem do sistema",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                //vai excluir
                int resp = excluirFuncionario(Convert.ToInt32(txtCodigo.Text));

                MessageBox.Show("Excluido com sucesso", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                btnNovo.Enabled = true;
                limparDados();
                desabilitarCampos();
                desabilitarBotoes();
            }
            else
            {
                txtNome.Focus();
            }
        }

        public void buscaCEP(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

            WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

            txtEndereco.Text = endereco.end;
            txtBairro.Text = endereco.bairro;
            txtCidade.Text = endereco.cidade;
            cbbEstado.Text = endereco.uf;
        }

        private void btnTestarCEP_Click(object sender, EventArgs e)
        {
            buscaCEP(mkdCEP.Text);
        }

       

        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mkdCEP.Text);
                txtNumero.Focus();
            }
        }

        //pesquisa por Nome Cliente
        public void pesquisaPorNomeFuncionario(string nome)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "select * from tbFuncionarios where nome like '%" + nome + "%';";
            conn.CommandType = CommandType.Text;
            conn.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = conn.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mkdCPF.Text = DR.GetString(3);
            mkdTelefone.Text = DR.GetString(4);
            cbbSexo.Text = DR.GetString(5);
            txtEndereco.Text = DR.GetString(6);
            txtNumero.Text = DR.GetString(7);
            mkdCEP.Text = DR.GetString(8);
            txtBairro.Text = DR.GetString(9);
            txtCidade.Text = DR.GetString(10);
            cbbEstado.Text = DR.GetString(11);

            Conexao.fecharConexao();

        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog  BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("d:\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pctFoto.ImageLocation = (BuscarIMG.FileName);
        }

        private void btnExcluirFoto_Click(object sender, EventArgs e)
        {
            pctFoto.Image = null;
        }
    }
    
}
