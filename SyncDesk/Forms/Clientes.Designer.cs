
namespace SyncDesk.SyncDesk.Forms
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            dataGridView2 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            btnEditCliente = new PictureBox();
            btnDeleteCliente = new PictureBox();
            btnAddCliente = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEditCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddCliente).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 74);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(948, 520);
            dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditCliente);
            panel1.Controls.Add(btnDeleteCliente);
            panel1.Controls.Add(btnAddCliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 64);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnEditCliente
            // 
            btnEditCliente.Cursor = Cursors.Hand;
            btnEditCliente.Image = (Image)resources.GetObject("btnEditCliente.Image");
            btnEditCliente.Location = new Point(904, 22);
            btnEditCliente.Name = "btnEditCliente";
            btnEditCliente.Size = new Size(24, 24);
            btnEditCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditCliente.TabIndex = 3;
            btnEditCliente.TabStop = false;
            // 
            // btnDeleteCliente
            // 
            btnDeleteCliente.Cursor = Cursors.Hand;
            btnDeleteCliente.Image = (Image)resources.GetObject("btnDeleteCliente.Image");
            btnDeleteCliente.Location = new Point(863, 22);
            btnDeleteCliente.Name = "btnDeleteCliente";
            btnDeleteCliente.Size = new Size(24, 24);
            btnDeleteCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnDeleteCliente.TabIndex = 1;
            btnDeleteCliente.TabStop = false;
            // 
            // btnAddCliente
            // 
            btnAddCliente.AccessibleDescription = "Adicionar novo cliente";
            btnAddCliente.Cursor = Cursors.Hand;
            btnAddCliente.Image = (Image)resources.GetObject("btnAddCliente.Image");
            btnAddCliente.Location = new Point(823, 23);
            btnAddCliente.Name = "btnAddCliente";
            btnAddCliente.Size = new Size(24, 24);
            btnAddCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddCliente.TabIndex = 0;
            btnAddCliente.TabStop = false;
            btnAddCliente.Tag = "";
            btnAddCliente.Click += btnAddCliente_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Size = new Size(948, 594);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnEditCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Criadopor;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn criado_por;
        private Label label1;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox btnAddCliente;
        private PictureBox btnEditCliente;
        private PictureBox btnDeleteCliente;
    }
}
