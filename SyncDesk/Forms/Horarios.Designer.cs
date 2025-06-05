namespace SyncDesk.SyncDesk.Forms
{
    partial class Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
            panel1 = new Panel();
            pictureBoxDelete = new PictureBox();
            pictureBoxEdit = new PictureBox();
            pictureBoxAdd = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxDelete);
            panel1.Controls.Add(pictureBoxEdit);
            panel1.Controls.Add(pictureBoxAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 77);
            panel1.TabIndex = 0;
            // 
            // pictureBoxDelete
            // 
            pictureBoxDelete.Cursor = Cursors.Hand;
            pictureBoxDelete.Image = (Image)resources.GetObject("pictureBoxDelete.Image");
            pictureBoxDelete.Location = new Point(840, 24);
            pictureBoxDelete.Name = "pictureBoxDelete";
            pictureBoxDelete.Size = new Size(24, 24);
            pictureBoxDelete.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDelete.TabIndex = 4;
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
            pictureBoxEdit.TabIndex = 3;
            pictureBoxEdit.TabStop = false;
            pictureBoxEdit.Click += pictureBoxEdit_Click;
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.Cursor = Cursors.Hand;
            pictureBoxAdd.Image = (Image)resources.GetObject("pictureBoxAdd.Image");
            pictureBoxAdd.Location = new Point(799, 24);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(24, 24);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAdd.TabIndex = 2;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 1;
            label1.Text = "Horários";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(888, 417);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(17, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 417);
            panel2.TabIndex = 1;
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Horarios";
            Size = new Size(911, 538);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxEdit;
        private PictureBox pictureBoxAdd;
        private DataGridView dataGridView1;
        private Panel panel2;
    }
}
