﻿
namespace Definição_do_objetivo_do_sistema
{
    partial class frmCPF
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
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbJuridico);
            this.gbTipo.Controls.Add(this.rbFisica);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.ForeColor = System.Drawing.Color.White;
            this.gbTipo.Location = new System.Drawing.Point(191, 130);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(577, 161);
            this.gbTipo.TabIndex = 31;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            this.gbTipo.Enter += new System.EventHandler(this.gbTipo_Enter);
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.ForeColor = System.Drawing.Color.White;
            this.rbJuridico.Location = new System.Drawing.Point(326, 64);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(217, 33);
            this.rbJuridico.TabIndex = 1;
            this.rbJuridico.Text = "Pessoa Jurídica";
            this.rbJuridico.UseVisualStyleBackColor = true;
            this.rbJuridico.CheckedChanged += new System.EventHandler(this.rbJuridico_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.ForeColor = System.Drawing.Color.White;
            this.rbFisica.Location = new System.Drawing.Point(85, 64);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(195, 33);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.Text = "Pessoa Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Orange;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.White;
            this.btnConfirma.Location = new System.Drawing.Point(361, 462);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(206, 67);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "CONFIRMAR";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // frmCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(947, 833);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.gbTipo);
            this.Name = "frmCPF";
            this.Text = "Form2";
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.Button btnConfirma;
    }
}