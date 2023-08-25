namespace Funcionario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Nome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            BtnCadastrar = new Button();
            BtnPesquisar = new Button();
            label4 = new Label();
            lblId = new Label();
            BtnLimpar = new Button();
            BtnAtualizar = new Button();
            BtnDeletar = new Button();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.BackColor = Color.Transparent;
            Nome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Nome.ForeColor = SystemColors.ControlLightLight;
            Nome.Location = new Point(89, 62);
            Nome.Name = "Nome";
            Nome.Size = new Size(54, 19);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(89, 140);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(89, 210);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(89, 279);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 3;
            label3.Text = "Endereço";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(89, 98);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(403, 22);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(89, 175);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(403, 22);
            txtEmail.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(89, 242);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(403, 22);
            txtCpf.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(89, 313);
            txtEndereco.MaxLength = 100;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(403, 22);
            txtEndereco.TabIndex = 4;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.FlatStyle = FlatStyle.System;
            BtnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastrar.Location = new Point(54, 476);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(105, 31);
            BtnCadastrar.TabIndex = 5;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.FlatStyle = FlatStyle.System;
            BtnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(199, 476);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(108, 31);
            BtnPesquisar.TabIndex = 6;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 19);
            label4.Name = "label4";
            label4.Size = new Size(148, 19);
            label4.TabIndex = 7;
            label4.Text = "ID FUNCIONÁRIO:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(172, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 19);
            lblId.TabIndex = 8;
            lblId.Text = "---";
            // 
            // BtnLimpar
            // 
            BtnLimpar.FlatStyle = FlatStyle.System;
            BtnLimpar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLimpar.Location = new Point(495, 476);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(100, 31);
            BtnLimpar.TabIndex = 9;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.FlatStyle = FlatStyle.System;
            BtnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAtualizar.Location = new Point(346, 476);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(106, 31);
            BtnAtualizar.TabIndex = 10;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnDeletar
            // 
            BtnDeletar.FlatStyle = FlatStyle.System;
            BtnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDeletar.Location = new Point(640, 476);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(100, 31);
            BtnDeletar.TabIndex = 11;
            BtnDeletar.Text = "Deletar";
            BtnDeletar.UseVisualStyleBackColor = true;
            BtnDeletar.Click += BtnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnLimpar);
            Controls.Add(lblId);
            Controls.Add(label4);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD C#";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtEndereco;
        private Button BtnCadastrar;
        private Button BtnPesquisar;
        private Label label4;
        private Label lblId;
        private Button BtnLimpar;
        private Button BtnAtualizar;
        private Button BtnDeletar;
    }
}