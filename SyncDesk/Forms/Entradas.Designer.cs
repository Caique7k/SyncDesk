namespace SyncDesk.SyncDesk.Forms
{
    partial class Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entradas));
            panel1 = new Panel();
            pictureBoxAdd = new PictureBox();
            pictureBoxDelete = new PictureBox();
            pictureBoxEdit = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxAdd);
            panel1.Controls.Add(pictureBoxDelete);
            panel1.Controls.Add(pictureBoxEdit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 77);
            panel1.TabIndex = 0;
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.Cursor = Cursors.Hand;
            pictureBoxAdd.Image = (Image)resources.GetObject("pictureBoxAdd.Image");
            pictureBoxAdd.Location = new Point(799, 24);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(24, 24);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAdd.TabIndex = 4;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            // 
            // pictureBoxDelete
            // 
            pictureBoxDelete.Cursor = Cursors.Hand;
            pictureBoxDelete.Image = (Image)resources.GetObject("pictureBoxDelete.Image");
            pictureBoxDelete.Location = new Point(840, 24);
            pictureBoxDelete.Name = "pictureBoxDelete";
            pictureBoxDelete.Size = new Size(24, 24);
            pictureBoxDelete.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDelete.TabIndex = 5;
            pictureBoxDelete.TabStop = false;
            pictureBoxDelete.Click += pictureBoxDelete_Click;
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.Cursor = Cursors.Hand;
            pictureBoxEdit.Image = (Image)resources.GetObject("pictureBoxEdit.Image");
            pictureBoxEdit.Location = new Point(881, 24);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(24, 24);
            pictureBoxEdit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEdit.TabIndex = 6;
            pictureBoxEdit.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 2;
            label1.Text = "Entradas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(911, 461);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            // 
            // Entradas
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Entradas";
            Size = new Size(911, 538);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBoxAdd;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxEdit;
    }
}
