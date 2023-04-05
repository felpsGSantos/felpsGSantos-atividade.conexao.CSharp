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
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;


            if (txtVariavel1.Text == "" || txtVariavel2.Text == "")
            {
                MessageBox.Show("Insira algum algoritimo", "Mensagem do Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);


            }
            else
            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          

            
           
                num1 = Convert.ToDouble(txtVariavel1.Text);
                num2 = Convert.ToDouble(txtVariavel2.Text);
            

            




            if (rdbAdicao.Checked)
            {
                resp = num1 + num2;

                lblResposta.Text = resp.ToString();
            }



            if (rdbSubtracao.Checked)
            {
                resp = num1 - num2;

                lblResposta.Text = resp.ToString();
            }

            if (rdbMultiplicacao.Checked)
            {
                resp = num1 * num2;

                lblResposta.Text = resp.ToString();
            }

            if (rdbDivisao.Checked && num2 == 0)
            {

                MessageBox.Show("Não é possível fazer a divisão com o 0");

               if (rdbDivisao.Checked)
                {
                    resp = num1 / num2;

                    lblResposta.Text = resp.ToString();
                }
               


            }

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVariavel1.Clear();
            txtVariavel2.Clear();
            lblResposta.Text = "";


            rdbAdicao.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;



        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }

        private void lblVariavel2_Click(object sender, EventArgs e)
        {

        }
    }
}
