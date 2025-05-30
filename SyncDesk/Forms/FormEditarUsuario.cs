using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormEditarUsuario : Form
    {
        public event Action UsuarioEditado;

        private string idUsuario;
        public class UsuarioSelecionado
        {
            public static string id { get; set; }
        }

        public FormEditarUsuario(string id, string nome, string email, string tipo, string senha)
        {
            InitializeComponent();
            idUsuario = id;
            txtBoxEditNome.Text = nome;
            txtBoxEditEmail.Text = email;
            string tipoFormatado = tipo.Trim().ToLower();
            RbAdmEdit.Checked = tipoFormatado == "admin";
            RbUserEdit.Checked = tipoFormatado == "user";
            txtBoxEditSenha.Text = senha;
            txtBoxEditConfirmaSenha.Text = senha;

            txtBoxEditSenha.UseSystemPasswordChar = true;
            txtBoxEditConfirmaSenha.UseSystemPasswordChar = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxEditNome.Text) || string.IsNullOrEmpty(txtBoxEditEmail.Text) || string.IsNullOrEmpty(txtBoxEditSenha.Text) || string.IsNullOrEmpty(txtBoxEditConfirmaSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtBoxEditSenha.Text != txtBoxEditConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidEmail(txtBoxEditEmail.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string tipoUsuario = RbAdmEdit.Checked ? "admin" : "user";

                string query = "UPDATE usuarios SET nome = @nome, email = @email, senha = @senha, tipo_usuario = @tipo_usuario WHERE id = @id";
                using (var conn = Database.GetConnection())
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open(); // Tente abrir a conexão apenas se não estiver aberta
                        }
                        using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("id", int.Parse(idUsuario));
                            cmd.Parameters.AddWithValue("nome", txtBoxEditNome.Text);
                            cmd.Parameters.AddWithValue("email", txtBoxEditEmail.Text);
                            cmd.Parameters.AddWithValue("senha", txtBoxEditSenha.Text);
                            cmd.Parameters.AddWithValue("tipo_usuario", tipoUsuario);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário editado com sucesso!");
                            UsuarioEditado?.Invoke();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao editar usuário: {ex.Message}");
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



        private void checkBoxMostrarSenhaEdit_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = checkBoxMostrarSenhaEdit.Checked;

            txtBoxEditSenha.UseSystemPasswordChar = !mostrar;
            txtBoxEditConfirmaSenha.UseSystemPasswordChar = !mostrar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
