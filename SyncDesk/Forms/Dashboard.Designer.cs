namespace SyncDesk.SyncDesk.Forms
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSaldoAtual = new Label();
            label3 = new Label();
            lblSaida = new Label();
            label2 = new Label();
            lblEntradas = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblProximosHorarios = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(lblSaldoAtual);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblSaida);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblEntradas);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 21);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 88);
            panel1.TabIndex = 0;
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Location = new Point(134, 70);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new Size(49, 18);
            lblSaldoAtual.TabIndex = 5;
            lblSaldoAtual.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 4;
            label3.Text = "Saldo atual:";
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Location = new Point(134, 41);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(48, 18);
            lblSaida.TabIndex = 3;
            lblSaida.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 2;
            label2.Text = "Total de saídas: ";
            // 
            // lblEntradas
            // 
            lblEntradas.AutoSize = true;
            lblEntradas.Location = new Point(134, 10);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(48, 18);
            lblEntradas.TabIndex = 1;
            lblEntradas.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 0;
            label1.Text = "Total de entradas:";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblProximosHorarios);
            panel2.Location = new Point(298, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(84, 88);
            panel2.TabIndex = 6;
            // 
            // lblProximosHorarios
            // 
            lblProximosHorarios.AutoSize = true;
            lblProximosHorarios.Dock = DockStyle.Fill;
            lblProximosHorarios.Location = new Point(0, 0);
            lblProximosHorarios.Name = "lblProximosHorarios";
            lblProximosHorarios.Size = new Size(49, 18);
            lblProximosHorarios.TabIndex = 0;
            lblProximosHorarios.Text = "label4";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(864, 574);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Location = new Point(220, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(72, 88);
            panel4.TabIndex = 1;
            panel4.Visible = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Size = new Size(864, 574);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSaida;
        private Label label2;
        private Label lblEntradas;
        private Label label1;
        private Label lblSaldoAtual;
        private Label label3;
        private Panel panel2;
        private Label lblProximosHorarios;
        private Panel panel3;
        private Panel panel4;
    }
}
