
namespace Definição_do_objetivo_do_sistema
{
    partial class FrmDadosCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblcCnfirmacao = new System.Windows.Forms.Label();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnPróximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.Location = new System.Drawing.Point(280, 127);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(164, 29);
            this.txtPrincipal.TabIndex = 1;
            this.txtPrincipal.TextChanged += new System.EventHandler(this.txtPrincipal_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(62, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail Principal";
            // 
            // lblcCnfirmacao
            // 
            this.lblcCnfirmacao.AutoSize = true;
            this.lblcCnfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcCnfirmacao.Location = new System.Drawing.Point(62, 183);
            this.lblcCnfirmacao.Name = "lblcCnfirmacao";
            this.lblcCnfirmacao.Size = new System.Drawing.Size(201, 24);
            this.lblcCnfirmacao.TabIndex = 4;
            this.lblcCnfirmacao.Text = "Confirmação do E-mail";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacao.Location = new System.Drawing.Point(280, 183);
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.Size = new System.Drawing.Size(164, 29);
            this.txtConfirmacao.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(65, 236);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(682, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Autorizo que me encaminhem mensagens relacionado ao mercado imobiliário no meu E-" +
    "mail.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnPróximo
            // 
            this.btnPróximo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPróximo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPróximo.Location = new System.Drawing.Point(681, 394);
            this.btnPróximo.Name = "btnPróximo";
            this.btnPróximo.Size = new System.Drawing.Size(107, 32);
            this.btnPróximo.TabIndex = 6;
            this.btnPróximo.Text = "Próximo";
            this.btnPróximo.UseVisualStyleBackColor = false;
            this.btnPróximo.Click += new System.EventHandler(this.btnPróximo_Click);
            // 
            // FrmDadosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPróximo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblcCnfirmacao);
            this.Controls.Add(this.txtConfirmacao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "FrmDadosCadastro";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblcCnfirmacao;
        private System.Windows.Forms.TextBox txtConfirmacao;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnPróximo;
    }
}