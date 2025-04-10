namespace SyncDesk.SyncDesk.Forms
{
    partial class FormEditarCliente
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
            textBoxNomeEditar = new TextBox();
            label2 = new Label();
            textBoxTelefoneEditar = new MaskedTextBox();
            label3 = new Label();
            textBoxEmailEditar = new TextBox();
            label4 = new Label();
            textBoxEnderecoEditar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnEdit = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // textBoxNomeEditar
            // 
            textBoxNomeEditar.Location = new Point(84, 6);
            textBoxNomeEditar.Name = "textBoxNomeEditar";
            textBoxNomeEditar.Size = new Size(228, 26);
            textBoxNomeEditar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 3;
            label2.Text = "Telefone:";
            // 
            // textBoxTelefoneEditar
            // 
            textBoxTelefoneEditar.Location = new Point(84, 48);
            textBoxTelefoneEditar.Mask = "(00) 00000-0000";
            textBoxTelefoneEditar.Name = "textBoxTelefoneEditar";
            textBoxTelefoneEditar.Size = new Size(147, 26);
            textBoxTelefoneEditar.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 15;
            label3.Text = "Email:";
            // 
            // textBoxEmailEditar
            // 
            textBoxEmailEditar.Location = new Point(84, 89);
            textBoxEmailEditar.Name = "textBoxEmailEditar";
            textBoxEmailEditar.Size = new Size(178, 26);
            textBoxEmailEditar.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 17;
            label4.Text = "Endereço:";
            // 
            // textBoxEnderecoEditar
            // 
            textBoxEnderecoEditar.Location = new Point(84, 128);
            textBoxEnderecoEditar.Name = "textBoxEnderecoEditar";
            textBoxEnderecoEditar.Size = new Size(228, 26);
            textBoxEnderecoEditar.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 19;
            label5.Text = "Criado por:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.No;
            label6.Location = new Point(97, 168);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 20;
            label6.Text = "label6";
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(166, 194);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 23);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(253, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 224);
            Controls.Add(btnCancelar);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxEnderecoEditar);
            Controls.Add(label4);
            Controls.Add(textBoxEmailEditar);
            Controls.Add(label3);
            Controls.Add(textBoxTelefoneEditar);
            Controls.Add(label2);
            Controls.Add(textBoxNomeEditar);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar cliente";
            Load += FormEditarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNomeEditar;
        private Label label2;
        private MaskedTextBox textBoxTelefoneEditar;
        private Label label3;
        private TextBox textBoxEmailEditar;
        private Label label4;
        private TextBox textBoxEnderecoEditar;
        private Label label5;
        private Label label6;
        private Button btnEdit;
        private Button btnCancelar;
    }
}