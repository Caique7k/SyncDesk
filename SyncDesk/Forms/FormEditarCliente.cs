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

        public event Action ClienteEditado;

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
            string query = "SELECT c.id, c.nome AS cliente_nome, c.telefone, c.email, c.endereco, c.criado_por, c.criado_em, u.nome AS usuario_nome FROM clientes c JOIN usuarios u ON c.criado_por = u.id WHERE c.id = @id;";
            using (var conn = Database.GetConnection())
            {
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", int.Parse(clienteId));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxNomeEditar.Text = reader["cliente_nome"].ToString();
                            textBoxTelefoneEditar.Text = reader["telefone"].ToString();
                            textBoxEnderecoEditar.Text = reader["endereco"].ToString();
                            textBoxEmailEditar.Text = reader["email"].ToString();
                            label6.Text = reader["usuario_nome"].ToString();
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja editar este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Validação de campos
                if (string.IsNullOrEmpty(textBoxNomeEditar.Text) ||
                    string.IsNullOrEmpty(textBoxTelefoneEditar.Text) ||
                    string.IsNullOrEmpty(textBoxEnderecoEditar.Text) ||
                    string.IsNullOrEmpty(textBoxEmailEditar.Text))
                {
                    MessageBox.Show("Preencha todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Remover máscara do telefone
                string telefoneSemMascara = textBoxTelefoneEditar.Text.Replace("(", "")
                                                                      .Replace(")", "")
                                                                      .Replace(" ", "")
                                                                      .Replace("-", "");

                // Validação de telefone
                if (!IsValidPhone(telefoneSemMascara))
                {
                    MessageBox.Show("Por favor, insira um telefone válido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação de e-mail
                if (!IsValidEmail(textBoxEmailEditar.Text))
                {
                    MessageBox.Show("Por favor, insira um e-mail válido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE clientes SET nome = @nome, telefone = @telefone, email = @email, endereco = @endereco WHERE id = @id";
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
                            cmd.Parameters.AddWithValue("nome", textBoxNomeEditar.Text);
                            cmd.Parameters.AddWithValue("telefone", telefoneSemMascara);
                            cmd.Parameters.AddWithValue("email", textBoxEmailEditar.Text);
                            cmd.Parameters.AddWithValue("endereco", textBoxEnderecoEditar.Text);
                            cmd.Parameters.AddWithValue("id", int.Parse(clienteId)); 

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close(); 
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma alteração foi feita. Verifique o ID do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            clienteId = null; // Limpa o ID do cliente após a edição
                            ClienteEditado?.Invoke();
                        }
                    
                    } catch(Exception ex)
                    {
                        MessageBox.Show($"Erro ao conectar ao banco: {ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                this.Refresh();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Exemplo de validação simples para telefone
            return phone.Length == 11; // Para o formato (00) 00000-0000
        }
    }
}
