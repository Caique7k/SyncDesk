namespace SyncDesk.SyncDesk.Forms
{
    partial class FormAdicionarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarUsuario));
            label1 = new Label();
            txtBoxNome = new TextBox();
            label2 = new Label();
            txtBoxEmail = new TextBox();
            label3 = new Label();
            RbAdm = new RadioButton();
            RbUser = new RadioButton();
            label4 = new Label();
            txtBoxSenha = new TextBox();
            label5 = new Label();
            txtBoxConfirmaSenha = new TextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            checkBoxMostrarSenha = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(70, 7);
            txtBoxNome.Margin = new Padding(3, 4, 3, 4);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(212, 26);
            txtBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 46);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 2;
            label2.Text = "Email: ";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(70, 43);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(212, 26);
            txtBoxEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 89);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 4;
            label3.Text = "Tipo do usuário: ";
            // 
            // RbAdm
            // 
            RbAdm.AutoSize = true;
            RbAdm.Cursor = Cursors.Hand;
            RbAdm.Location = new Point(136, 87);
            RbAdm.Name = "RbAdm";
            RbAdm.Size = new Size(122, 22);
            RbAdm.TabIndex = 5;
            RbAdm.TabStop = true;
            RbAdm.Text = "Administrador";
            RbAdm.UseVisualStyleBackColor = true;
            // 
            // RbUser
            // 
            RbUser.AutoSize = true;
            RbUser.Cursor = Cursors.Hand;
            RbUser.Location = new Point(136, 115);
            RbUser.Name = "RbUser";
            RbUser.Size = new Size(131, 22);
            RbUser.TabIndex = 6;
            RbUser.TabStop = true;
            RbUser.Text = "Usuário comum";
            RbUser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 162);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 7;
            label4.Text = "Senha: ";
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(145, 159);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(137, 26);
            txtBoxSenha.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 194);
            label5.Name = "label5";
            label5.Size = new Size(132, 18);
            label5.TabIndex = 9;
            label5.Text = "Confirme a senha: ";
            // 
            // txtBoxConfirmaSenha
            // 
            txtBoxConfirmaSenha.Location = new Point(145, 191);
            txtBoxConfirmaSenha.Name = "txtBoxConfirmaSenha";
            txtBoxConfirmaSenha.Size = new Size(137, 26);
            txtBoxConfirmaSenha.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(12, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Location = new Point(188, 287);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(88, 23);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // checkBoxMostrarSenha
            // 
            checkBoxMostrarSenha.AutoSize = true;
            checkBoxMostrarSenha.Cursor = Cursors.Hand;
            checkBoxMostrarSenha.Location = new Point(145, 236);
            checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            checkBoxMostrarSenha.Size = new Size(124, 22);
            checkBoxMostrarSenha.TabIndex = 13;
            checkBoxMostrarSenha.Text = "Mostrar senha";
            checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            checkBoxMostrarSenha.CheckedChanged += checkBoxMostrarSenha_CheckedChanged;
            // 
            // FormAdicionarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 322);
            Controls.Add(checkBoxMostrarSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtBoxConfirmaSenha);
            Controls.Add(label5);
            Controls.Add(txtBoxSenha);
            Controls.Add(label4);
            Controls.Add(RbUser);
            Controls.Add(RbAdm);
            Controls.Add(label3);
            Controls.Add(txtBoxEmail);
            Controls.Add(label2);
            Controls.Add(txtBoxNome);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAdicionarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxNome;
        private Label label2;
        private TextBox txtBoxEmail;
        private Label label3;
        private RadioButton RbAdm;
        private RadioButton RbUser;
        private Label label4;
        private TextBox txtBoxSenha;
        private Label label5;
        private TextBox txtBoxConfirmaSenha;
        private Button btnCancelar;
        private Button btnCadastrar;
        private CheckBox checkBoxMostrarSenha;
    }
}