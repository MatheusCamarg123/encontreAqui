
namespace Definição_do_objetivo_do_sistema
{
    partial class frmCPF
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
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pessoaJuridica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pessoaFisica = new System.Windows.Forms.CheckBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Blue;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(533, 272);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(136, 49);
            this.btnProximo.TabIndex = 17;
            this.btnProximo.Text = "Próximo ➡️ ";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(452, 214);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(278, 20);
            this.txtRG.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Informar RG:";
            // 
            // pessoaJuridica
            // 
            this.pessoaJuridica.AutoSize = true;
            this.pessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaJuridica.Location = new System.Drawing.Point(660, 20);
            this.pessoaJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.pessoaJuridica.Name = "pessoaJuridica";
            this.pessoaJuridica.Size = new System.Drawing.Size(113, 19);
            this.pessoaJuridica.TabIndex = 14;
            this.pessoaJuridica.Text = "Pessoa Jurídica";
            this.pessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo:";
            // 
            // pessoaFisica
            // 
            this.pessoaFisica.AutoSize = true;
            this.pessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaFisica.Location = new System.Drawing.Point(522, 20);
            this.pessoaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.pessoaFisica.Name = "pessoaFisica";
            this.pessoaFisica.Size = new System.Drawing.Size(102, 19);
            this.pessoaFisica.TabIndex = 12;
            this.pessoaFisica.Text = "Pessoa Física";
            this.pessoaFisica.UseVisualStyleBackColor = true;
            this.pessoaFisica.CheckedChanged += new System.EventHandler(this.pessoaFisica_CheckedChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(452, 129);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(278, 20);
            this.txtCPF.TabIndex = 11;
            this.txtCPF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Informar CPF/CNPJ:";
            // 
            // frmCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 612);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pessoaJuridica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pessoaFisica);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Name = "frmCPF";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmCPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox pessoaJuridica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pessoaFisica;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
    }
}