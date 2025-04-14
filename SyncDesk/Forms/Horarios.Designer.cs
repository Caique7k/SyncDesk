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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxDelete);
            panel1.Controls.Add(pictureBoxEdit);
            panel1.Controls.Add(pictureBoxAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 68);
            panel1.TabIndex = 0;
            // 
            // pictureBoxDelete
            // 
            pictureBoxDelete.Cursor = Cursors.Hand;
            pictureBoxDelete.Image = (Image)resources.GetObject("pictureBoxDelete.Image");
            pictureBoxDelete.Location = new Point(803, 24);
            pictureBoxDelete.Name = "pictureBoxDelete";
            pictureBoxDelete.Size = new Size(22, 30);
            pictureBoxDelete.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDelete.TabIndex = 4;
            pictureBoxDelete.TabStop = false;
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.Cursor = Cursors.Hand;
            pictureBoxEdit.Image = (Image)resources.GetObject("pictureBoxEdit.Image");
            pictureBoxEdit.Location = new Point(846, 24);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(22, 30);
            pictureBoxEdit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEdit.TabIndex = 3;
            pictureBoxEdit.TabStop = false;
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.Cursor = Cursors.Hand;
            pictureBoxAdd.Image = (Image)resources.GetObject("pictureBoxAdd.Image");
            pictureBoxAdd.Location = new Point(758, 24);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(22, 30);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAdd.TabIndex = 2;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 1;
            label1.Text = "Horários";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 481);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(908, 481);
            dataGridView1.TabIndex = 0;
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Horarios";
            Size = new Size(908, 603);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxEdit;
        private PictureBox pictureBoxAdd;
        private DataGridView dataGridView1;
    }
}
