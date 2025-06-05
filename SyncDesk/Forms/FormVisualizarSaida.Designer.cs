namespace SyncDesk.SyncDesk.Forms
{
    partial class FormVisualizarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizarSaida));
            label1 = new Label();
            txtBoxValor = new TextBox();
            label2 = new Label();
            F = new Label();
            txtBoxDescricao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            txtBoxData = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 1;
            label1.Text = "Valor da saída: ";
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(133, 30);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.ReadOnly = true;
            txtBoxValor.Size = new Size(139, 26);
            txtBoxValor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 7;
            label2.Text = "Data da saída: ";
            // 
            // F
            // 
            F.AutoSize = true;
            F.Location = new Point(12, 127);
            F.Name = "F";
            F.Size = new Size(74, 18);
            F.TabIndex = 8;
            F.Text = "Descrição";
            // 
            // txtBoxDescricao
            // 
            txtBoxDescricao.Location = new Point(12, 166);
            txtBoxDescricao.Multiline = true;
            txtBoxDescricao.Name = "txtBoxDescricao";
            txtBoxDescricao.ReadOnly = true;
            txtBoxDescricao.Size = new Size(260, 188);
            txtBoxDescricao.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 378);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 10;
            label3.Text = "Criado por: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 378);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(199, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Sair";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtBoxData
            // 
            txtBoxData.Location = new Point(133, 77);
            txtBoxData.Name = "txtBoxData";
            txtBoxData.ReadOnly = true;
            txtBoxData.Size = new Size(139, 26);
            txtBoxData.TabIndex = 13;
            // 
            // FormVisualizarSaida
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 453);
            Controls.Add(txtBoxData);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxDescricao);
            Controls.Add(F);
            Controls.Add(label2);
            Controls.Add(txtBoxValor);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormVisualizarSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Saida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxValor;
        private Label label2;
        private Label F;
        private TextBox txtBoxDescricao;
        private Label label3;
        private Label label4;
        private Button btnCancelar;
        private TextBox txtBoxData;
    }
}