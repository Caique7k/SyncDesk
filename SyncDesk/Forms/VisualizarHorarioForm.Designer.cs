namespace SyncDesk.SyncDesk.Forms
{
    partial class VisualizarHorarioForm
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
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            textBoxDesc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnOk = new Button();
            txtData = new TextBox();
            txtCliente = new TextBox();
            txtHora = new TextBox();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
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
            panel1.Controls.Add(textBoxDesc);
            panel1.Location = new Point(12, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 175);
            panel1.TabIndex = 13;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Dock = DockStyle.Fill;
            textBoxDesc.Location = new Point(0, 0);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new Size(385, 175);
            textBoxDesc.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 363);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 363);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 14;
            label4.Text = "Criado por: ";
            // 
            // btnOk
            // 
            btnOk.Cursor = Cursors.Hand;
            btnOk.Location = new Point(316, 352);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 32);
            btnOk.TabIndex = 16;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(82, 10);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(315, 27);
            txtData.TabIndex = 17;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(82, 45);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(315, 27);
            txtCliente.TabIndex = 18;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(82, 91);
            txtHora.Name = "txtHora";
            txtHora.ReadOnly = true;
            txtHora.Size = new Size(50, 27);
            txtHora.TabIndex = 19;
            // 
            // VisualizarHorarioForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 396);
            Controls.Add(txtHora);
            Controls.Add(txtCliente);
            Controls.Add(txtData);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VisualizarHorarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização de horário";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Label label3;
        private Panel panel1;
        private TextBox textBoxDesc;
        private Label label5;
        private Label label4;
        private Button btnOk;
        private TextBox txtData;
        private TextBox txtCliente;
        private TextBox txtHora;
    }
}