
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
            this.btnJuridica = new System.Windows.Forms.Button();
            this.btnFisica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJuridica
            // 
            this.btnJuridica.BackColor = System.Drawing.Color.White;
            this.btnJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuridica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJuridica.Location = new System.Drawing.Point(1335, 492);
            this.btnJuridica.Name = "btnJuridica";
            this.btnJuridica.Size = new System.Drawing.Size(162, 93);
            this.btnJuridica.TabIndex = 7;
            this.btnJuridica.Text = "Pessoa Jurídica";
            this.btnJuridica.UseVisualStyleBackColor = false;
            this.btnJuridica.Click += new System.EventHandler(this.btnJuridica_Click);
            // 
            // btnFisica
            // 
            this.btnFisica.BackColor = System.Drawing.Color.White;
            this.btnFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFisica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFisica.Location = new System.Drawing.Point(984, 492);
            this.btnFisica.Name = "btnFisica";
            this.btnFisica.Size = new System.Drawing.Size(170, 93);
            this.btnFisica.TabIndex = 6;
            this.btnFisica.Text = "Pessoa Fisíca";
            this.btnFisica.UseVisualStyleBackColor = false;
            this.btnFisica.Click += new System.EventHandler(this.btnFisica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(979, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 150);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sejam bem - vindos ao primeiro passo do seu sonho!\r\n\r\nAqui você encontra o que pr" +
    "ocura...\r\n \r\nVocê é;\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 240);
            this.label1.TabIndex = 4;
            this.label1.Text = "BEM - \r\nVINDOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(984, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 10);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Definição_do_objetivo_do_sistema.Properties.Resources.MicrosoftTeams_image__1__removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(94, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 384);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1721, 912);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnJuridica);
            this.Controls.Add(this.btnFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBV";
            this.Text = "Bem - Vindo";
            this.Load += new System.EventHandler(this.frmBV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJuridica;
        private System.Windows.Forms.Button btnFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}