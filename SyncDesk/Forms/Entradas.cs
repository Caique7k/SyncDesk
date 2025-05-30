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
using static SyncDesk.SyncDesk.Forms.Horarios;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Entradas : UserControl
    {

        public class EntradaSelecionada
        {
            public static string id { get; set; }
        }

        public string userId;
        public string userName;
        public Entradas(string id, string nome)
        {
            InitializeComponent();
            this.userId = id;
            this.userName = nome;
            CarregarEntradas();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            FormAdicionarEntrada formAdicionarEntrada = new FormAdicionarEntrada(userId, userName);
            formAdicionarEntrada.EntradaAdicionada += () => CarregarEntradas();
            formAdicionarEntrada.Show();
        }

        private void CarregarEntradas()
        {
            string query =
                "SELECT e.id, " +
                "e.tipo AS \"Tipo\", " +
                "e.valor AS \"Valor da entrada\", " +
                "e.descricao AS \"Descrição\", " +
                "e.data_registro AS \"Data\", " +
                "u.nome AS \"Criado por\" " +
                "FROM financeiro e " +
                "JOIN usuarios u ON e.registrado_por = u.id " +
                "WHERE e.tipo = 'entrada' " +
                "ORDER BY e.data_registro DESC;";

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


                            if (dataGridView1.Columns.Contains("id"))
                                dataGridView1.Columns["id"].Visible = false;
                            if (dataGridView1.Columns.Contains("registrado_por"))
                                dataGridView1.Columns["registrado_por"].Visible = false;


                            if (dataGridView1.Columns.Contains("Data"))
                                dataGridView1.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            if (dataGridView1.Columns.Contains("Valor da entrada"))
                            {
                                dataGridView1.Columns["Valor da entrada"].DefaultCellStyle.Format = "C2";
                                dataGridView1.Columns["Valor da entrada"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
                            }



                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar entradas: {ex.Message}");
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;// verifica se a linha clicada esta dentro do datagridview

            foreach (DataGridViewRow row in dataGridView1.Rows) //estrutura de repetição para desmarcar todas as linhas quando uma só é clicada, deixando somente a atual

            {
                row.Selected = false;
            }
            // Seleciona a linha clicada
            dataGridView1.Rows[e.RowIndex].Selected = true; // marca visualmente toda a linha clicada

            EntradaSelecionada.id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString(); 
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string valorEntrada = row.Cells["Valor da entrada"].Value.ToString();
                string data = Convert.ToDateTime(row.Cells["Data"].Value).ToString("dd/MM/yyyy");
                string descricao = row.Cells["Descrição"].Value.ToString();
                string criadoPor = row.Cells["Criado por"].Value.ToString();

                VisualizarEntradaForm visualizarEntradaForm = new VisualizarEntradaForm(valorEntrada, data, descricao, criadoPor);
                visualizarEntradaForm.Show();
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (EntradaSelecionada.id == null)
            {
                MessageBox.Show("Selecione uma entrada para excluir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DeleteEntrada(EntradaSelecionada.id);
            }
        }

        private void DeleteEntrada(string entradaId)
        {
            string query = "Delete FROM financeiro WHERE id = @id";

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
                        cmd.Parameters.AddWithValue("id", int.Parse(entradaId));

                        var result = MessageBox.Show("Confirma a exclusão da entrada?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                            cmd.ExecuteReader();
                            MessageBox.Show("Entrada removido com sucesso!");
                            CarregarEntradas();
                            HorarioSelecionado.id = null;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir entrada: {ex.Message}");
                }
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            if (EntradaSelecionada.id == null)
            {
                MessageBox.Show("Selecione uma entrada para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string idEntrada = EntradaSelecionada.id;
                string valorEntrada = selectedRow.Cells["Valor da entrada"].Value.ToString();
                string data = Convert.ToDateTime(selectedRow.Cells["Data"].Value).ToString("dd/MM/yyyy");
                string descricao = selectedRow.Cells["Descrição"].Value.ToString();
                string criadoPor = selectedRow.Cells["Criado por"].Value.ToString();

                FormEditarEntrada formEditarEntrada = new FormEditarEntrada(idEntrada, valorEntrada, data, descricao, criadoPor);
                formEditarEntrada.EntradaEditada += () => CarregarEntradas();
                formEditarEntrada.Show();
            }
        }
    }
}
