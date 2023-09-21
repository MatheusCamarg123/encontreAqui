
namespace Definição_do_objetivo_do_sistema
{
    partial class Cadastro_Detalhes
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblPonto = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBai = new System.Windows.Forms.TextBox();
            this.txtMet = new System.Windows.Forms.TextBox();
            this.txtPont = new System.Windows.Forms.TextBox();
            this.txtEst = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.mtCep = new System.Windows.Forms.MaskedTextBox();
            this.gbDetalhe = new System.Windows.Forms.GroupBox();
            this.gbBanheiro.SuspendLayout();
            this.gbQuarto.SuspendLayout();
            this.gbVagas.SuspendLayout();
            this.gbDetalhe.SuspendLayout();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.txtBanheiro = new System.Windows.Forms.TextBox();
            this.txtVaga = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(388, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 38);
            this.textBox1.TabIndex = 61;
            this.textBox1.Text = "Características do imóvel";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Orange;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastro.Location = new System.Drawing.Point(378, 455);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(272, 41);
            this.btnCadastro.TabIndex = 11;
            this.btnCadastro.Text = "Cadastrar ";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // gbBanheiro
            // 
            this.gbBanheiro.BackColor = System.Drawing.Color.Indigo;
            this.gbBanheiro.Controls.Add(this.radioButton4);
            this.gbBanheiro.Controls.Add(this.radioButton5);
            this.gbBanheiro.Controls.Add(this.radioButton6);
            this.gbBanheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBanheiro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbBanheiro.Location = new System.Drawing.Point(398, 118);
            this.gbBanheiro.Name = "gbBanheiro";
            this.gbBanheiro.Size = new System.Drawing.Size(291, 74);
            this.gbBanheiro.TabIndex = 35;
            this.gbBanheiro.TabStop = false;
            this.gbBanheiro.Text = "Número de banheiros";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(198, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 22);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "3+";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(107, 29);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(35, 22);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 29);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(35, 22);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "1";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // gbQuarto
            // 
            this.gbQuarto.BackColor = System.Drawing.Color.Indigo;
            this.gbQuarto.Controls.Add(this.radioButton3);
            this.gbQuarto.Controls.Add(this.radioButton2);
            this.gbQuarto.Controls.Add(this.radioButton1);
            this.gbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuarto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbQuarto.Location = new System.Drawing.Point(41, 118);
            this.gbQuarto.Name = "gbQuarto";
            this.gbQuarto.Size = new System.Drawing.Size(291, 74);
            this.gbQuarto.TabIndex = 34;
            this.gbQuarto.TabStop = false;
            this.gbQuarto.Text = "Número de quartos";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(198, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3+";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbVagas
            // 
            this.gbVagas.BackColor = System.Drawing.Color.Indigo;
            this.gbVagas.Controls.Add(this.radioButton7);
            this.gbVagas.Controls.Add(this.radioButton8);
            this.gbVagas.Controls.Add(this.radioButton9);
            this.gbVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVagas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbVagas.Location = new System.Drawing.Point(742, 118);
            this.gbVagas.Name = "gbVagas";
            this.gbVagas.Size = new System.Drawing.Size(291, 74);
            this.gbVagas.TabIndex = 36;
            this.gbVagas.TabStop = false;
            this.gbVagas.Text = "Vagas de carro";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(198, 29);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(45, 22);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "3+";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(107, 29);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(35, 22);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "2";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 29);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(35, 22);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "1";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // txtReg
            // 
            this.txtReg.BackColor = System.Drawing.Color.SeaShell;
            this.txtReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtReg.Location = new System.Drawing.Point(615, 164);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(141, 29);
            this.txtReg.TabIndex = 4;
            this.txtReg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegiao.Location = new System.Drawing.Point(406, 221);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(70, 24);
            this.lblRegiao.TabIndex = 63;
            this.lblRegiao.Text = "Região";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBairro.Location = new System.Drawing.Point(415, 377);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 24);
            this.lblBairro.TabIndex = 64;
            this.lblBairro.Text = "Bairro";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMetros.Location = new System.Drawing.Point(325, 351);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(166, 24);
            this.lblMetros.TabIndex = 65;
            this.lblMetros.Text = "Metros Quadrados";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCep.Location = new System.Drawing.Point(425, 325);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(48, 24);
            this.lblCep.TabIndex = 66;
            this.lblCep.Text = "CEP";
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPonto.Location = new System.Drawing.Point(311, 296);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(182, 24);
            this.lblPonto.TabIndex = 67;
            this.lblPonto.Text = "Ponto de Referência";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(406, 272);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 68;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCidade.Location = new System.Drawing.Point(407, 246);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(70, 24);
            this.lblCidade.TabIndex = 69;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBai
            // 
            this.txtBai.BackColor = System.Drawing.Color.SeaShell;
            this.txtBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBai.Location = new System.Drawing.Point(612, 469);
            this.txtBai.Name = "txtBai";
            this.txtBai.Size = new System.Drawing.Size(141, 29);
            this.txtBai.TabIndex = 10;
            // 
            // txtMet
            // 
            this.txtMet.BackColor = System.Drawing.Color.SeaShell;
            this.txtMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMet.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMet.Location = new System.Drawing.Point(615, 416);
            this.txtMet.Name = "txtMet";
            this.txtMet.Size = new System.Drawing.Size(141, 29);
            this.txtMet.TabIndex = 9;
            // 
            // txtPont
            // 
            this.txtPont.BackColor = System.Drawing.Color.SeaShell;
            this.txtPont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPont.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPont.Location = new System.Drawing.Point(615, 312);
            this.txtPont.Name = "txtPont";
            this.txtPont.Size = new System.Drawing.Size(141, 29);
            this.txtPont.TabIndex = 7;
            // 
            // txtEst
            // 
            this.txtEst.BackColor = System.Drawing.Color.SeaShell;
            this.txtEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEst.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEst.Location = new System.Drawing.Point(615, 261);
            this.txtEst.Name = "txtEst";
            this.txtEst.Size = new System.Drawing.Size(141, 29);
            this.txtEst.TabIndex = 6;
            this.txtEst.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtCid
            // 
            this.txtCid.BackColor = System.Drawing.Color.SeaShell;
            this.txtCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCid.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCid.Location = new System.Drawing.Point(615, 214);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(141, 29);
            this.txtCid.TabIndex = 5;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.SeaShell;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCep.Location = new System.Drawing.Point(615, 366);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(141, 29);
            this.txtCep.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(537, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 31);
            this.label4.TabIndex = 88;
            this.label4.Text = "Cadastre seu imóvel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(292, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Número de quartos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(572, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Número de banheiros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(935, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 94;
            this.label3.Text = "Vagas";
            // 
            // txtQuarto
            // 
            this.txtQuarto.BackColor = System.Drawing.Color.SeaShell;
            this.txtQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtQuarto.Location = new System.Drawing.Point(307, 90);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(141, 29);
            this.txtQuarto.TabIndex = 1;
            // 
            // txtBanheiro
            // 
            this.txtBanheiro.BackColor = System.Drawing.Color.SeaShell;
            this.txtBanheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanheiro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBanheiro.Location = new System.Drawing.Point(596, 90);
            this.txtBanheiro.Name = "txtBanheiro";
            this.txtBanheiro.Size = new System.Drawing.Size(141, 29);
            this.txtBanheiro.TabIndex = 2;
            // 
            // txtVaga
            // 
            this.txtVaga.BackColor = System.Drawing.Color.SeaShell;
            this.txtVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaga.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtVaga.Location = new System.Drawing.Point(888, 90);
            this.txtVaga.Name = "txtVaga";
            this.txtVaga.Size = new System.Drawing.Size(141, 29);
            this.txtVaga.TabIndex = 3;
            // this.txtVaga.TextChanged += new System.EventHandler(this.txtVaga_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Definição_do_objetivo_do_sistema.Properties.Resources.MicrosoftTeams_image__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-58, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 94);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.mtCep.BackColor = System.Drawing.Color.Orange;
            this.mtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCep.Location = new System.Drawing.Point(472, 325);
            this.mtCep.Mask = "000-0000";
            this.mtCep.Name = "mtCep";
            this.mtCep.Size = new System.Drawing.Size(141, 26);
            this.mtCep.TabIndex = 76;
            this.mtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // gbDetalhe
            // 
            this.gbDetalhe.Controls.Add(this.mtCep);
            this.gbDetalhe.Controls.Add(this.txtCid);
            this.gbDetalhe.Controls.Add(this.txtEst);
            this.gbDetalhe.Controls.Add(this.txtPont);
            this.gbDetalhe.Controls.Add(this.txtMet);
            this.gbDetalhe.Controls.Add(this.txtBai);
            this.gbDetalhe.Controls.Add(this.lblCidade);
            this.gbDetalhe.Controls.Add(this.lblEstado);
            this.gbDetalhe.Controls.Add(this.lblPonto);
            this.gbDetalhe.Controls.Add(this.lblCep);
            this.gbDetalhe.Controls.Add(this.lblMetros);
            this.gbDetalhe.Controls.Add(this.lblBairro);
            this.gbDetalhe.Controls.Add(this.lblRegiao);
            this.gbDetalhe.Controls.Add(this.txtReg);
            this.gbDetalhe.Controls.Add(this.gbVagas);
            this.gbDetalhe.Controls.Add(this.textBox1);
            this.gbDetalhe.Controls.Add(this.btnCadastro);
            this.gbDetalhe.Controls.Add(this.gbBanheiro);
            this.gbDetalhe.Controls.Add(this.gbQuarto);
            this.gbDetalhe.Location = new System.Drawing.Point(121, 49);
            this.gbDetalhe.Name = "gbDetalhe";
            this.gbDetalhe.Size = new System.Drawing.Size(1118, 557);
            this.gbDetalhe.TabIndex = 77;
            this.gbDetalhe.TabStop = false;
            this.gbDetalhe.Text = "groupBox1";
            // 
            // Cadastro_detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1365, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtVaga);
            this.Controls.Add(this.txtBanheiro);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtEst);
            this.Controls.Add(this.txtPont);
            this.Controls.Add(this.txtMet);
            this.Controls.Add(this.txtBai);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPonto);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRegiao);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Cadastro_Detalhes";
            this.Controls.Add(this.gbDetalhe);
            this.Name = "Cadastro_detalhes";
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Detalhes_Load);
            this.gbBanheiro.ResumeLayout(false);
            this.gbBanheiro.PerformLayout();
            this.gbQuarto.ResumeLayout(false);
            this.gbQuarto.PerformLayout();
            this.gbVagas.ResumeLayout(false);
            this.gbVagas.PerformLayout();
            this.gbDetalhe.ResumeLayout(false);
            this.gbDetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblPonto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBai;
        private System.Windows.Forms.TextBox txtMet;
        private System.Windows.Forms.TextBox txtPont;
        private System.Windows.Forms.TextBox txtEst;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.TextBox txtBanheiro;
        private System.Windows.Forms.TextBox txtVaga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtCep;
        private System.Windows.Forms.GroupBox gbDetalhe;
    }
}