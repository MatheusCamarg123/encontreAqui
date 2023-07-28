
namespace Definição_do_objetivo_do_sistema
{
    partial class PessoaFisica
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
            this.lbl8 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnunciar = new System.Windows.Forms.Label();
            this.lblAchar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccb1 = new System.Windows.Forms.RadioButton();
            this.ccb2 = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(270, 400);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(13, 20);
            this.lbl8.TabIndex = 29;
            this.lbl8.Text = ".";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Purple;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirma.Location = new System.Drawing.Point(274, 364);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(157, 33);
            this.btnConfirma.TabIndex = 28;
            this.btnConfirma.Text = "CONFIRMAR";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(284, 241);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(147, 20);
            this.txtLocalidade.TabIndex = 25;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(284, 202);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(284, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 22;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblAnunciar
            // 
            this.lblAnunciar.AutoSize = true;
            this.lblAnunciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnunciar.Location = new System.Drawing.Point(59, 317);
            this.lblAnunciar.Name = "lblAnunciar";
            this.lblAnunciar.Size = new System.Drawing.Size(211, 20);
            this.lblAnunciar.TabIndex = 21;
            this.lblAnunciar.Text = "Deseja Anunciar uma Casa?";
            // 
            // lblAchar
            // 
            this.lblAchar.AutoSize = true;
            this.lblAchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchar.Location = new System.Drawing.Point(59, 279);
            this.lblAchar.Name = "lblAchar";
            this.lblAchar.Size = new System.Drawing.Size(190, 20);
            this.lblAchar.TabIndex = 20;
            this.lblAchar.Text = "Deseja Achar uma Casa?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Localidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "Olá, para conhecermos um pouco mais do seu sonho, \r\nnos conte um pouco sobre você" +
    "!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ccb1
            // 
            this.ccb1.AutoSize = true;
            this.ccb1.Location = new System.Drawing.Point(284, 286);
            this.ccb1.Name = "ccb1";
            this.ccb1.Size = new System.Drawing.Size(14, 13);
            this.ccb1.TabIndex = 30;
            this.ccb1.TabStop = true;
            this.ccb1.UseVisualStyleBackColor = true;
            this.ccb1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ccb2
            // 
            this.ccb2.AutoSize = true;
            this.ccb2.Location = new System.Drawing.Point(284, 324);
            this.ccb2.Name = "ccb2";
            this.ccb2.Size = new System.Drawing.Size(14, 13);
            this.ccb2.TabIndex = 31;
            this.ccb2.TabStop = true;
            this.ccb2.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(284, 164);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(78, 20);
            this.txtData.TabIndex = 36;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // PessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.ccb2);
            this.Controls.Add(this.ccb1);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblAnunciar);
            this.Controls.Add(this.lblAchar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PessoaFisica";
            this.Text = "Pessoa Fisica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAnunciar;
        private System.Windows.Forms.Label lblAchar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ccb1;
        private System.Windows.Forms.RadioButton ccb2;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}