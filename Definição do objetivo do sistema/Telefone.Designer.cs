
namespace Definição_do_objetivo_do_sistema
{
    partial class FormCadastro
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbW = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtCelular1 = new System.Windows.Forms.MaskedTextBox();
            this.mtCelular2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(228, 291);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(124, 35);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro Telefônico";
            // 
            // cbW
            // 
            this.cbW.AutoSize = true;
            this.cbW.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbW.Location = new System.Drawing.Point(294, 172);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(92, 17);
            this.cbW.TabIndex = 3;
            this.cbW.Text = "É WhatsApp?";
            this.cbW.UseVisualStyleBackColor = true;
            this.cbW.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular Principal*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celular 2";
            // 
            // mtTelefone
            // 
            this.mtTelefone.Location = new System.Drawing.Point(194, 112);
            this.mtTelefone.Mask = "(00) 0000-0000";
            this.mtTelefone.Name = "mtTelefone";
            this.mtTelefone.Size = new System.Drawing.Size(94, 20);
            this.mtTelefone.TabIndex = 12;
            this.mtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtTelefone_MaskInputRejected);
            // 
            // mtCelular1
            // 
            this.mtCelular1.Location = new System.Drawing.Point(194, 168);
            this.mtCelular1.Mask = "(00) 00000-0000";
            this.mtCelular1.Name = "mtCelular1";
            this.mtCelular1.Size = new System.Drawing.Size(94, 20);
            this.mtCelular1.TabIndex = 15;
            this.mtCelular1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtCelular1_MaskInputRejected);
            // 
            // mtCelular2
            // 
            this.mtCelular2.Location = new System.Drawing.Point(194, 219);
            this.mtCelular2.Mask = "(00) 00000-0000";
            this.mtCelular2.Name = "mtCelular2";
            this.mtCelular2.Size = new System.Drawing.Size(94, 20);
            this.mtCelular2.TabIndex = 16;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtCelular2);
            this.Controls.Add(this.mtCelular1);
            this.Controls.Add(this.mtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtTelefone;
        private System.Windows.Forms.MaskedTextBox mtCelular1;
        private System.Windows.Forms.MaskedTextBox mtCelular2;
    }
}