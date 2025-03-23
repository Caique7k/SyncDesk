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
using Npgsql;
using SyncDesk.SyncDesk.Forms;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        public class usuarioLogado
        {
            public static string nome { get; set; }
            public static string tipo { get; set; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxemail.Text;
            string senha = textBoxSenha.Text;

            string userType = ValidateLogin(email, senha);

            if (userType != null)
            {
                if (userType == "admin")
                {
                    MainForm mainForm = new MainForm(usuarioLogado.nome, usuarioLogado.tipo);//aqui seta o nome e tipo do usuario logado que pede no construtor do mainform
                    mainForm.Show();
                }
                else
                {
                    MainForm mainForm = new MainForm(usuarioLogado.nome, usuarioLogado.tipo);
                    mainForm.Show();
                }
                this.Hide();// esconde a tela de login 
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ValidateLogin(string email, string senha)
        {
            string query = "SELECT tipo_usuario, nome FROM usuarios WHERE email = @email AND senha = @senha LIMIT 1";

            using (var conn = Database.GetConnection())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("email", email);//compara email
                    cmd.Parameters.AddWithValue("senha", senha);//compara senha

                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) //se o usuario existir
                            {
                                string tipoUsuario = reader["tipo_usuario"].ToString();
                                string nomeUsuario = reader["nome"].ToString();

                                //armazena nome e tipo do usuario logado na variavel estatica usuarioLogado
                                usuarioLogado.nome = nomeUsuario;
                                usuarioLogado.tipo = tipoUsuario;

                                return tipoUsuario;
                            }
                            else
                            {
                                return null;

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao conectar ao banco: {ex.Message}");
                        return null;
                    }
                }
            }
        }
    }
}
