
namespace Definição_do_objetivo_do_sistema
{
    partial class cadastrada
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
            this.button1 = new System.Windows.Forms.Button();
            this.dGImoveisCadastrados = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGImoveisCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(314, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CASAS CADASTRADAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(43, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "DETALHES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGImoveisCadastrados
            // 
            this.dGImoveisCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGImoveisCadastrados.Location = new System.Drawing.Point(345, 192);
            this.dGImoveisCadastrados.Name = "dGImoveisCadastrados";
            this.dGImoveisCadastrados.Size = new System.Drawing.Size(1114, 556);
            this.dGImoveisCadastrados.TabIndex = 10;
            this.dGImoveisCadastrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGImoveisCadastrados_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Definição_do_objetivo_do_sistema.Properties.Resources.SSSSS;
            this.pictureBox1.Location = new System.Drawing.Point(26, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 211);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cadastrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1489, 855);
            this.Controls.Add(this.dGImoveisCadastrados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "cadastrada";
            this.Text = "cadastrada";
            this.Load += new System.EventHandler(this.cadastrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGImoveisCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGImoveisCadastrados;
    }
}