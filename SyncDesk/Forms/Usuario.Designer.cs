namespace SyncDesk.SyncDesk.Forms
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            label1 = new Label();
            btnAddUsuario = new PictureBox();
            btnDeleteUsuario = new PictureBox();
            btnEditUsuario = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)btnAddUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditUsuario).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 2;
            label1.Text = "Usuários";
            label1.Click += label1_Click;
            // 
            // btnAddUsuario
            // 
            btnAddUsuario.AccessibleDescription = "Adicionar novo usuário";
            btnAddUsuario.Cursor = Cursors.Hand;
            btnAddUsuario.Image = (Image)resources.GetObject("btnAddUsuario.Image");
            btnAddUsuario.Location = new Point(823, 23);
            btnAddUsuario.Margin = new Padding(4);
            btnAddUsuario.Name = "btnAddUsuario";
            btnAddUsuario.Size = new Size(28, 28);
            btnAddUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddUsuario.TabIndex = 3;
            btnAddUsuario.TabStop = false;
            btnAddUsuario.Tag = "";
            btnAddUsuario.Click += btnAddUsuario_Click;
            // 
            // btnDeleteUsuario
            // 
            btnDeleteUsuario.Cursor = Cursors.Hand;
            btnDeleteUsuario.Image = (Image)resources.GetObject("btnDeleteUsuario.Image");
            btnDeleteUsuario.Location = new Point(863, 22);
            btnDeleteUsuario.Margin = new Padding(4);
            btnDeleteUsuario.Name = "btnDeleteUsuario";
            btnDeleteUsuario.Size = new Size(28, 28);
            btnDeleteUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnDeleteUsuario.TabIndex = 4;
            btnDeleteUsuario.TabStop = false;
            btnDeleteUsuario.Click += btnDeleteUsuario_Click;
            // 
            // btnEditUsuario
            // 
            btnEditUsuario.Cursor = Cursors.Hand;
            btnEditUsuario.Image = (Image)resources.GetObject("btnEditUsuario.Image");
            btnEditUsuario.Location = new Point(904, 22);
            btnEditUsuario.Margin = new Padding(4);
            btnEditUsuario.Name = "btnEditUsuario";
            btnEditUsuario.Size = new Size(28, 28);
            btnEditUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditUsuario.TabIndex = 5;
            btnEditUsuario.TabStop = false;
            btnEditUsuario.Click += btnEditUsuario_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditUsuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnDeleteUsuario);
            panel2.Controls.Add(btnAddUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 77);
            panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(955, 530);
            dataGridView1.TabIndex = 0;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Usuario";
            Size = new Size(955, 607);
            ((System.ComponentModel.ISupportInitialize)btnAddUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditUsuario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox btnAddUsuario;
        private PictureBox btnDeleteUsuario;
        private PictureBox btnEditUsuario;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}
