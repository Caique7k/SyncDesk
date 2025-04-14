namespace SyncDesk.SyncDesk.Forms
{
    partial class AdicionarHorarioForm
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBoxCliente = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            textBoxDesc = new TextBox();
            btnAdd = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 0;
            label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(82, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(315, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(82, 50);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(315, 27);
            comboBoxCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDesc);
            panel1.Location = new Point(12, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 175);
            panel1.TabIndex = 5;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Dock = DockStyle.Fill;
            textBoxDesc.Location = new Point(0, 0);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(385, 175);
            textBoxDesc.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(311, 313);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(311, 363);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 328);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 7;
            label4.Text = "Criado por: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 328);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // AdicionarHorarioForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 409);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(comboBoxCliente);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "AdicionarHorarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdicionarClienteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBoxCliente;
        private Label label3;
        private Panel panel1;
        private TextBox textBoxDesc;
        private Button btnAdd;
        private Button btnCancelar;
        private Label label4;
        private Label label5;
    }
}