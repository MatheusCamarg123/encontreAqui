
namespace Definição_do_objetivo_do_sistema
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.pFisica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pJuridica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nós conte mas sobre você!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estou querendo anunciar meu Imóvel";
            // 
            // pFisica
            // 
            this.pFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFisica.Location = new System.Drawing.Point(82, 231);
            this.pFisica.Name = "pFisica";
            this.pFisica.Size = new System.Drawing.Size(166, 73);
            this.pFisica.TabIndex = 2;
            this.pFisica.Text = "Pessoa Fisíca";
            this.pFisica.UseVisualStyleBackColor = true;
            this.pFisica.Click += new System.EventHandler(this.pFisica_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(395, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 428);
            this.panel1.TabIndex = 3;
            // 
            // pJuridica
            // 
            this.pJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pJuridica.Location = new System.Drawing.Point(527, 231);
            this.pJuridica.Name = "pJuridica";
            this.pJuridica.Size = new System.Drawing.Size(171, 73);
            this.pJuridica.TabIndex = 4;
            this.pJuridica.Text = "Pessoa Jurídica";
            this.pJuridica.UseVisualStyleBackColor = true;
            this.pJuridica.Click += new System.EventHandler(this.pJuridica_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estou querendo encontrar Imóveis ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1349, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pJuridica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pFisica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pJuridica;
        private System.Windows.Forms.Label label3;
    }
}