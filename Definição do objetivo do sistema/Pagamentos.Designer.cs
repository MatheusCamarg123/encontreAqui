
namespace Definição_do_objetivo_do_sistema
{
    partial class Pagamentos
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
            this.lblpagamentos = new System.Windows.Forms.Label();
            this.lblpix = new System.Windows.Forms.Label();
            this.lblcc = new System.Windows.Forms.Label();
            this.lblcd = new System.Windows.Forms.Label();
            this.lblboleto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.boletinho = new System.Windows.Forms.RadioButton();
            this.txtcartaonumero = new System.Windows.Forms.TextBox();
            this.lblnomecartao = new System.Windows.Forms.Label();
            this.lblnumerocartao = new System.Windows.Forms.Label();
            this.lblcvv = new System.Windows.Forms.Label();
            this.lblvencimento = new System.Windows.Forms.Label();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cbparcelas = new System.Windows.Forms.ComboBox();
            this.lblparcelas = new System.Windows.Forms.Label();
            this.btnconfirmado = new System.Windows.Forms.Button();
            this.mtvencimento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpagamentos
            // 
            this.lblpagamentos.AutoSize = true;
            this.lblpagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagamentos.ForeColor = System.Drawing.Color.White;
            this.lblpagamentos.Location = new System.Drawing.Point(275, 51);
            this.lblpagamentos.Name = "lblpagamentos";
            this.lblpagamentos.Size = new System.Drawing.Size(296, 33);
            this.lblpagamentos.TabIndex = 0;
            this.lblpagamentos.Text = "Forma de Pagamento";
            // 
            // lblpix
            // 
            this.lblpix.AutoSize = true;
            this.lblpix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpix.ForeColor = System.Drawing.Color.White;
            this.lblpix.Location = new System.Drawing.Point(167, 216);
            this.lblpix.Name = "lblpix";
            this.lblpix.Size = new System.Drawing.Size(35, 20);
            this.lblpix.TabIndex = 1;
            this.lblpix.Text = "PIX";
            // 
            // lblcc
            // 
            this.lblcc.AutoSize = true;
            this.lblcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcc.ForeColor = System.Drawing.Color.White;
            this.lblcc.Location = new System.Drawing.Point(159, 262);
            this.lblcc.Name = "lblcc";
            this.lblcc.Size = new System.Drawing.Size(138, 20);
            this.lblcc.TabIndex = 2;
            this.lblcc.Text = "Cartão de Credito ";
            // 
            // lblcd
            // 
            this.lblcd.AutoSize = true;
            this.lblcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcd.ForeColor = System.Drawing.Color.White;
            this.lblcd.Location = new System.Drawing.Point(167, 171);
            this.lblcd.Name = "lblcd";
            this.lblcd.Size = new System.Drawing.Size(130, 20);
            this.lblcd.TabIndex = 3;
            this.lblcd.Text = "Cartão de Debito";
            // 
            // lblboleto
            // 
            this.lblboleto.AutoSize = true;
            this.lblboleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblboleto.ForeColor = System.Drawing.Color.White;
            this.lblboleto.Location = new System.Drawing.Point(167, 124);
            this.lblboleto.Name = "lblboleto";
            this.lblboleto.Size = new System.Drawing.Size(55, 20);
            this.lblboleto.TabIndex = 4;
            this.lblboleto.Text = "Boleto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.boletinho);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(107, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(42, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 154);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // boletinho
            // 
            this.boletinho.AutoSize = true;
            this.boletinho.Location = new System.Drawing.Point(14, 21);
            this.boletinho.Name = "boletinho";
            this.boletinho.Size = new System.Drawing.Size(14, 13);
            this.boletinho.TabIndex = 17;
            this.boletinho.TabStop = true;
            this.boletinho.UseVisualStyleBackColor = true;
            this.boletinho.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // txtcartaonumero
            // 
            this.txtcartaonumero.Location = new System.Drawing.Point(492, 154);
            this.txtcartaonumero.Name = "txtcartaonumero";
            this.txtcartaonumero.Size = new System.Drawing.Size(274, 20);
            this.txtcartaonumero.TabIndex = 19;
            this.txtcartaonumero.UseWaitCursor = true;
            this.txtcartaonumero.Visible = false;
            // 
            // lblnomecartao
            // 
            this.lblnomecartao.AutoSize = true;
            this.lblnomecartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecartao.ForeColor = System.Drawing.Color.White;
            this.lblnomecartao.Location = new System.Drawing.Point(335, 125);
            this.lblnomecartao.Name = "lblnomecartao";
            this.lblnomecartao.Size = new System.Drawing.Size(49, 18);
            this.lblnomecartao.TabIndex = 21;
            this.lblnomecartao.Text = "Nome";
            this.lblnomecartao.Visible = false;
            this.lblnomecartao.Click += new System.EventHandler(this.lblnomecartao_Click);
            // 
            // lblnumerocartao
            // 
            this.lblnumerocartao.AutoSize = true;
            this.lblnumerocartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerocartao.ForeColor = System.Drawing.Color.White;
            this.lblnumerocartao.Location = new System.Drawing.Point(335, 153);
            this.lblnumerocartao.Name = "lblnumerocartao";
            this.lblnumerocartao.Size = new System.Drawing.Size(95, 18);
            this.lblnumerocartao.TabIndex = 22;
            this.lblnumerocartao.Text = "N° do Cartão";
            this.lblnumerocartao.Visible = false;
            // 
            // lblcvv
            // 
            this.lblcvv.AutoSize = true;
            this.lblcvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcvv.ForeColor = System.Drawing.Color.White;
            this.lblcvv.Location = new System.Drawing.Point(335, 185);
            this.lblcvv.Name = "lblcvv";
            this.lblcvv.Size = new System.Drawing.Size(151, 18);
            this.lblcvv.TabIndex = 23;
            this.lblcvv.Text = "Codigo de Segurança";
            this.lblcvv.Visible = false;
            // 
            // lblvencimento
            // 
            this.lblvencimento.AutoSize = true;
            this.lblvencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvencimento.ForeColor = System.Drawing.Color.White;
            this.lblvencimento.Location = new System.Drawing.Point(586, 188);
            this.lblvencimento.Name = "lblvencimento";
            this.lblvencimento.Size = new System.Drawing.Size(86, 18);
            this.lblvencimento.TabIndex = 24;
            this.lblvencimento.Text = "Vencimento";
            this.lblvencimento.Visible = false;
            // 
            // txtcvv
            // 
            this.txtcvv.Location = new System.Drawing.Point(492, 186);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(56, 20);
            this.txtcvv.TabIndex = 25;
            this.txtcvv.UseWaitCursor = true;
            this.txtcvv.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(492, 125);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(274, 20);
            this.txtnome.TabIndex = 27;
            this.txtnome.UseWaitCursor = true;
            this.txtnome.Visible = false;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // cbparcelas
            // 
            this.cbparcelas.FormattingEnabled = true;
            this.cbparcelas.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x"});
            this.cbparcelas.Location = new System.Drawing.Point(492, 218);
            this.cbparcelas.Name = "cbparcelas";
            this.cbparcelas.Size = new System.Drawing.Size(121, 21);
            this.cbparcelas.TabIndex = 28;
            this.cbparcelas.Visible = false;
            // 
            // lblparcelas
            // 
            this.lblparcelas.AutoSize = true;
            this.lblparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparcelas.ForeColor = System.Drawing.Color.White;
            this.lblparcelas.Location = new System.Drawing.Point(339, 217);
            this.lblparcelas.Name = "lblparcelas";
            this.lblparcelas.Size = new System.Drawing.Size(66, 18);
            this.lblparcelas.TabIndex = 29;
            this.lblparcelas.Text = "Parcelas";
            this.lblparcelas.Visible = false;
            // 
            // btnconfirmado
            // 
            this.btnconfirmado.BackColor = System.Drawing.Color.DarkOrange;
            this.btnconfirmado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmado.ForeColor = System.Drawing.Color.White;
            this.btnconfirmado.Location = new System.Drawing.Point(342, 354);
            this.btnconfirmado.Name = "btnconfirmado";
            this.btnconfirmado.Size = new System.Drawing.Size(144, 41);
            this.btnconfirmado.TabIndex = 30;
            this.btnconfirmado.Text = "Confirmar";
            this.btnconfirmado.UseVisualStyleBackColor = false;
            this.btnconfirmado.Click += new System.EventHandler(this.btnconfirmado_Click);
            // 
            // mtvencimento
            // 
            this.mtvencimento.Location = new System.Drawing.Point(678, 188);
            this.mtvencimento.Mask = "00/00";
            this.mtvencimento.Name = "mtvencimento";
            this.mtvencimento.Size = new System.Drawing.Size(55, 20);
            this.mtvencimento.TabIndex = 31;
            this.mtvencimento.ValidatingType = typeof(System.DateTime);
            this.mtvencimento.Visible = false;
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtvencimento);
            this.Controls.Add(this.btnconfirmado);
            this.Controls.Add(this.lblparcelas);
            this.Controls.Add(this.cbparcelas);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.lblvencimento);
            this.Controls.Add(this.lblcvv);
            this.Controls.Add(this.lblnumerocartao);
            this.Controls.Add(this.lblnomecartao);
            this.Controls.Add(this.txtcartaonumero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblboleto);
            this.Controls.Add(this.lblcd);
            this.Controls.Add(this.lblcc);
            this.Controls.Add(this.lblpix);
            this.Controls.Add(this.lblpagamentos);
            this.Name = "Pagamentos";
            this.Text = ",";
            this.Load += new System.EventHandler(this.Pagamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpagamentos;
        private System.Windows.Forms.Label lblpix;
        private System.Windows.Forms.Label lblcc;
        private System.Windows.Forms.Label lblcd;
        private System.Windows.Forms.Label lblboleto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton boletinho;
        private System.Windows.Forms.TextBox txtcartaonumero;
        private System.Windows.Forms.Label lblnomecartao;
        private System.Windows.Forms.Label lblnumerocartao;
        private System.Windows.Forms.Label lblcvv;
        private System.Windows.Forms.Label lblvencimento;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox cbparcelas;
        private System.Windows.Forms.Label lblparcelas;
        private System.Windows.Forms.Button btnconfirmado;
        private System.Windows.Forms.MaskedTextBox mtvencimento;
    }
}