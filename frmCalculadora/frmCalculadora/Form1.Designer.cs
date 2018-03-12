namespace frmCalculadora
{
    partial class frmCalculadora
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lstCores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.chkHora = new System.Windows.Forms.CheckBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.wbrBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(12, 13);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(85, 20);
            this.dtpData.TabIndex = 0;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(118, 13);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(85, 20);
            this.dtpHora.TabIndex = 1;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(12, 55);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(76, 44);
            this.txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(145, 55);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(76, 44);
            this.txtValor2.TabIndex = 3;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(105, 68);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(35, 13);
            this.lblOperacao.TabIndex = 4;
            this.lblOperacao.Text = "label1";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(261, 55);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(76, 44);
            this.txtResultado.TabIndex = 5;
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(13, 119);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 59);
            this.btnAdicao.TabIndex = 6;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(146, 119);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 59);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(262, 119);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 59);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(377, 55);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 123);
            this.btnMultiplicacao.TabIndex = 9;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // btnCe
            // 
            this.btnCe.Location = new System.Drawing.Point(13, 208);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(75, 23);
            this.btnCe.TabIndex = 11;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(146, 208);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lstCores
            // 
            this.lstCores.FormattingEnabled = true;
            this.lstCores.Location = new System.Drawing.Point(13, 257);
            this.lstCores.Name = "lstCores";
            this.lstCores.Size = new System.Drawing.Size(84, 30);
            this.lstCores.TabIndex = 13;
            this.lstCores.SelectedIndexChanged += new System.EventHandler(this.lstCores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cor de Fundo:";
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(262, 212);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(77, 17);
            this.chkData.TabIndex = 15;
            this.chkData.Text = "Exibir Data";
            this.chkData.UseVisualStyleBackColor = true;
            this.chkData.CheckedChanged += new System.EventHandler(this.chkData_CheckedChanged);
            // 
            // chkHora
            // 
            this.chkHora.AutoSize = true;
            this.chkHora.Location = new System.Drawing.Point(262, 247);
            this.chkHora.Name = "chkHora";
            this.chkHora.Size = new System.Drawing.Size(77, 17);
            this.chkHora.TabIndex = 16;
            this.chkHora.Text = "Exibir Hora";
            this.chkHora.UseVisualStyleBackColor = true;
            this.chkHora.CheckedChanged += new System.EventHandler(this.chkHora_CheckedChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(16, 303);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(323, 20);
            this.txtEndereco.TabIndex = 17;
            this.txtEndereco.Text = "http://";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(346, 303);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 18;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // wbrBrowser
            // 
            this.wbrBrowser.Location = new System.Drawing.Point(16, 339);
            this.wbrBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrBrowser.Name = "wbrBrowser";
            this.wbrBrowser.Size = new System.Drawing.Size(405, 248);
            this.wbrBrowser.TabIndex = 19;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 599);
            this.Controls.Add(this.wbrBrowser);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.chkHora);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCores);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpData);
            this.Name = "frmCalculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lstCores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.CheckBox chkHora;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.WebBrowser wbrBrowser;
    }
}

