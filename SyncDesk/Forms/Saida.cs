using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Npgsql;
using SyncDesk.Data;
using static SyncDesk.SyncDesk.Forms.Entradas;
using static SyncDesk.SyncDesk.Forms.Horarios;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Saida : UserControl
    {

        public class SaidaSelecionada
        {
            public static string id { get; set; }
        }

        public string idUsuario;
        public string nomeUsuario;
        public Saida(string idUsuario, string nomeUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;

            CarregarSaidas();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Saida_Load(object sender, EventArgs e)
        {

        }

        private void CarregarSaidas()
        {
            string query =
               "SELECT e.id, " +
               "e.tipo AS \"Tipo\", " +
               "e.valor AS \"Valor da saida\", " +
               "e.descricao AS \"Descrição\", " +
               "e.data_registro AS \"Data\", " +
               "u.nome AS \"Criado por\" " +
               "FROM financeiro e " +
               "JOIN usuarios u ON e.registrado_por = u.id " +
               "WHERE e.tipo = 'saida' " +
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
                            if (dataGridView1.Columns.Contains("Valor da saida"))
                            {
                                dataGridView1.Columns["Valor da saida"].DefaultCellStyle.Format = "C2";
                                dataGridView1.Columns["Valor da saida"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
                            }



                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar saidas: {ex.Message}");
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

            SaidaSelecionada.id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            FormAdicionarSaida formAdicionarSaida = new FormAdicionarSaida(idUsuario, nomeUsuario);
            formAdicionarSaida.SaidaAdicionada += () => CarregarSaidas();
            formAdicionarSaida.Show();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (SaidaSelecionada.id == null)
            {
                MessageBox.Show("Selecione uma saida para excluir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DeleteSaida(SaidaSelecionada.id);
            }
        }

        private void DeleteSaida(string id)
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
                        cmd.Parameters.AddWithValue("id", int.Parse(id));

                        var result = MessageBox.Show("Confirma a exclusão da saída?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                            cmd.ExecuteReader();
                            MessageBox.Show("Saída removido com sucesso!");
                            CarregarSaidas();
                            HorarioSelecionado.id = null;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir saida: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string valorSaida = row.Cells["Valor da saida"].Value.ToString();
                string data = Convert.ToDateTime(row.Cells["Data"].Value).ToString("dd/MM/yyyy");
                string descricao = row.Cells["Descrição"].Value.ToString();
                string criadoPor = row.Cells["Criado por"].Value.ToString();

                FormVisualizarSaida formVisualizarSaida = new FormVisualizarSaida(valorSaida, data, descricao, criadoPor);
                formVisualizarSaida.Show();
            }
        }
    }
}
