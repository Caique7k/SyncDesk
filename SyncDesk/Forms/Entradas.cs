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
        public Entradas()
        {
            InitializeComponent();
            CarregarEntradas();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {

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

            EntradaSelecionada.id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString(); //armazena o id do cliente selecionado na variavel ClienteSelecionado.id
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
