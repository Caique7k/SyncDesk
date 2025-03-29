using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;
using SyncDesk.SyncDesk.Forms;
using static SyncDesk.SyncDesk.Forms.LoginForm;
using static SyncDesk.SyncDesk.Forms.MainForm;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Clientes : UserControl
    {
        public string usuarioNome;
        public string usuarioTipo;
        public string usuarioId;
        public Clientes(string nome, string usuarioId)
        {
            InitializeComponent();
            usuarioNome = nome;
            LoadClientes(); // Carrega os clientes ao inicializar
            this.usuarioId = usuarioId;
        }

        private void LoadClientes()
        {
            string query = "SELECT \r\n    c.nome AS \"Nome do Cliente\", \r\n    c.telefone AS \"Telefone do Cliente\", \r\n    c.email AS \"Email do Cliente\", \r\n    c.endereco AS \"Endereço do Cliente\", \r\n    u.nome AS \"Criado por\" \r\nFROM \r\n    clientes c\r\nJOIN \r\n    usuarios u ON c.criado_por = u.id\r\nORDER BY \r\n    c.nome;";
            using (var conn = Database.GetConnection())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView2.DataSource = dt; // Carrega os dados no DataGridView


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente formAdicionarCliente = new FormAdicionarCliente(usuarioNome, usuarioId);
            formAdicionarCliente.ShowDialog();
        }
    }
    }
