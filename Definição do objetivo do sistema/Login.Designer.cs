
namespace Definição_do_objetivo_do_sistema
{
    partial class frmBV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBV));
            this.btnAcessar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpfcnpj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.versenha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPFPJ = new System.Windows.Forms.ComboBox();
            this.gbBemvindo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.versenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBemvindo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.Color.White;
            this.btnAcessar.Location = new System.Drawing.Point(525, 309);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(194, 76);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "ACESSAR";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(368, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "CPF / CNPJ :";
            // 
            // txtCpfcnpj
            // 
            this.txtCpfcnpj.Location = new System.Drawing.Point(525, 200);
            this.txtCpfcnpj.Name = "txtCpfcnpj";
            this.txtCpfcnpj.Size = new System.Drawing.Size(279, 20);
            this.txtCpfcnpj.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(416, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "SENHA :";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(525, 261);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(194, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // cCadastrar
            // 
            this.cCadastrar.BackColor = System.Drawing.Color.DarkOrange;
            this.cCadastrar.FlatAppearance.BorderSize = 0;
            this.cCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cCadastrar.Location = new System.Drawing.Point(438, 522);
            this.cCadastrar.Name = "cCadastrar";
            this.cCadastrar.Size = new System.Drawing.Size(383, 35);
            this.cCadastrar.TabIndex = 4;
            this.cCadastrar.Text = "NÃO POSSUO CADASTRO";
            this.cCadastrar.UseVisualStyleBackColor = false;
            this.cCadastrar.Click += new System.EventHandler(this.cCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(322, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 84);
            this.label1.TabIndex = 12;
            this.label1.Text = "Para que possamos continuar\r\nefetue seu login!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versenha
            // 
            this.versenha.Image = global::Definição_do_objetivo_do_sistema.Properties.Resources.hide;
            this.versenha.Location = new System.Drawing.Point(741, 261);
            this.versenha.Name = "versenha";
            this.versenha.Size = new System.Drawing.Size(23, 20);
            this.versenha.TabIndex = 14;
            this.versenha.TabStop = false;
            this.versenha.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 228);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbPFPJ
            // 
            this.cbPFPJ.AutoCompleteCustomSource.AddRange(new string[] {
            "PF",
            "PJ"});
            this.cbPFPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPFPJ.FormattingEnabled = true;
            this.cbPFPJ.Items.AddRange(new object[] {
            "PJ",
            "PF"});
            this.cbPFPJ.Location = new System.Drawing.Point(573, 563);
            this.cbPFPJ.Name = "cbPFPJ";
            this.cbPFPJ.Size = new System.Drawing.Size(124, 24);
            this.cbPFPJ.TabIndex = 5;
            this.cbPFPJ.SelectedIndexChanged += new System.EventHandler(this.cbPFPJ_SelectedIndexChanged);
            // 
            // gbBemvindo
            // 
            this.gbBemvindo.Controls.Add(this.pictureBox1);
            this.gbBemvindo.Controls.Add(this.cbPFPJ);
            this.gbBemvindo.Controls.Add(this.versenha);
            this.gbBemvindo.Controls.Add(this.label1);
            this.gbBemvindo.Controls.Add(this.cCadastrar);
            this.gbBemvindo.Controls.Add(this.txtSenha);
            this.gbBemvindo.Controls.Add(this.label6);
            this.gbBemvindo.Controls.Add(this.txtCpfcnpj);
            this.gbBemvindo.Controls.Add(this.label5);
            this.gbBemvindo.Controls.Add(this.btnAcessar);
            this.gbBemvindo.Location = new System.Drawing.Point(27, 9);
            this.gbBemvindo.Name = "gbBemvindo";
            this.gbBemvindo.Size = new System.Drawing.Size(1100, 593);
            this.gbBemvindo.TabIndex = 15;
            this.gbBemvindo.TabStop = false;
            this.gbBemvindo.Enter += new System.EventHandler(this.gbBemvindo_Enter);
            // 
            // frmBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1216, 631);
            this.Controls.Add(this.gbBemvindo);
            this.Name = "frmBV";
            this.Text = "Bem - Vindo";
            this.Load += new System.EventHandler(this.frmBV_Load);
            this.Validated += new System.EventHandler(this.frmBV_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.versenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBemvindo.ResumeLayout(false);
            this.gbBemvindo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpfcnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button cCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox versenha;
        private System.Windows.Forms.ComboBox cbPFPJ;
        private System.Windows.Forms.GroupBox gbBemvindo;
    }
}