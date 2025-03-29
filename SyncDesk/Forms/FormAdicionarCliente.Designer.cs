namespace SyncDesk.SyncDesk.Forms
{
    partial class FormAdicionarCliente
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
            textBoxNome = new TextBox();
            label2 = new Label();
            textBoxTelefone = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxEndereco = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnCancelar = new Button();
            btnadd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(84, 9);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(228, 26);
            textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(84, 41);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(142, 26);
            textBoxTelefone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(84, 79);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(178, 26);
            textBoxEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 6;
            label4.Text = "Endereço:";
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(84, 116);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(228, 26);
            textBoxEndereco.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 8;
            label5.Text = "Criado por:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.No;
            label6.Location = new Point(97, 160);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(257, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnadd
            // 
            btnadd.Cursor = Cursors.Hand;
            btnadd.Location = new Point(170, 216);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(81, 23);
            btnadd.TabIndex = 12;
            btnadd.Text = "Adicionar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // FormAdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 251);
            Controls.Add(btnadd);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxEndereco);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxTelefone);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAdicionarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Cliente";
            Load += FormAdicionarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxTelefone;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxEndereco;
        private Label label5;
        private Label label6;
        private Button btnCancelar;
        private Button btnadd;
    }
}