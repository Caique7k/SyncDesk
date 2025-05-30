namespace SyncDesk.SyncDesk.Forms
{
    partial class FormEditarUsuario
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
            label1 = new Label();
            txtBoxEditNome = new TextBox();
            label2 = new Label();
            txtBoxEditEmail = new TextBox();
            label3 = new Label();
            RbAdmEdit = new RadioButton();
            RbUserEdit = new RadioButton();
            label4 = new Label();
            txtBoxEditSenha = new TextBox();
            label5 = new Label();
            txtBoxEditConfirmaSenha = new TextBox();
            checkBoxMostrarSenhaEdit = new CheckBox();
            btnCancelar = new Button();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txtBoxEditNome
            // 
            txtBoxEditNome.Location = new Point(70, 7);
            txtBoxEditNome.Margin = new Padding(3, 4, 3, 4);
            txtBoxEditNome.Name = "txtBoxEditNome";
            txtBoxEditNome.Size = new Size(212, 26);
            txtBoxEditNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 46);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 3;
            label2.Text = "Email: ";
            // 
            // txtBoxEditEmail
            // 
            txtBoxEditEmail.Location = new Point(70, 43);
            txtBoxEditEmail.Name = "txtBoxEditEmail";
            txtBoxEditEmail.Size = new Size(212, 26);
            txtBoxEditEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 89);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 5;
            label3.Text = "Tipo do usuário: ";
            // 
            // RbAdmEdit
            // 
            RbAdmEdit.AutoSize = true;
            RbAdmEdit.Cursor = Cursors.Hand;
            RbAdmEdit.Location = new Point(136, 87);
            RbAdmEdit.Name = "RbAdmEdit";
            RbAdmEdit.Size = new Size(122, 22);
            RbAdmEdit.TabIndex = 6;
            RbAdmEdit.TabStop = true;
            RbAdmEdit.Text = "Administrador";
            RbAdmEdit.UseVisualStyleBackColor = true;
            // 
            // RbUserEdit
            // 
            RbUserEdit.AutoSize = true;
            RbUserEdit.Cursor = Cursors.Hand;
            RbUserEdit.Location = new Point(136, 115);
            RbUserEdit.Name = "RbUserEdit";
            RbUserEdit.Size = new Size(131, 22);
            RbUserEdit.TabIndex = 7;
            RbUserEdit.TabStop = true;
            RbUserEdit.Text = "Usuário comum";
            RbUserEdit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 162);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 8;
            label4.Text = "Senha: ";
            // 
            // txtBoxEditSenha
            // 
            txtBoxEditSenha.Location = new Point(145, 159);
            txtBoxEditSenha.Name = "txtBoxEditSenha";
            txtBoxEditSenha.Size = new Size(137, 26);
            txtBoxEditSenha.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 194);
            label5.Name = "label5";
            label5.Size = new Size(132, 18);
            label5.TabIndex = 10;
            label5.Text = "Confirme a senha: ";
            // 
            // txtBoxEditConfirmaSenha
            // 
            txtBoxEditConfirmaSenha.Location = new Point(145, 191);
            txtBoxEditConfirmaSenha.Name = "txtBoxEditConfirmaSenha";
            txtBoxEditConfirmaSenha.Size = new Size(137, 26);
            txtBoxEditConfirmaSenha.TabIndex = 11;
            // 
            // checkBoxMostrarSenhaEdit
            // 
            checkBoxMostrarSenhaEdit.AutoSize = true;
            checkBoxMostrarSenhaEdit.Cursor = Cursors.Hand;
            checkBoxMostrarSenhaEdit.Location = new Point(145, 236);
            checkBoxMostrarSenhaEdit.Name = "checkBoxMostrarSenhaEdit";
            checkBoxMostrarSenhaEdit.Size = new Size(124, 22);
            checkBoxMostrarSenhaEdit.TabIndex = 14;
            checkBoxMostrarSenhaEdit.Text = "Mostrar senha";
            checkBoxMostrarSenhaEdit.UseVisualStyleBackColor = true;
            checkBoxMostrarSenhaEdit.CheckedChanged += checkBoxMostrarSenhaEdit_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(12, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(188, 287);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 322);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(checkBoxMostrarSenhaEdit);
            Controls.Add(txtBoxEditConfirmaSenha);
            Controls.Add(label5);
            Controls.Add(txtBoxEditSenha);
            Controls.Add(label4);
            Controls.Add(RbUserEdit);
            Controls.Add(RbAdmEdit);
            Controls.Add(label3);
            Controls.Add(txtBoxEditEmail);
            Controls.Add(label2);
            Controls.Add(txtBoxEditNome);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxEditNome;
        private Label label2;
        private TextBox txtBoxEditEmail;
        private Label label3;
        private RadioButton RbAdmEdit;
        private RadioButton RbUserEdit;
        private Label label4;
        private TextBox txtBoxEditSenha;
        private Label label5;
        private TextBox txtBoxEditConfirmaSenha;
        private CheckBox checkBoxMostrarSenhaEdit;
        private Button btnCancelar;
        private Button btnEditar;
    }
}