namespace SyncDesk.SyncDesk.Forms
{
    partial class FormEditarHorario
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
            dateTimePickerEdit = new DateTimePicker();
            label2 = new Label();
            comboBoxClienteEdit = new ComboBox();
            label6 = new Label();
            maskedTextBoxHorarioEdit = new MaskedTextBox();
            label3 = new Label();
            panel1 = new Panel();
            textBoxDescEdit = new TextBox();
            btnEdit = new Button();
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
            label1.TabIndex = 1;
            label1.Text = "Data:";
            // 
            // dateTimePickerEdit
            // 
            dateTimePickerEdit.Location = new Point(82, 12);
            dateTimePickerEdit.Name = "dateTimePickerEdit";
            dateTimePickerEdit.Size = new Size(309, 27);
            dateTimePickerEdit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // comboBoxClienteEdit
            // 
            comboBoxClienteEdit.FormattingEnabled = true;
            comboBoxClienteEdit.Location = new Point(82, 50);
            comboBoxClienteEdit.Name = "comboBoxClienteEdit";
            comboBoxClienteEdit.Size = new Size(315, 27);
            comboBoxClienteEdit.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 94);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 10;
            label6.Text = "Horário: ";
            // 
            // maskedTextBoxHorarioEdit
            // 
            maskedTextBoxHorarioEdit.Location = new Point(82, 91);
            maskedTextBoxHorarioEdit.Mask = "00:00";
            maskedTextBoxHorarioEdit.Name = "maskedTextBoxHorarioEdit";
            maskedTextBoxHorarioEdit.Size = new Size(49, 27);
            maskedTextBoxHorarioEdit.TabIndex = 11;
            maskedTextBoxHorarioEdit.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 12;
            label3.Text = "Descrição:";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDescEdit);
            panel1.Location = new Point(12, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 175);
            panel1.TabIndex = 13;
            // 
            // textBoxDescEdit
            // 
            textBoxDescEdit.Dock = DockStyle.Fill;
            textBoxDescEdit.Location = new Point(0, 0);
            textBoxDescEdit.Multiline = true;
            textBoxDescEdit.Name = "textBoxDescEdit";
            textBoxDescEdit.Size = new Size(385, 175);
            textBoxDescEdit.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(311, 351);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 34);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(311, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 391);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 16;
            label4.Text = "Criado por: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 391);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 17;
            label5.Text = "label5";
            // 
            // FormEditarHorario
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 437);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnEdit);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(maskedTextBoxHorarioEdit);
            Controls.Add(label6);
            Controls.Add(comboBoxClienteEdit);
            Controls.Add(label2);
            Controls.Add(dateTimePickerEdit);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormEditarHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarHorario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerEdit;
        private Label label2;
        private ComboBox comboBoxClienteEdit;
        private Label label6;
        private MaskedTextBox maskedTextBoxHorarioEdit;
        private Label label3;
        private Panel panel1;
        private TextBox textBoxDescEdit;
        private Button btnEdit;
        private Button btnCancelar;
        private Label label4;
        private Label label5;
    }
}