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
using System.Globalization;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            CarregarResumoFinanceiro();
            CarregarResumoClientes();
            CarregarProximosHorarios();
        }


        private void CarregarResumoFinanceiro()
        {
            decimal totalEntradas = 0;
            decimal totalSaidas = 0;

            string queryEntradas = "SELECT COALESCE(SUM(valor), 0) FROM financeiro WHERE tipo = 'entrada';";
            string querySaidas = "SELECT COALESCE(SUM(valor), 0) FROM financeiro WHERE tipo = 'saida';";

            using (var conn = Database.GetConnection())
            {
                using (var cmd = new NpgsqlCommand(queryEntradas, conn))
                {
                    try
                    {
                        totalEntradas = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar total de entradas: " + ex.Message);
                    }
                }

                using (var cmd = new NpgsqlCommand(querySaidas, conn))
                {
                    try
                    {
                        totalSaidas = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar total de saídas: " + ex.Message);
                    }
                }
            }

            decimal saldo = totalEntradas - totalSaidas;
            lblEntradas.Text = totalEntradas.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            lblSaida.Text = totalSaidas.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            lblSaldoAtual.Text = saldo.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));


            lblSaldoAtual.ForeColor = saldo < 0 ? Color.Red : Color.Green;
        }

        private void CarregarProximosHorarios()
        {


            string query = @"
        SELECT h.id, h.data_hora, h.hora, h.descricao, c.nome AS cliente
        FROM horarios h
        JOIN clientes c ON h.cliente_id = c.id
        WHERE h.data_hora >= NOW() AND concluido = FALSE
        ORDER BY h.data_hora ASC
        ;
    ";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    lblProximosHorarios.Text = "Nenhuma tarefa pendente para os próximos dias.";
                    return;
                }

                StringBuilder sb = new StringBuilder();

                while (reader.Read())
                {
                    DateTime dataHora = Convert.ToDateTime(reader["data_hora"]);
                    string hora = reader["hora"].ToString();
                    string descricao = reader["descricao"].ToString();
                    string cliente = reader["cliente"].ToString();

                    sb.AppendLine($"{dataHora:dd/MM} " +
                        $"às {hora}  " +
                        $"\n{descricao}" +
                        $"\n(Cliente: {cliente})");

                }

                lblProximosHorarios.Text = sb.ToString();
            }
        }

        private void CarregarResumoClientes()
        {
            int totalClientes = 0;
            int clientesSemana = 0;

            string queryTotal = "SELECT COUNT(*) FROM clientes;";
            string querySemana = "SELECT COUNT(*) FROM clientes WHERE criado_em >= date_trunc('week', CURRENT_DATE);";

            using (var conn = Database.GetConnection())
            {
                using (var cmdTotal = new NpgsqlCommand(queryTotal, conn))
                using (var cmdSemana = new NpgsqlCommand(querySemana, conn))
                {
                    try
                    {
                        totalClientes = Convert.ToInt32(cmdTotal.ExecuteScalar());
                        clientesSemana = Convert.ToInt32(cmdSemana.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar dados de clientes: " + ex.Message);
                    }
                }
            }

            lblTotalClientes.Text = totalClientes.ToString();
            lblClientesSemana.Text = clientesSemana.ToString();
        }
    }
}
