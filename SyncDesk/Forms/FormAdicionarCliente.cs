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
        public string usuarioId;
        public FormAdicionarCliente(string nome, string usuarioId)
        {
            InitializeComponent();
            usuarioNome = nome;
            label6.Text = usuarioNome;
            this.usuarioId = usuarioId;
        }

        private void FormAdicionarCliente_Load(object sender, EventArgs e)
        {

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxTelefone.Text) || string.IsNullOrEmpty(textBoxEndereco.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO clientes (nome, telefone, email, endereco, criado_por) VALUES (@nome, @telefone, @email, @endereco, @criado_por)";
                using (var conn = Database.GetConnection())
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open(); // Tente abrir a conexão apenas se não estiver aberta
                        }

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("nome", textBoxNome.Text);
                            cmd.Parameters.AddWithValue("telefone", textBoxTelefone.Text);
                            cmd.Parameters.AddWithValue("email", textBoxEmail.Text);
                            cmd.Parameters.AddWithValue("endereco", textBoxEndereco.Text);
                            cmd.Parameters.AddWithValue("criado_por", int.Parse(usuarioId));

                            cmd.ExecuteNonQuery(); // Execute o comando
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("Cliente adicionado com sucesso!");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(usuarioId);
                        MessageBox.Show($"Erro ao adicionar cliente: {ex.Message}");
                    }
                }

            }
        }
    }
}
    


