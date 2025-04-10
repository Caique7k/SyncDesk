using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormAdicionarCliente : Form
    {
        public string usuarioNome;
        public string usuarioId;
        public bool Editando { get; set; } = false;
        public event Action ClienteAdicionado;

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
            // Validação de campos
            if (string.IsNullOrEmpty(textBoxNome.Text) ||
                string.IsNullOrEmpty(textBoxTelefone.Text) ||
                string.IsNullOrEmpty(textBoxEndereco.Text) ||
                string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remover máscara do telefone
            string telefoneSemMascara = textBoxTelefone.Text.Replace("(", "")
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
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        cmd.Parameters.AddWithValue("telefone", telefoneSemMascara); // Salva sem máscara
                        cmd.Parameters.AddWithValue("email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("endereco", textBoxEndereco.Text);
                        cmd.Parameters.AddWithValue("criado_por", int.Parse(usuarioId));

                        cmd.ExecuteNonQuery(); // Execute o comando
                        this.DialogResult = DialogResult.OK;

                        ClienteAdicionado?.Invoke();

                        MessageBox.Show("Cliente adicionado com sucesso!");
                        this.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar cliente: {ex.Message}");
                }
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