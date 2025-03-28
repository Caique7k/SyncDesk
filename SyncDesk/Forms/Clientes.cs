using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
            LoadClientes(); // Carrega os clientes ao inicializar

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

    }
}