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
    public partial class FormAdicionarUsuario : Form
    {
        public event Action UsuarioAdicionado;
        public FormAdicionarUsuario()
        {
            InitializeComponent();
            RbAdm.Checked = true;
            txtBoxSenha.UseSystemPasswordChar = true;
            txtBoxConfirmaSenha.UseSystemPasswordChar = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNome.Text) || string.IsNullOrEmpty(txtBoxEmail.Text) || string.IsNullOrEmpty(txtBoxSenha.Text) || string.IsNullOrEmpty(txtBoxConfirmaSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtBoxSenha.Text != txtBoxConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique e tente novamente.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidEmail(txtBoxEmail.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "INSERT INTO usuarios (nome, email, senha, tipo_usuario) VALUES (@nome, @email, @senha, @tipo_usuario)";

                using (var conn = Database.GetConnection())
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open(); // Tente abrir a conexão apenas se não estiver aberta
                        }

                        string tipo = RbAdm.Checked ? "admin" : "user";

                        

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("nome", txtBoxNome.Text);
                            cmd.Parameters.AddWithValue("email", txtBoxEmail.Text);
                            cmd.Parameters.AddWithValue("senha", txtBoxSenha.Text);
                            cmd.Parameters.AddWithValue("tipo_usuario", tipo);

                            cmd.ExecuteNonQuery();
                            this.DialogResult = DialogResult.OK;
                            UsuarioAdicionado?.Invoke();
                            MessageBox.Show("Usuário adicionado com sucesso!");
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao adicionar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = checkBoxMostrarSenha.Checked;

            txtBoxSenha.UseSystemPasswordChar = !mostrar;
            txtBoxConfirmaSenha.UseSystemPasswordChar = !mostrar;
        }
    }

}
