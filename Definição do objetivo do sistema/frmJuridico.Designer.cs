
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.Orange;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.White;
            this.lblCNPJ.Location = new System.Drawing.Point(526, 134);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(221, 33);
            this.lblCNPJ.TabIndex = 0;
            this.lblCNPJ.Text = "Informar CNPJ";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCNPJ.Location = new System.Drawing.Point(532, 214);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(205, 31);
            this.mtbCNPJ.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(549, 357);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(189, 66);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1351, 771);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "frmJuridico";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmJuridico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.Button btnConfirmar;
    }
}