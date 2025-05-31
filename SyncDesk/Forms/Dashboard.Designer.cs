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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblSaldoAtual);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblSaida);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblEntradas);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Size = new Size(864, 574);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSaida;
        private Label label2;
        private Label lblEntradas;
        private Label label1;
        private Label lblSaldoAtual;
        private Label label3;
    }
}
