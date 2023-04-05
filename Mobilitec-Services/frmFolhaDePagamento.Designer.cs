
namespace Mobilitec_Services
{
    partial class frmFolhaDePagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaDePagamento));
            this.lblDataDaFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dtpDatadafolha = new System.Windows.Forms.DateTimePicker();
            this.ckbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.lblClubeDeLazer = new System.Windows.Forms.Label();
            this.cbbClubeDeLazer = new System.Windows.Forms.ComboBox();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoDeRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtImpostoDeRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataDaFolha
            // 
            this.lblDataDaFolha.AutoSize = true;
            this.lblDataDaFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDaFolha.Location = new System.Drawing.Point(41, 50);
            this.lblDataDaFolha.Name = "lblDataDaFolha";
            this.lblDataDaFolha.Size = new System.Drawing.Size(93, 16);
            this.lblDataDaFolha.TabIndex = 0;
            this.lblDataDaFolha.Text = "Data da Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(41, 137);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(51, 16);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(44, 156);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 22);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // dtpDatadafolha
            // 
            this.dtpDatadafolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatadafolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatadafolha.Location = new System.Drawing.Point(44, 78);
            this.dtpDatadafolha.Name = "dtpDatadafolha";
            this.dtpDatadafolha.Size = new System.Drawing.Size(106, 22);
            this.dtpDatadafolha.TabIndex = 0;
            this.dtpDatadafolha.TabStop = false;
            this.dtpDatadafolha.Value = new System.DateTime(2023, 3, 9, 0, 0, 0, 0);
            this.dtpDatadafolha.ValueChanged += new System.EventHandler(this.dtpDatadafolha_ValueChanged);
            // 
            // ckbPlanoDeSaude
            // 
            this.ckbPlanoDeSaude.AutoSize = true;
            this.ckbPlanoDeSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlanoDeSaude.Location = new System.Drawing.Point(44, 193);
            this.ckbPlanoDeSaude.Name = "ckbPlanoDeSaude";
            this.ckbPlanoDeSaude.Size = new System.Drawing.Size(122, 20);
            this.ckbPlanoDeSaude.TabIndex = 2;
            this.ckbPlanoDeSaude.Text = "Plano de saúde";
            this.ckbPlanoDeSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoDeSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoDeSaude_CheckedChanged);
            // 
            // lblClubeDeLazer
            // 
            this.lblClubeDeLazer.AutoSize = true;
            this.lblClubeDeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeDeLazer.Location = new System.Drawing.Point(40, 268);
            this.lblClubeDeLazer.Name = "lblClubeDeLazer";
            this.lblClubeDeLazer.Size = new System.Drawing.Size(94, 16);
            this.lblClubeDeLazer.TabIndex = 7;
            this.lblClubeDeLazer.Text = "Clube de lazer";
            // 
            // cbbClubeDeLazer
            // 
            this.cbbClubeDeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClubeDeLazer.FormattingEnabled = true;
            this.cbbClubeDeLazer.Items.AddRange(new object[] {
            "",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClubeDeLazer.Location = new System.Drawing.Point(43, 287);
            this.cbbClubeDeLazer.Name = "cbbClubeDeLazer";
            this.cbbClubeDeLazer.Size = new System.Drawing.Size(121, 24);
            this.cbbClubeDeLazer.TabIndex = 3;
            this.cbbClubeDeLazer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(315, 110);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(88, 16);
            this.lblSalarioFolha.TabIndex = 10;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // lblImpostoDeRenda
            // 
            this.lblImpostoDeRenda.AutoSize = true;
            this.lblImpostoDeRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoDeRenda.Location = new System.Drawing.Point(314, 162);
            this.lblImpostoDeRenda.Name = "lblImpostoDeRenda";
            this.lblImpostoDeRenda.Size = new System.Drawing.Size(119, 16);
            this.lblImpostoDeRenda.TabIndex = 11;
            this.lblImpostoDeRenda.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(315, 210);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(98, 16);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFolha.Location = new System.Drawing.Point(454, 110);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioFolha.TabIndex = 4;
            this.txtSalarioFolha.TabStop = false;
            this.txtSalarioFolha.TextChanged += new System.EventHandler(this.txtSalarioFolha_TextChanged);
            // 
            // txtImpostoDeRenda
            // 
            this.txtImpostoDeRenda.Enabled = false;
            this.txtImpostoDeRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoDeRenda.Location = new System.Drawing.Point(454, 159);
            this.txtImpostoDeRenda.Name = "txtImpostoDeRenda";
            this.txtImpostoDeRenda.Size = new System.Drawing.Size(100, 22);
            this.txtImpostoDeRenda.TabIndex = 5;
            this.txtImpostoDeRenda.TabStop = false;
            this.txtImpostoDeRenda.TextChanged += new System.EventHandler(this.txtImpostoDeRenda_TextChanged);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(454, 210);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioLiquido.TabIndex = 6;
            this.txtSalarioLiquido.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(296, 373);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(530, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 43);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(414, 373);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 43);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 466);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoDeRenda);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoDeRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.cbbClubeDeLazer);
            this.Controls.Add(this.lblClubeDeLazer);
            this.Controls.Add(this.ckbPlanoDeSaude);
            this.Controls.Add(this.dtpDatadafolha);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataDaFolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFolhaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDaFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DateTimePicker dtpDatadafolha;
        private System.Windows.Forms.CheckBox ckbPlanoDeSaude;
        private System.Windows.Forms.Label lblClubeDeLazer;
        private System.Windows.Forms.ComboBox cbbClubeDeLazer;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoDeRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtImpostoDeRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}