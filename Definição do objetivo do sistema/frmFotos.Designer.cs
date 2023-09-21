
namespace Definição_do_objetivo_do_sistema
{
    partial class frmFotos
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Link = new System.Windows.Forms.TextBox();
            this.gbFotos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbFotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carregue seu Link";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Orange;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(94, 214);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(168, 35);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(425, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(853, 575);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Link
            // 
            this.Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link.Location = new System.Drawing.Point(39, 127);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(290, 26);
            this.Link.TabIndex = 4;
            // 
            // gbFotos
            // 
            this.gbFotos.Controls.Add(this.Link);
            this.gbFotos.Controls.Add(this.pictureBox);
            this.gbFotos.Controls.Add(this.btnAbrir);
            this.gbFotos.Controls.Add(this.label1);
            this.gbFotos.Location = new System.Drawing.Point(110, 11);
            this.gbFotos.Name = "gbFotos";
            this.gbFotos.Size = new System.Drawing.Size(1314, 612);
            this.gbFotos.TabIndex = 5;
            this.gbFotos.TabStop = false;
            this.gbFotos.Text = "groupBox1";
            // 
            // frmFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1472, 649);
            this.Controls.Add(this.gbFotos);
            this.Name = "frmFotos";
            this.Text = "Fotos";
            this.Load += new System.EventHandler(this.frmFotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbFotos.ResumeLayout(false);
            this.gbFotos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.GroupBox gbFotos;
    }
}