using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;
using SyncDesk.SyncDesk.Forms;
using static SyncDesk.SyncDesk.Forms.LoginForm;
using static SyncDesk.SyncDesk.Forms.MainForm;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Clientes : UserControl
    {
        public string usuarioNome;
        public string usuarioTipo;
        public string usuarioId;

        public class ClienteSelecionado
        {
            public static string id { get; set; } // ID do cliente selecionado
        }

        public Clientes(string nome, string usuarioId)
        {
            InitializeComponent();
            usuarioNome = nome;
            this.usuarioId = usuarioId;
            LoadClientes(); // Carrega os clientes ao inicializar

            // Inscreve o evento CellClick
            dataGridView2.CellClick += dataGridView2_CellClick;
        }

        public void LoadClientes()
        {
            string query = @"SELECT 
                                c.id,
                                c.nome AS ""Nome do Cliente"", 
                                c.telefone AS ""Telefone do Cliente"", 
                                c.email AS ""Email do Cliente"", 
                                c.endereco AS ""Endereço do Cliente"", 
                                u.nome AS ""Criado por""
                             FROM 
                                clientes c
                             JOIN 
                                usuarios u ON c.criado_por = u.id
                             ORDER BY 
                                c.nome;";

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
                            dataGridView2.DataSource = dt;

                            // Oculta a coluna de ID para o usuário
                            if (dataGridView2.Columns.Contains("id"))
                                dataGridView2.Columns["id"].Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) // linha selecionada
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;// verifica se a linha clicada esta dentro do datagridview

            foreach (DataGridViewRow row in dataGridView2.Rows) //estrutura de repetição para desmarcar todas as linhas quando uma só é clicada, deixando somente a atual

            {
                row.Selected = false;
            }
            // Seleciona a linha clicada
            dataGridView2.Rows[e.RowIndex].Selected = true; // marca visualmente toda a linha clicada

            ClienteSelecionado.id = dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString(); //armazena o id do cliente selecionado na variavel ClienteSelecionado.id
        }



        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente formAdicionarCliente = new FormAdicionarCliente(usuarioNome, usuarioId);

            // Inscreva-se no evento ClienteAdicionado
            formAdicionarCliente.ClienteAdicionado += () => LoadClientes();

            // Exibe o formulário como um diálogo modal
            formAdicionarCliente.ShowDialog();
        }

        private void btnDeleteCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClienteSelecionado.id)) // Verifica se um cliente foi selecionado
            {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            var result = MessageBox.Show("Deseja remover cliente?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                excluiCliente(ClienteSelecionado.id);  // chama a função para excluir o cliente
            }
        }

        public void excluiCliente(string clienteId)
        {
            string query = "DELETE FROM clientes WHERE id = @id";
            using (var conn = Database.GetConnection())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", int.Parse(clienteId));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente removido com sucesso!");
                        LoadClientes(); // Atualiza a lista de clientes
                        ClienteSelecionado.id = null; // Limpa a seleção
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao remover cliente: {ex.Message}");
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            if (ClienteSelecionado.id == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
            else
            {
                var formEditarCliente = new FormEditarCliente(ClienteSelecionado.id, usuarioNome, usuarioId);
                formEditarCliente.ShowDialog();
            }

        }
    }
}
