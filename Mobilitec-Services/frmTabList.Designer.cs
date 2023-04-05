
namespace Mobilitec_Services
{
    partial class frmTabList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabList));
            this.tbpCadastro = new System.Windows.Forms.TabControl();
            this.tbpCadastrando = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblAutorizacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAutorizo = new System.Windows.Forms.Label();
            this.ckbAutorizo = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpCadastro.SuspendLayout();
            this.tbpCadastrando.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.tabPage2);
            this.tbpCadastro.Controls.Add(this.tbpCadastrando);
            this.tbpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCadastro.Location = new System.Drawing.Point(12, 63);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.SelectedIndex = 0;
            this.tbpCadastro.Size = new System.Drawing.Size(584, 402);
            this.tbpCadastro.TabIndex = 0;
            // 
            // tbpCadastrando
            // 
            this.tbpCadastrando.Controls.Add(this.txtNome);
            this.tbpCadastrando.Controls.Add(this.txtCodigo);
            this.tbpCadastrando.Controls.Add(this.btnLimpar);
            this.tbpCadastrando.Controls.Add(this.btnCadastrar);
            this.tbpCadastrando.Controls.Add(this.ckbAutorizo);
            this.tbpCadastrando.Controls.Add(this.lblAutorizo);
            this.tbpCadastrando.Controls.Add(this.lblNome);
            this.tbpCadastrando.Controls.Add(this.lblAutorizacao);
            this.tbpCadastrando.Controls.Add(this.lblCodigo);
            this.tbpCadastrando.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbpCadastrando.Location = new System.Drawing.Point(4, 29);
            this.tbpCadastrando.Name = "tbpCadastrando";
            this.tbpCadastrando.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastrando.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpCadastrando.Size = new System.Drawing.Size(576, 369);
            this.tbpCadastrando.TabIndex = 0;
            this.tbpCadastrando.Text = "Cadastro";
            this.tbpCadastrando.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCadastro);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(77, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblAutorizacao
            // 
            this.lblAutorizacao.AutoSize = true;
            this.lblAutorizacao.Location = new System.Drawing.Point(65, 183);
            this.lblAutorizacao.Name = "lblAutorizacao";
            this.lblAutorizacao.Size = new System.Drawing.Size(225, 20);
            this.lblAutorizacao.TabIndex = 1;
            this.lblAutorizacao.Text = "Autorizo o envio do programa?";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(77, 123);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblAutorizo
            // 
            this.lblAutorizo.AutoSize = true;
            this.lblAutorizo.Location = new System.Drawing.Point(103, 250);
            this.lblAutorizo.Name = "lblAutorizo";
            this.lblAutorizo.Size = new System.Drawing.Size(68, 20);
            this.lblAutorizo.TabIndex = 3;
            this.lblAutorizo.Text = "Autorizo";
            // 
            // ckbAutorizo
            // 
            this.ckbAutorizo.AutoSize = true;
            this.ckbAutorizo.Location = new System.Drawing.Point(69, 250);
            this.ckbAutorizo.Name = "ckbAutorizo";
            this.ckbAutorizo.Size = new System.Drawing.Size(15, 14);
            this.ckbAutorizo.TabIndex = 2;
            this.ckbAutorizo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(349, 299);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 33);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(472, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 29);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(456, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 33);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(168, 78);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 26);
            this.txtNome.TabIndex = 1;
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCadastro.Location = new System.Drawing.Point(0, 0);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(576, 369);
            this.dgvCadastro.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Autorizo envio para propaganda";
            this.Column3.Name = "Column3";
            // 
            // frmTabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.tbpCadastro);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTabList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastrando.ResumeLayout(false);
            this.tbpCadastrando.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpCadastro;
        private System.Windows.Forms.TabPage tbpCadastrando;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox ckbAutorizo;
        private System.Windows.Forms.Label lblAutorizo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAutorizacao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}