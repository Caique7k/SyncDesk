using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;
using static SyncDesk.SyncDesk.Forms.Clientes;
using static SyncDesk.SyncDesk.Forms.Horarios;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Usuario : UserControl
    {
        public string nomeUsuario;
        public string idUsuario;

        public class UsuarioSelecionado
        {
            public static string id { get; set; } //ID DO USUARIO
        }
        public Usuario(string userId, string UserNome)
        {
            InitializeComponent();
            nomeUsuario = UserNome;
            idUsuario = userId;
            CarregarUsuarios();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarUsuarios()
        {
            string query = @"SELECT 
                                u.id,
                                u.nome AS ""Nome do Usuário"", 
                                u.email AS ""Email do Usuário"", 
                                u.senha AS ""Senha Cadastrada"", 
                                u.tipo_usuario AS ""Tipo do Usuário"", 
                                u.criado_em AS ""Criado em""
                             FROM 
                                usuarios u
                             ORDER BY 
                                u.nome;";

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
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                            // Oculta a coluna de ID para o usuário
                            if (dataGridView1.Columns.Contains("id"))
                                dataGridView1.Columns["id"].Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar usuários: {ex.Message}");
                    }
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // linha selecionada
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;// verifica se a linha clicada esta dentro do datagridview

            foreach (DataGridViewRow row in dataGridView1.Rows) //estrutura de repetição para desmarcar todas as linhas quando uma só é clicada, deixando somente a atual

            {
                row.Selected = false;
            }
            // Seleciona a linha clicada
            dataGridView1.Rows[e.RowIndex].Selected = true; // marca visualmente toda a linha clicada

            UsuarioSelecionado.id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString(); //armazena o id do cliente selecionado na variavel ClienteSelecionado.id
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            FormAdicionarUsuario formAdicionarUsuario = new FormAdicionarUsuario();
            formAdicionarUsuario.UsuarioAdicionado += () => CarregarUsuarios();
            formAdicionarUsuario.Show();
        }

        private void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado.id == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DeleteUsuario(UsuarioSelecionado.id);
            }
        }

        private void DeleteUsuario(string id)
        {
            string query = "Delete FROM usuarios WHERE id = @id";

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
                        cmd.Parameters.AddWithValue("id", int.Parse(id));

                        var result = MessageBox.Show("Confirma a exclusão do usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                            cmd.ExecuteReader();
                            MessageBox.Show("Usuário removido com sucesso!");
                            CarregarUsuarios();
                            HorarioSelecionado.id = null;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir usuário: {ex.Message}");
                }
            }
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado.id == null)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = UsuarioSelecionado.id;
                string nome = selectedRow.Cells["Nome do Usuário"].Value.ToString();
                string email = selectedRow.Cells["Email do Usuário"].Value.ToString();
                string senha = selectedRow.Cells["Senha Cadastrada"].Value.ToString();
                string tipo = dataGridView1.SelectedRows[0].Cells["Tipo do Usuário"].Value?.ToString();

                FormEditarUsuario formEditarUsuario = new FormEditarUsuario(id, nome, email, tipo, senha);
                formEditarUsuario.UsuarioEditado += () => CarregarUsuarios();
                formEditarUsuario.Show();
            }

            
        }
    }
}
