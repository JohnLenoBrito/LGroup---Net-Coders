namespace SondaIT.ConceitosIniciais.UI.Windows.Modulos.Amigos
{
    partial class frmCadastrar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnTabela = new System.Windows.Forms.Button();
            this.btnTSQL = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnTransacional = new System.Windows.Forms.Button();
            this.btnAssincrono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(12, 136);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(123, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(12, 189);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(103, 20);
            this.dtpData.TabIndex = 8;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Selecione...",
            "Feminino",
            "Masculino"});
            this.cboSexo.Location = new System.Drawing.Point(12, 233);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(154, 21);
            this.cboSexo.TabIndex = 9;
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(306, 61);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(137, 23);
            this.btnTabela.TabIndex = 10;
            this.btnTabela.Text = "Cadastrar Tabela";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // btnTSQL
            // 
            this.btnTSQL.Location = new System.Drawing.Point(306, 90);
            this.btnTSQL.Name = "btnTSQL";
            this.btnTSQL.Size = new System.Drawing.Size(137, 23);
            this.btnTSQL.TabIndex = 11;
            this.btnTSQL.Text = "Cadastrar TSQL";
            this.btnTSQL.UseVisualStyleBackColor = true;
            this.btnTSQL.Click += new System.EventHandler(this.btnTSQL_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(306, 119);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(137, 23);
            this.btnProcedure.TabIndex = 12;
            this.btnProcedure.Text = "Cadastrar Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnTransacional
            // 
            this.btnTransacional.Location = new System.Drawing.Point(306, 148);
            this.btnTransacional.Name = "btnTransacional";
            this.btnTransacional.Size = new System.Drawing.Size(137, 23);
            this.btnTransacional.TabIndex = 13;
            this.btnTransacional.Text = "Cadastrar Transacional";
            this.btnTransacional.UseVisualStyleBackColor = true;
            this.btnTransacional.Click += new System.EventHandler(this.btnTransacional_Click);
            // 
            // btnAssincrono
            // 
            this.btnAssincrono.Location = new System.Drawing.Point(306, 177);
            this.btnAssincrono.Name = "btnAssincrono";
            this.btnAssincrono.Size = new System.Drawing.Size(137, 23);
            this.btnAssincrono.TabIndex = 14;
            this.btnAssincrono.Text = "Cadastrar Assincrono";
            this.btnAssincrono.UseVisualStyleBackColor = true;
            this.btnAssincrono.Click += new System.EventHandler(this.btnAssincrono_Click);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 268);
            this.Controls.Add(this.btnAssincrono);
            this.Controls.Add(this.btnTransacional);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnTSQL);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastrar";
            this.Text = "frmCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.Button btnTSQL;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnTransacional;
        private System.Windows.Forms.Button btnAssincrono;
    }
}