using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncDesk.Data;
using Npgsql;
using static SyncDesk.SyncDesk.Forms.Clientes;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Horarios : UserControl
    {
        public string usuarioNome;
        public string usuarioTipo;
        public string usuarioId;

        public class HorarioSelecionado
        {
            public static string id { get; set; }
            }
        
        public Horarios(string id, string nome)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioId = id;
            LoadHorarios();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            AdicionarHorarioForm adicionarHorarioForm = new AdicionarHorarioForm(usuarioNome, usuarioId);
            adicionarHorarioForm.HorarioAdicionado += () => LoadHorarios();
            adicionarHorarioForm.ShowDialog();
        }

        private void LoadHorarios()
        {
            string query =
    "SELECT h.id, " +
    "h.cliente_id, " +
    "h.data_hora AS \"Data\", " +
    "c.nome AS \"Nome do Cliente\", " +
    "h.descricao AS \"Descrição\", " +
    "h.hora AS \"Horário\", " +
    "u.nome AS \"Criado por\" " +
    "FROM horarios h " +
    "JOIN clientes c ON h.cliente_id = c.id " +
    "JOIN usuarios u ON h.criado_por = u.id " + 
    "ORDER BY h.data_hora ASC";

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

                            // Oculta a coluna de ID para o usuário
                            if (dataGridView1.Columns.Contains("id"))
                                dataGridView1.Columns["id"].Visible = false;
                                dataGridView1.Columns["cliente_id"].Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar horarios: {ex.Message}");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            HorarioSelecionado.id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString(); //armazena o id do cliente selecionado na variavel ClienteSelecionado.id
        }

    }
}
