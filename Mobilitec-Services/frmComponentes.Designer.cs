
namespace Mobilitec_Services
{
    partial class frmComponentes
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
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.ltbPreferencias = new System.Windows.Forms.ListBox();
            this.ckbEsportes = new System.Windows.Forms.CheckBox();
            this.ckbCultura = new System.Windows.Forms.CheckBox();
            this.ckbAcademia = new System.Windows.Forms.CheckBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblEstados = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.lblPreferencias = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstados
            // 
            this.cbbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Items.AddRange(new object[] {
            "São paulo ",
            "Rio de Janeiro",
            "Belo Horizonte",
            "Paraná"});
            this.cbbEstados.Location = new System.Drawing.Point(81, 79);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(121, 24);
            this.cbbEstados.TabIndex = 0;
            this.cbbEstados.SelectedIndexChanged += new System.EventHandler(this.cbbEstados_SelectedIndexChanged);
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLivros.Location = new System.Drawing.Point(81, 191);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(56, 20);
            this.ckbLivros.TabIndex = 1;
            this.ckbLivros.Text = "Livro";
            this.ckbLivros.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(75, 366);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(87, 20);
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ltbPreferencias
            // 
            this.ltbPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPreferencias.FormattingEnabled = true;
            this.ltbPreferencias.ItemHeight = 16;
            this.ltbPreferencias.Items.AddRange(new object[] {
            "Amarelo",
            "Vermelho",
            "Azul",
            "Cinza",
            "preto"});
            this.ltbPreferencias.Location = new System.Drawing.Point(366, 79);
            this.ltbPreferencias.Name = "ltbPreferencias";
            this.ltbPreferencias.Size = new System.Drawing.Size(149, 132);
            this.ltbPreferencias.TabIndex = 7;
            this.ltbPreferencias.SelectedIndexChanged += new System.EventHandler(this.ltbPreferencias_SelectedIndexChanged);
            // 
            // ckbEsportes
            // 
            this.ckbEsportes.AutoSize = true;
            this.ckbEsportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEsportes.Location = new System.Drawing.Point(81, 269);
            this.ckbEsportes.Name = "ckbEsportes";
            this.ckbEsportes.Size = new System.Drawing.Size(81, 20);
            this.ckbEsportes.TabIndex = 4;
            this.ckbEsportes.Text = "Esportes";
            this.ckbEsportes.UseVisualStyleBackColor = true;
            // 
            // ckbCultura
            // 
            this.ckbCultura.AutoSize = true;
            this.ckbCultura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCultura.Location = new System.Drawing.Point(81, 243);
            this.ckbCultura.Name = "ckbCultura";
            this.ckbCultura.Size = new System.Drawing.Size(68, 20);
            this.ckbCultura.TabIndex = 3;
            this.ckbCultura.Text = "Cultura";
            this.ckbCultura.UseVisualStyleBackColor = true;
            // 
            // ckbAcademia
            // 
            this.ckbAcademia.AutoSize = true;
            this.ckbAcademia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAcademia.Location = new System.Drawing.Point(81, 217);
            this.ckbAcademia.Name = "ckbAcademia";
            this.ckbAcademia.Size = new System.Drawing.Size(89, 20);
            this.ckbAcademia.TabIndex = 2;
            this.ckbAcademia.Text = "Academia";
            this.ckbAcademia.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeminino.Location = new System.Drawing.Point(75, 392);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(81, 20);
            this.rdbFeminino.TabIndex = 6;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(78, 43);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(58, 16);
            this.lblEstados.TabIndex = 8;
            this.lblEstados.Text = "Estados";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(78, 338);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 16);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(78, 154);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(69, 16);
            this.lblSelecione.TabIndex = 10;
            this.lblSelecione.Text = "Selecione";
            this.lblSelecione.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPreferencias
            // 
            this.lblPreferencias.AutoSize = true;
            this.lblPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferencias.Location = new System.Drawing.Point(400, 43);
            this.lblPreferencias.Name = "lblPreferencias";
            this.lblPreferencias.Size = new System.Drawing.Size(84, 16);
            this.lblPreferencias.TabIndex = 11;
            this.lblPreferencias.Text = "Preferências";
            this.lblPreferencias.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(366, 243);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(149, 46);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(366, 308);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 46);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(366, 378);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 46);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 481);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblPreferencias);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.ckbAcademia);
            this.Controls.Add(this.ckbCultura);
            this.Controls.Add(this.ckbEsportes);
            this.Controls.Add(this.ltbPreferencias);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.ckbLivros);
            this.Controls.Add(this.cbbEstados);
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComponentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.ListBox ltbPreferencias;
        private System.Windows.Forms.CheckBox ckbEsportes;
        private System.Windows.Forms.CheckBox ckbCultura;
        private System.Windows.Forms.CheckBox ckbAcademia;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Label lblPreferencias;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}