
namespace Definição_do_objetivo_do_sistema
{
    partial class Detalhes
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
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnOutra = new System.Windows.Forms.Button();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(161, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes do imóvel";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(366, 494);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(95, 30);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(215, 494);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(95, 30);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnOutra
            // 
            this.btnOutra.Location = new System.Drawing.Point(254, 545);
            this.btnOutra.Name = "btnOutra";
            this.btnOutra.Size = new System.Drawing.Size(170, 29);
            this.btnOutra.TabIndex = 4;
            this.btnOutra.Text = "Outra casa";
            this.btnOutra.UseVisualStyleBackColor = true;
            this.btnOutra.Click += new System.EventHandler(this.btnOutra_Click);
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.btnOutra);
            this.gbDetalhes.Controls.Add(this.btnAnterior);
            this.gbDetalhes.Controls.Add(this.btnProximo);
            this.gbDetalhes.Controls.Add(this.pictureBox1);
            this.gbDetalhes.Controls.Add(this.label1);
            this.gbDetalhes.Location = new System.Drawing.Point(143, 42);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(657, 592);
            this.gbDetalhes.TabIndex = 5;
            this.gbDetalhes.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(91, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 374);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(860, 652);
            this.Controls.Add(this.gbDetalhes);
            this.Name = "Detalhes";
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Detalhes_Load);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnOutra;
        private System.Windows.Forms.GroupBox gbDetalhes;
    }
}