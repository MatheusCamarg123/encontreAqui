
namespace Definição_do_objetivo_do_sistema
{
    partial class frmJuridico
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
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.Purple;
            this.lblCNPJ.Location = new System.Drawing.Point(280, 100);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(183, 29);
            this.lblCNPJ.TabIndex = 0;
            this.lblCNPJ.Text = "Informar CNPJ";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCNPJ.Location = new System.Drawing.Point(268, 180);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(205, 31);
            this.mtbCNPJ.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(-48, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1911, 10);
            this.panel1.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Purple;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(300, 340);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(163, 50);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(622, 392);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(58, 24);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Name = "frmJuridico";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmJuridico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnProximo;
    }
}