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
    public partial class frmTabList : Form
    {
        public frmTabList()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigo, nome;
            bool autorizo = false;

            codigo = txtCodigo.Text;
            nome = txtNome.Text;

            if (ckbAutorizo.Checked)
            {
                autorizo = true;

                dgvCadastro.Rows.Add(codigo, nome, autorizo);

                MessageBox.Show("autorizado co sucesso", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                
               
            }

            txtCodigo.Text = "";
            txtNome.Text = "";
            ckbAutorizo.Checked = false;
        }
    }
}
