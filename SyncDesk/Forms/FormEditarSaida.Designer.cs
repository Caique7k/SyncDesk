namespace SyncDesk.SyncDesk.Forms
{
    partial class FormEditarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarSaida));
            label1 = new Label();
            txtBoxValorEdit = new TextBox();
            label2 = new Label();
            dateTimePickerEdit = new DateTimePicker();
            F = new Label();
            txtBoxDescricaoEdit = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 2;
            label1.Text = "Valor da saída: ";
            // 
            // txtBoxValorEdit
            // 
            txtBoxValorEdit.Location = new Point(133, 30);
            txtBoxValorEdit.Name = "txtBoxValorEdit";
            txtBoxValorEdit.Size = new Size(139, 26);
            txtBoxValorEdit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 8;
            label2.Text = "Data da saída: ";
            // 
            // dateTimePickerEdit
            // 
            dateTimePickerEdit.Location = new Point(133, 74);
            dateTimePickerEdit.Name = "dateTimePickerEdit";
            dateTimePickerEdit.Size = new Size(139, 26);
            dateTimePickerEdit.TabIndex = 9;
            // 
            // F
            // 
            F.AutoSize = true;
            F.Location = new Point(12, 127);
            F.Name = "F";
            F.Size = new Size(74, 18);
            F.TabIndex = 10;
            F.Text = "Descrição";
            // 
            // txtBoxDescricaoEdit
            // 
            txtBoxDescricaoEdit.Location = new Point(12, 166);
            txtBoxDescricaoEdit.Multiline = true;
            txtBoxDescricaoEdit.Name = "txtBoxDescricaoEdit";
            txtBoxDescricaoEdit.Size = new Size(260, 188);
            txtBoxDescricaoEdit.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 378);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 12;
            label3.Text = "Criado por: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 378);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(11, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(197, 418);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormEditarSaida
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 453);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxDescricaoEdit);
            Controls.Add(F);
            Controls.Add(dateTimePickerEdit);
            Controls.Add(label2);
            Controls.Add(txtBoxValorEdit);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormEditarSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Saida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxValorEdit;
        private Label label2;
        private DateTimePicker dateTimePickerEdit;
        private Label F;
        private TextBox txtBoxDescricaoEdit;
        private Label label3;
        private Label label4;
        private Button btnCancelar;
        private Button btnEditar;
    }
}