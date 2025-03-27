namespace SyncDesk.SyncDesk.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            panel1 = new Panel();
            Utilitários = new Label();
            lblusuarios = new Label();
            pictureUsuario = new PictureBox();
            label4 = new Label();
            lblsaida = new Label();
            pictureSaida = new PictureBox();
            lblentrada = new Label();
            pictureEntrada = new PictureBox();
            label3 = new Label();
            lblhorarios = new Label();
            pictureHorarios = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            lbldashboard = new Label();
            picturedashboard = new PictureBox();
            lblsair = new Label();
            picturesair = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panelContent = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHorarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturedashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturesair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 16);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(Utilitários);
            panel1.Controls.Add(lblusuarios);
            panel1.Controls.Add(pictureUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblsaida);
            panel1.Controls.Add(pictureSaida);
            panel1.Controls.Add(lblentrada);
            panel1.Controls.Add(pictureEntrada);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblhorarios);
            panel1.Controls.Add(pictureHorarios);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lbldashboard);
            panel1.Controls.Add(picturedashboard);
            panel1.Controls.Add(lblsair);
            panel1.Controls.Add(picturesair);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 675);
            panel1.TabIndex = 1;
            // 
            // Utilitários
            // 
            Utilitários.AutoSize = true;
            Utilitários.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Utilitários.ForeColor = Color.Transparent;
            Utilitários.Location = new Point(45, 163);
            Utilitários.Name = "Utilitários";
            Utilitários.Size = new Size(79, 19);
            Utilitários.TabIndex = 0;
            Utilitários.Text = "Utilitários";
            // 
            // lblusuarios
            // 
            lblusuarios.AutoSize = true;
            lblusuarios.Cursor = Cursors.Hand;
            lblusuarios.ForeColor = Color.Transparent;
            lblusuarios.Location = new Point(55, 565);
            lblusuarios.Name = "lblusuarios";
            lblusuarios.Size = new Size(60, 16);
            lblusuarios.TabIndex = 12;
            lblusuarios.Text = "Usuários";
            lblusuarios.Click += lblusuarios_Click;
            // 
            // pictureUsuario
            // 
            pictureUsuario.Cursor = Cursors.Hand;
            pictureUsuario.Image = (Image)resources.GetObject("pictureUsuario.Image");
            pictureUsuario.Location = new Point(12, 557);
            pictureUsuario.Name = "pictureUsuario";
            pictureUsuario.Size = new Size(37, 29);
            pictureUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUsuario.TabIndex = 11;
            pictureUsuario.TabStop = false;
            pictureUsuario.Click += pictureUsuario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(45, 512);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 10;
            label4.Text = "Usuários";
            // 
            // lblsaida
            // 
            lblsaida.AutoSize = true;
            lblsaida.Cursor = Cursors.Hand;
            lblsaida.ForeColor = Color.Transparent;
            lblsaida.Location = new Point(55, 456);
            lblsaida.Name = "lblsaida";
            lblsaida.Size = new Size(39, 16);
            lblsaida.TabIndex = 9;
            lblsaida.Text = "Saída";
            lblsaida.Click += lblsaida_Click;
            // 
            // pictureSaida
            // 
            pictureSaida.Cursor = Cursors.Hand;
            pictureSaida.Image = (Image)resources.GetObject("pictureSaida.Image");
            pictureSaida.Location = new Point(12, 447);
            pictureSaida.Name = "pictureSaida";
            pictureSaida.Size = new Size(37, 37);
            pictureSaida.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSaida.TabIndex = 0;
            pictureSaida.TabStop = false;
            pictureSaida.Click += pictureSaida_Click;
            // 
            // lblentrada
            // 
            lblentrada.AutoSize = true;
            lblentrada.Cursor = Cursors.Hand;
            lblentrada.ForeColor = Color.Transparent;
            lblentrada.Location = new Point(55, 416);
            lblentrada.Name = "lblentrada";
            lblentrada.Size = new Size(60, 16);
            lblentrada.TabIndex = 8;
            lblentrada.Text = "Entradas";
            lblentrada.Click += lblentrada_Click;
            // 
            // pictureEntrada
            // 
            pictureEntrada.Cursor = Cursors.Hand;
            pictureEntrada.Image = (Image)resources.GetObject("pictureEntrada.Image");
            pictureEntrada.Location = new Point(12, 406);
            pictureEntrada.Name = "pictureEntrada";
            pictureEntrada.Size = new Size(37, 35);
            pictureEntrada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureEntrada.TabIndex = 0;
            pictureEntrada.TabStop = false;
            pictureEntrada.Click += pictureEntrada_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(45, 354);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 7;
            label3.Text = "Financeiro";
            // 
            // lblhorarios
            // 
            lblhorarios.AutoSize = true;
            lblhorarios.Cursor = Cursors.Hand;
            lblhorarios.ForeColor = Color.Transparent;
            lblhorarios.Location = new Point(55, 300);
            lblhorarios.Name = "lblhorarios";
            lblhorarios.Size = new Size(59, 16);
            lblhorarios.TabIndex = 0;
            lblhorarios.Text = "Horários";
            lblhorarios.Click += lblhorarios_Click;
            // 
            // pictureHorarios
            // 
            pictureHorarios.Cursor = Cursors.Hand;
            pictureHorarios.Image = (Image)resources.GetObject("pictureHorarios.Image");
            pictureHorarios.Location = new Point(12, 291);
            pictureHorarios.Name = "pictureHorarios";
            pictureHorarios.Size = new Size(37, 34);
            pictureHorarios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHorarios.TabIndex = 6;
            pictureHorarios.TabStop = false;
            pictureHorarios.Click += pictureHorarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(55, 260);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 0;
            label2.Text = "Clientes";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 256);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lbldashboard
            // 
            lbldashboard.AutoSize = true;
            lbldashboard.Cursor = Cursors.Hand;
            lbldashboard.ForeColor = Color.Transparent;
            lbldashboard.Location = new Point(55, 223);
            lbldashboard.Name = "lbldashboard";
            lbldashboard.Size = new Size(71, 16);
            lbldashboard.TabIndex = 3;
            lbldashboard.Text = "Dashboard";
            lbldashboard.Click += lbldashboard_Click;
            // 
            // picturedashboard
            // 
            picturedashboard.Cursor = Cursors.Hand;
            picturedashboard.Image = (Image)resources.GetObject("picturedashboard.Image");
            picturedashboard.Location = new Point(12, 216);
            picturedashboard.Name = "picturedashboard";
            picturedashboard.Size = new Size(37, 34);
            picturedashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picturedashboard.TabIndex = 3;
            picturedashboard.TabStop = false;
            picturedashboard.Click += picturedashboard_Click;
            // 
            // lblsair
            // 
            lblsair.AutoSize = true;
            lblsair.Cursor = Cursors.Hand;
            lblsair.ForeColor = Color.Transparent;
            lblsair.Location = new Point(42, 755);
            lblsair.Name = "lblsair";
            lblsair.Size = new Size(46, 16);
            lblsair.TabIndex = 3;
            lblsair.Text = "Logout";
            lblsair.Click += lblsair_Click;
            // 
            // picturesair
            // 
            picturesair.Cursor = Cursors.Hand;
            picturesair.Image = (Image)resources.GetObject("picturesair.Image");
            picturesair.Location = new Point(12, 635);
            picturesair.Name = "picturesair";
            picturesair.Size = new Size(27, 31);
            picturesair.SizeMode = PictureBoxSizeMode.Zoom;
            picturesair.TabIndex = 4;
            picturesair.TabStop = false;
            picturesair.Click += picturesair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(173, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 43);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(983, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(179, 49);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(977, 595);
            panelContent.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(173, 650);
            panel3.Name = "panel3";
            panel3.Size = new Size(983, 25);
            panel3.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 675);
            Controls.Add(panel3);
            Controls.Add(panelContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHorarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturedashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturesair).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox picturesair;
        private Label lblsair;
        private Label lbldashboard;
        private PictureBox picturedashboard;
        private Panel panelContent;
        private Label label2;
        private PictureBox pictureBox3;
        private Label lblhorarios;
        private PictureBox pictureHorarios;
        private PictureBox pictureEntrada;
        private Label label3;
        private Label lblentrada;
        private Label lblsaida;
        private PictureBox pictureSaida;
        private Label label4;
        private Label lblusuarios;
        private PictureBox pictureUsuario;
        private Panel panel3;
        private Label Utilitários;
    }
}