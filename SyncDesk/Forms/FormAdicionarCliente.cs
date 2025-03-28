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

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormAdicionarCliente : Form
    {
        public string usuarioNome;
        public FormAdicionarCliente(string nome)
        {
            InitializeComponent();
            usuarioNome = nome;
            label6.Text = usuarioNome;
        }

        private void FormAdicionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
       string.IsNullOrWhiteSpace(textBoxTelefone.Text) ||
       string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
       string.IsNullOrWhiteSpace(textBoxEndereco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return; // Não execute o comando se algum campo estiver vazio
            }

            string query = "INSERT INTO clientes (nome, telefone, email, endereco, criado_por) VALUES (@nome, @telefone, @email, @endereco, @criado_por)";
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open(); // Tente abrir a conexão
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", textBoxNome.Text);
                        cmd.Parameters.AddWithValue("telefone", textBoxTelefone.Text);
                        cmd.Parameters.AddWithValue("email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("endereco", textBoxEndereco.Text);
                        cmd.Parameters.AddWithValue("criado_por", usuarioNome);

                        cmd.ExecuteNonQuery(); // Execute o comando
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar cliente: {ex.Message}");
                }
            }
        }
    }
}

