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
    public partial class frmFolhaDePagamento : Form
    {
        public frmFolhaDePagamento()
        {
            InitializeComponent();
        }

        double vsalario = 0 ;
        

        

         

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            switch (cbbClubeDeLazer.Text)
            {
                case "Clube A":
                    
                    vsalario = Convert.ToDouble(txtSalarioFolha.Text);
                    vsalario = vsalario - 100;
                    
                    break;

                case "Clube B":
                    
                    vsalario = Convert.ToDouble(txtSalarioFolha.Text);
                    vsalario = vsalario - 50;
                    
                    break;

                case "Clube C":
                   
                    vsalario = Convert.ToDouble(txtSalarioFolha.Text);
                    vsalario = vsalario - 10;
                    
                    break;

                default:
                    break;
            }

                    txtSalarioFolha.Text = vsalario.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {


            
            
            txtSalarioFolha.Text = txtSalario.Text;
            
          

        }


        private void txtSalarioFolha_TextChanged(object sender, EventArgs e)
        {
            txtImpostoDeRenda.Text = txtSalarioFolha.Text;
        }

        private void ckbPlanoDeSaude_CheckedChanged(object sender, EventArgs e)
        {
           
            
            if (ckbPlanoDeSaude.Checked)
            {
               

                vsalario = Convert.ToDouble(txtSalarioFolha.Text);
                vsalario = vsalario - 50;
                txtSalarioFolha.Text = vsalario.ToString();

                

            }

            
        }

        private void txtImpostoDeRenda_TextChanged(object sender, EventArgs e)
        {
            
             double im;
            


            if (vsalario <1903.99)
            {
                im = 0;
                txtImpostoDeRenda.Text = im.ToString();
            }
            
            if (vsalario >= 1903.99 && vsalario <= 2826.66)
            {
                im = (vsalario * 7.5 / 100);

                txtImpostoDeRenda.Text = im.ToString();
            }

            if (vsalario >= 2826.66 && vsalario <= 3751.05)
            {
               im = (vsalario * 15.0 / 100);

                txtImpostoDeRenda.Text = im.ToString();
            }

            if (vsalario >= 3751.06 && vsalario <= 4664.68)
            {
                im = (vsalario * 22.5 / 100);

                txtImpostoDeRenda.Text = im.ToString();
            }
           

            



            




        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            cbbClubeDeLazer.Text = "";
            ckbPlanoDeSaude.Checked = false;
            txtSalario.Text = "";
            txtSalarioFolha.Text = "";
            txtSalarioLiquido.Text = "";
            txtImpostoDeRenda.Text = "";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double var1, var2, calc;

            var1 = Convert.ToDouble(txtSalarioFolha.Text);
            var2 = Convert.ToDouble(txtImpostoDeRenda.Text);

            calc = var1 - var2;

            txtSalarioLiquido.Text = calc.ToString();
        }

        private void dtpDatadafolha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}










