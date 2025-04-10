using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;
using SyncDesk.SyncDesk.Forms;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormEditarCliente : Form
    {
        public string clienteId;
        public string usuarioNome;
        public string usuarioId;

        public FormEditarCliente(string clienteId, string usuarioNome, string usuarioId)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            this.usuarioNome = usuarioNome;
            this.usuarioId = usuarioId;

        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            carregarCliente(clienteId);
        }

        private void carregarCliente(string clienteId)
        {
            string query = "SELECT *\r\nFROM clientes c\r\nJOIN usuarios u ON c.criado_por = u.id\r\nWHERE c.id = @id;";
            using (var conn = Database.GetConnection())
            {
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", int.Parse(clienteId));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxNomeEditar.Text = reader["nome"].ToString();
                            textBoxTelefoneEditar.Text = reader["telefone"].ToString();
                            textBoxEnderecoEditar.Text = reader["endereco"].ToString();
                            textBoxEmailEditar.Text = reader["email"].ToString();
                            label6.Text = reader["criado_por"].ToString();
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
