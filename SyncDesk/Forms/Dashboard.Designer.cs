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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelEntradaSaida = new Panel();
            lblSaldoAtual = new Label();
            label3 = new Label();
            lblSaida = new Label();
            label2 = new Label();
            lblEntradas = new Label();
            label1 = new Label();
            panelProximoHorario = new Panel();
            lblProximosHorarios = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panelGrafico = new Panel();
            PanelConexao = new Panel();
            lblStatusConexao = new Label();
            panel9 = new Panel();
            PanelClientesTotal = new Panel();
            lblTotalClientes = new Label();
            label6 = new Label();
            panel7 = new Panel();
            panelClienteSemana = new Panel();
            lblClientesSemana = new Label();
            label4 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            timerStatusConexao = new System.Windows.Forms.Timer(components);
            timerAtualizacaoHorarios = new System.Windows.Forms.Timer(components);
            timerNotificacao = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            panelEntradaSaida.SuspendLayout();
            panelProximoHorario.SuspendLayout();
            panel3.SuspendLayout();
            PanelConexao.SuspendLayout();
            PanelClientesTotal.SuspendLayout();
            panelClienteSemana.SuspendLayout();
            SuspendLayout();
            // 
            // panelEntradaSaida
            // 
            panelEntradaSaida.AutoSize = true;
            panelEntradaSaida.BackColor = SystemColors.ControlLightLight;
            panelEntradaSaida.Controls.Add(lblSaldoAtual);
            panelEntradaSaida.Controls.Add(label3);
            panelEntradaSaida.Controls.Add(lblSaida);
            panelEntradaSaida.Controls.Add(label2);
            panelEntradaSaida.Controls.Add(lblEntradas);
            panelEntradaSaida.Controls.Add(label1);
            panelEntradaSaida.Location = new Point(27, 68);
            panelEntradaSaida.Margin = new Padding(5, 6, 5, 6);
            panelEntradaSaida.Name = "panelEntradaSaida";
            panelEntradaSaida.Size = new Size(185, 84);
            panelEntradaSaida.TabIndex = 0;
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Location = new Point(133, 60);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new Size(49, 18);
            lblSaldoAtual.TabIndex = 5;
            lblSaldoAtual.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 4;
            label3.Text = "Saldo atual:";
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Location = new Point(134, 37);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(48, 18);
            lblSaida.TabIndex = 3;
            lblSaida.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
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
            // panelProximoHorario
            // 
            panelProximoHorario.AutoSize = true;
            panelProximoHorario.BackColor = SystemColors.ControlLightLight;
            panelProximoHorario.Controls.Add(lblProximosHorarios);
            panelProximoHorario.Location = new Point(266, 67);
            panelProximoHorario.Name = "panelProximoHorario";
            panelProximoHorario.Size = new Size(161, 88);
            panelProximoHorario.TabIndex = 6;
            // 
            // lblProximosHorarios
            // 
            lblProximosHorarios.Dock = DockStyle.Fill;
            lblProximosHorarios.Location = new Point(0, 0);
            lblProximosHorarios.Name = "lblProximosHorarios";
            lblProximosHorarios.Size = new Size(161, 88);
            lblProximosHorarios.TabIndex = 0;
            lblProximosHorarios.Text = "label4";
            lblProximosHorarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panelGrafico);
            panel3.Controls.Add(PanelConexao);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(PanelClientesTotal);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panelClienteSemana);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panelProximoHorario);
            panel3.Controls.Add(panelEntradaSaida);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 574);
            panel3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 94);
            panel1.TabIndex = 0;
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(8, 261);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(939, 310);
            panelGrafico.TabIndex = 9;
            // 
            // PanelConexao
            // 
            PanelConexao.BackColor = SystemColors.ControlLightLight;
            PanelConexao.Controls.Add(lblStatusConexao);
            PanelConexao.Location = new Point(765, 77);
            PanelConexao.Name = "PanelConexao";
            PanelConexao.Size = new Size(154, 78);
            PanelConexao.TabIndex = 8;
            // 
            // lblStatusConexao
            // 
            lblStatusConexao.Location = new Point(7, 6);
            lblStatusConexao.Name = "lblStatusConexao";
            lblStatusConexao.Size = new Size(141, 65);
            lblStatusConexao.TabIndex = 7;
            lblStatusConexao.Text = "Status: Verificando...";
            lblStatusConexao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(947, 65);
            panel9.TabIndex = 2;
            panel9.Visible = false;
            // 
            // PanelClientesTotal
            // 
            PanelClientesTotal.AutoSize = true;
            PanelClientesTotal.BackColor = SystemColors.ControlLightLight;
            PanelClientesTotal.Controls.Add(lblTotalClientes);
            PanelClientesTotal.Controls.Add(label6);
            PanelClientesTotal.Location = new Point(466, 117);
            PanelClientesTotal.Name = "PanelClientesTotal";
            PanelClientesTotal.Size = new Size(278, 43);
            PanelClientesTotal.TabIndex = 2;
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Location = new Point(130, 25);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(48, 18);
            lblTotalClientes.TabIndex = 1;
            lblTotalClientes.Text = "label5";
            lblTotalClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 5);
            label6.Name = "label6";
            label6.Size = new Size(205, 18);
            label6.TabIndex = 0;
            label6.Text = "Clientes cadastrados no total:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Location = new Point(466, 111);
            panel7.Name = "panel7";
            panel7.Size = new Size(278, 10);
            panel7.TabIndex = 3;
            panel7.Visible = false;
            // 
            // panelClienteSemana
            // 
            panelClienteSemana.AutoSize = true;
            panelClienteSemana.BackColor = SystemColors.ControlLightLight;
            panelClienteSemana.Controls.Add(lblClientesSemana);
            panelClienteSemana.Controls.Add(label4);
            panelClienteSemana.Location = new Point(466, 67);
            panelClienteSemana.Name = "panelClienteSemana";
            panelClienteSemana.Size = new Size(278, 44);
            panelClienteSemana.TabIndex = 0;
            // 
            // lblClientesSemana
            // 
            lblClientesSemana.AutoSize = true;
            lblClientesSemana.Location = new Point(130, 20);
            lblClientesSemana.Name = "lblClientesSemana";
            lblClientesSemana.Size = new Size(48, 18);
            lblClientesSemana.TabIndex = 1;
            lblClientesSemana.Text = "label5";
            lblClientesSemana.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 1);
            label4.Name = "label4";
            label4.Size = new Size(275, 18);
            label4.TabIndex = 0;
            label4.Text = "Clientes cadastrados durante a semana:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Location = new Point(433, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(27, 88);
            panel5.TabIndex = 2;
            panel5.Visible = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(220, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(40, 88);
            panel4.TabIndex = 1;
            panel4.Visible = false;
            // 
            // timerStatusConexao
            // 
            timerStatusConexao.Enabled = true;
            timerStatusConexao.Interval = 10000;
            timerStatusConexao.Tick += timerStatusConexao_Tick;
            // 
            // timerAtualizacaoHorarios
            // 
            timerAtualizacaoHorarios.Interval = 6000;
            timerAtualizacaoHorarios.Tick += timerAtualizacaoHorarios_Tick;
            // 
            // timerNotificacao
            // 
            timerNotificacao.Interval = 6000;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Size = new Size(947, 574);
            panelEntradaSaida.ResumeLayout(false);
            panelEntradaSaida.PerformLayout();
            panelProximoHorario.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            PanelConexao.ResumeLayout(false);
            PanelClientesTotal.ResumeLayout(false);
            PanelClientesTotal.PerformLayout();
            panelClienteSemana.ResumeLayout(false);
            panelClienteSemana.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEntradaSaida;
        private Label lblSaida;
        private Label label2;
        private Label lblEntradas;
        private Label label1;
        private Label lblSaldoAtual;
        private Label label3;
        private Panel panelProximoHorario;
        private Label lblProximosHorarios;
        private Panel panel3;
        private Panel panel4;
        private Panel panelClienteSemana;
        private Label lblClientesSemana;
        private Label label4;
        private Panel panel5;
        private Panel PanelClientesTotal;
        private Label lblTotalClientes;
        private Label label6;
        private Panel panel7;
        private Panel panel9;
        private System.Windows.Forms.Timer timerStatusConexao;
        private Panel PanelConexao;
        private Label lblStatusConexao;
        private Panel panelGrafico;
        private Panel panel1;
        private System.Windows.Forms.Timer timerAtualizacaoHorarios;
        private System.Windows.Forms.Timer timerNotificacao;
        private NotifyIcon notifyIcon1;
    }
}
