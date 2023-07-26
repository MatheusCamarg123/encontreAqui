
namespace Definição_do_objetivo_do_sistema
{
    partial class Form2
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
            this.chkJuridico = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFisica = new System.Windows.Forms.CheckBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Blue;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(515, 285);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(136, 49);
            this.btnProximo.TabIndex = 25;
            this.btnProximo.Text = "Próximo ➡️ ";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(434, 227);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(278, 20);
            this.txtRG.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Informar RG:";
            // 
            // chkJuridico
            // 
            this.chkJuridico.AutoSize = true;
            this.chkJuridico.Checked = true;
            this.chkJuridico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJuridico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJuridico.Location = new System.Drawing.Point(642, 33);
            this.chkJuridico.Margin = new System.Windows.Forms.Padding(4);
            this.chkJuridico.Name = "chkJuridico";
            this.chkJuridico.Size = new System.Drawing.Size(113, 19);
            this.chkJuridico.TabIndex = 22;
            this.chkJuridico.Text = "Pessoa Jurídica";
            this.chkJuridico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo:";
            // 
            // chkFisica
            // 
            this.chkFisica.AutoSize = true;
            this.chkFisica.Checked = true;
            this.chkFisica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFisica.Location = new System.Drawing.Point(504, 33);
            this.chkFisica.Margin = new System.Windows.Forms.Padding(4);
            this.chkFisica.Name = "chkFisica";
            this.chkFisica.Size = new System.Drawing.Size(102, 19);
            this.chkFisica.TabIndex = 20;
            this.chkFisica.Text = "Pessoa Física";
            this.chkFisica.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(434, 142);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(278, 20);
            this.txtCPF.TabIndex = 19;
            this.txtCPF.Text = "t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Informar CPF/CNPJ:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 677);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkJuridico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFisica);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkJuridico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFisica;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
    }
}