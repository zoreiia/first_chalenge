namespace first_chalenge
{
    partial class tcadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttoncadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonuser = new System.Windows.Forms.RadioButton();
            this.radioButtonadm = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsenha = new System.Windows.Forms.TextBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonalterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonexcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxsenha);
            this.panel1.Controls.Add(this.textBoxuser);
            this.panel1.Controls.Add(this.textBoxnome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 167);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cadastrar:";
            // 
            // buttoncadastrar
            // 
            this.buttoncadastrar.Location = new System.Drawing.Point(28, 7);
            this.buttoncadastrar.Name = "buttoncadastrar";
            this.buttoncadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttoncadastrar.TabIndex = 6;
            this.buttoncadastrar.Text = "Cadastrar";
            this.buttoncadastrar.UseVisualStyleBackColor = true;
            this.buttoncadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.radioButtonuser);
            this.groupBox1.Controls.Add(this.radioButtonadm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(203, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonuser
            // 
            this.radioButtonuser.AutoSize = true;
            this.radioButtonuser.Location = new System.Drawing.Point(26, 81);
            this.radioButtonuser.Name = "radioButtonuser";
            this.radioButtonuser.Size = new System.Drawing.Size(61, 17);
            this.radioButtonuser.TabIndex = 4;
            this.radioButtonuser.TabStop = true;
            this.radioButtonuser.Text = "Usuário";
            this.radioButtonuser.UseVisualStyleBackColor = true;
            // 
            // radioButtonadm
            // 
            this.radioButtonadm.AutoSize = true;
            this.radioButtonadm.Location = new System.Drawing.Point(26, 38);
            this.radioButtonadm.Name = "radioButtonadm";
            this.radioButtonadm.Size = new System.Drawing.Size(88, 17);
            this.radioButtonadm.TabIndex = 3;
            this.radioButtonadm.TabStop = true;
            this.radioButtonadm.Text = "Administrador";
            this.radioButtonadm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nível de acesso:";
            // 
            // textBoxsenha
            // 
            this.textBoxsenha.Location = new System.Drawing.Point(57, 85);
            this.textBoxsenha.Name = "textBoxsenha";
            this.textBoxsenha.Size = new System.Drawing.Size(140, 20);
            this.textBoxsenha.TabIndex = 5;
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(57, 59);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(140, 20);
            this.textBoxuser.TabIndex = 4;
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(57, 33);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(140, 20);
            this.textBoxnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // buttonalterar
            // 
            this.buttonalterar.Location = new System.Drawing.Point(126, 7);
            this.buttonalterar.Name = "buttonalterar";
            this.buttonalterar.Size = new System.Drawing.Size(75, 23);
            this.buttonalterar.TabIndex = 8;
            this.buttonalterar.Text = "Alterar";
            this.buttonalterar.UseVisualStyleBackColor = true;
            this.buttonalterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(371, 167);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonexcluir);
            this.panel2.Controls.Add(this.buttonalterar);
            this.panel2.Controls.Add(this.buttoncadastrar);
            this.panel2.Location = new System.Drawing.Point(1, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 47);
            this.panel2.TabIndex = 9;
            // 
            // buttonexcluir
            // 
            this.buttonexcluir.Location = new System.Drawing.Point(228, 7);
            this.buttonexcluir.Name = "buttonexcluir";
            this.buttonexcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonexcluir.TabIndex = 9;
            this.buttonexcluir.Text = "Excluir";
            this.buttonexcluir.UseVisualStyleBackColor = true;
            this.buttonexcluir.Click += new System.EventHandler(this.buttonexcluir_Click);
            // 
            // tcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 234);
            this.Controls.Add(this.panel1);
            this.Name = "tcadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsenha;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttoncadastrar;
        private System.Windows.Forms.RadioButton radioButtonuser;
        private System.Windows.Forms.RadioButton radioButtonadm;
        private System.Windows.Forms.Button buttonalterar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonexcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}