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
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;

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
            CriarGraficoFinanceiro();
            timerStatusConexao.Start();
            timerAtualizacaoHorarios.Start();

            ArredondarBordas(panelEntradaSaida, 15);
            ArredondarBordas(panelProximoHorario, 15);
            ArredondarBordas(panelClienteSemana, 15);
            ArredondarBordas(PanelClientesTotal, 15);
            ArredondarBordas(PanelConexao, 15);
        }

        public static GraphicsPath GetRoundedRect(Rectangle bounds, int radius) // Função para deixar as  bordas do panel arredondadas
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
        private void ArredondarBordas(Panel panel, int radius)
        {
            panel.Region = new Region(GetRoundedRect(panel.ClientRectangle, radius));
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
                                WHERE (h.data_hora + h.hora::time) >= CURRENT_TIMESTAMP
                                ORDER BY h.data_hora + h.hora::time ASC
                                LIMIT 1;
                        ";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    lblProximosHorarios.Text = "Nenhuma tarefa \npendente para os \npróximos dias.";
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

        private void timerStatusConexao_Tick(object sender, EventArgs e)
        {
            VerificarStatusConexao();
        }

        private void VerificarStatusConexao()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        lblStatusConexao.Text = "Status: Conectado ao banco de dados! ✅";
                        lblStatusConexao.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblStatusConexao.Text = "Status: Desconectado do banco de dados! ";
                        lblStatusConexao.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                lblStatusConexao.Text = "Status: Erro na conexão";
                lblStatusConexao.ForeColor = Color.DarkRed;
            }
        }

        private void CriarGraficoFinanceiro()
        {
            Chart chart = new Chart
            {
                Width = panelGrafico.Width,
                Height = panelGrafico.Height,
                BackColor = Color.White,
                BorderlineColor = Color.LightGray,
                BorderlineDashStyle = ChartDashStyle.Solid,
                Dock = DockStyle.Fill
            };

            ChartArea area = new ChartArea("AreaPrincipal");
            area.AxisX.Title = "Dia";
            area.AxisY.Title = "Valor (R$)";
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            chart.ChartAreas.Add(area);

            Series serieEntradas = new Series("Entradas")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                BorderWidth = 2
            };

            Series serieSaidas = new Series("Saídas")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };

            string query = @"
        SELECT 
            DATE(data_registro) AS dia,
            SUM(CASE WHEN tipo = 'entrada' THEN valor ELSE 0 END) AS total_entrada,
            SUM(CASE WHEN tipo = 'saida' THEN valor ELSE 0 END) AS total_saida
        FROM financeiro
        WHERE data_registro >= CURRENT_DATE - INTERVAL '6 days'
        GROUP BY dia
        ORDER BY dia;
    ";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime dia = Convert.ToDateTime(reader["dia"]);
                    decimal entrada = Convert.ToDecimal(reader["total_entrada"]);
                    decimal saida = Convert.ToDecimal(reader["total_saida"]);

                    string diaStr = dia.ToString("dd/MM");

                    serieEntradas.Points.AddXY(diaStr, entrada);
                    serieSaidas.Points.AddXY(diaStr, saida);
                }
            }

            chart.Series.Add(serieEntradas);
            chart.Series.Add(serieSaidas);
            chart.Legends.Add(new Legend("Legenda"));

            panelGrafico.Controls.Clear();
            panelGrafico.Controls.Add(chart);
        }

        private void timerAtualizacaoHorarios_Tick(object sender, EventArgs e)
        {
            CarregarProximosHorarios();
        }
    }
}
