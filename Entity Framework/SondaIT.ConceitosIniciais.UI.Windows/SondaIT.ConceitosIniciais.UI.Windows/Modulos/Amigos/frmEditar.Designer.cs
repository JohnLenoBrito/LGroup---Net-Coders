namespace SondaIT.ConceitosIniciais.UI.Windows.Modulos.Amigos
{
    partial class frmEditar
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
            this.btnAssincrono = new System.Windows.Forms.Button();
            this.btnTransacional = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnTSQL = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssincrono
            // 
            this.btnAssincrono.Location = new System.Drawing.Point(353, 224);
            this.btnAssincrono.Name = "btnAssincrono";
            this.btnAssincrono.Size = new System.Drawing.Size(137, 23);
            this.btnAssincrono.TabIndex = 29;
            this.btnAssincrono.Text = "Editar Assincrono";
            this.btnAssincrono.UseVisualStyleBackColor = true;
            // 
            // btnTransacional
            // 
            this.btnTransacional.Location = new System.Drawing.Point(353, 195);
            this.btnTransacional.Name = "btnTransacional";
            this.btnTransacional.Size = new System.Drawing.Size(137, 23);
            this.btnTransacional.TabIndex = 28;
            this.btnTransacional.Text = "Editar Transacional";
            this.btnTransacional.UseVisualStyleBackColor = true;
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(353, 166);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(137, 23);
            this.btnProcedure.TabIndex = 27;
            this.btnProcedure.Text = "Editar Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            // 
            // btnTSQL
            // 
            this.btnTSQL.Location = new System.Drawing.Point(353, 137);
            this.btnTSQL.Name = "btnTSQL";
            this.btnTSQL.Size = new System.Drawing.Size(137, 23);
            this.btnTSQL.TabIndex = 26;
            this.btnTSQL.Text = "Editar TSQL";
            this.btnTSQL.UseVisualStyleBackColor = true;
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(353, 108);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(137, 23);
            this.btnTabela.TabIndex = 25;
            this.btnTabela.Text = "Editar Tabela";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Selecione...",
            "Feminino",
            "Masculino"});
            this.cboSexo.Location = new System.Drawing.Point(59, 280);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(154, 21);
            this.cboSexo.TabIndex = 24;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(59, 236);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(103, 20);
            this.dtpData.TabIndex = 23;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(59, 183);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(144, 20);
            this.mskTelefone.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 371);
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
            this.Name = "frmEditar";
            this.Text = "frmEditar";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssincrono;
        private System.Windows.Forms.Button btnTransacional;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnTSQL;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}