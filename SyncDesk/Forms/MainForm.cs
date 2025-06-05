using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.SyncDesk.Forms;
using static SyncDesk.SyncDesk.Forms.LoginForm;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using SyncDesk.Data;
using iTextAlignment = iText.Layout.Properties.HorizontalAlignment;


namespace SyncDesk.SyncDesk.Forms
{
    public partial class MainForm : Form
    {
        public string usuarioNome;
        public string usuarioTipo;
        public string usuarioId;
        public MainForm(string nome, string tipo, string usuarioId)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioTipo = tipo;
            label1.Text = $"Bem vindo, {usuarioNome}";
            this.usuarioId = usuarioId;
            timer1.Interval = 100;
            timer1.Start();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadContent(new Dashboard());
        }

        private void LoadContent(UserControl control) // Função para carregar o conteúdo no painel
        {
            panelContent.Controls.Clear();  // Limpa o conteúdo atual
            control.Dock = DockStyle.Fill;  // Ajusta ao tamanho do painel
            panelContent.Controls.Add(control);  // Adiciona o novo UserControl
        }

        private void lblsair_Click(object sender, EventArgs e)
        {
            Logout();//chama a função de logout
        }

        private void picturesair_Click(object sender, EventArgs e)
        {
            Logout();//chama a função de logout
        }

        //função para fazer logout
        public static void Logout()
        {
            Application.Restart();// reinicia a aplicação (eficiente para limpar a memória em uso)

        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {
            LoadContent(new Dashboard());
        }

        private void picturedashboard_Click(object sender, EventArgs e)
        {
            LoadContent(new Dashboard());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadContent(new Clientes(usuarioNome, usuarioId));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadContent(new Clientes(usuarioNome, usuarioId));
        }

        private void lblhorarios_Click(object sender, EventArgs e)
        {
            LoadContent(new Horarios(usuarioId, usuarioNome));
        }

        private void pictureHorarios_Click(object sender, EventArgs e)
        {
            LoadContent(new Horarios(usuarioId, usuarioNome));
        }

        private void lblentrada_Click(object sender, EventArgs e)
        {
            LoadContent(new Entradas(usuarioId, usuarioNome));
        }

        private void pictureEntrada_Click(object sender, EventArgs e)
        {
            LoadContent(new Entradas(usuarioId, usuarioNome));
        }

        private void lblsaida_Click(object sender, EventArgs e)
        {
            LoadContent(new Saida(usuarioId, usuarioNome));
        }

        private void pictureSaida_Click(object sender, EventArgs e)
        {
            LoadContent(new Saida(usuarioId, usuarioNome));
        }

        private void lblusuarios_Click(object sender, EventArgs e)
        {
            if (usuarioTipo == "admin")
            {
                LoadContent(new Usuario(usuarioId, usuarioNome));
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar este módulo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioTipo == "admin")
            {
                LoadContent(new Usuario(usuarioId, usuarioNome));
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                    sfd.FileName = $"Relatorio_Semanal_{DateTime.Now:ddMMyyyy}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string caminho = sfd.FileName;
                        // Caminho do logotipo
                        string logoPath = Path.Combine(Application.StartupPath, "Images", "Logo.png");


                        // Obter dados do banco
                        decimal entradas = ObterValor("entrada");
                        decimal saidas = ObterValor("saida");
                        decimal saldo = entradas - saidas;
                        List<string> clientesSemana = ObterClientesSemana();
                        List<string> proximosHorarios = ObterProximosHorarios();

                        // Gerar PDF com iText7
                        using (var writer = new PdfWriter(caminho))
                        using (var pdf = new PdfDocument(writer))
                        using (var document = new Document(pdf))
                        {
                            // Capa com logotipo
                            if (File.Exists(logoPath))
                            {
                                var logoData = ImageDataFactory.Create(logoPath);
                                var logo = new iText.Layout.Element.Image(logoData).ScaleToFit(125, 125).SetHorizontalAlignment(iTextAlignment.CENTER);
                                document.Add(logo);
                            }

                            document.Add(new Paragraph("\nRelatório Semanal").SetFontSize(20).SetTextAlignment(TextAlignment.CENTER));
                            document.Add(new Paragraph($"\nGerado em: {DateTime.Now:dd/MM/yyyy HH:mm}\n\n"));

                            // Resumo financeiro
                            document.Add(new Paragraph("Resumo Financeiro").SetFontSize(16));
                            document.Add(new Paragraph($"Entradas: {entradas.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}"));
                            document.Add(new Paragraph($"Saídas: {saidas.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}"));
                            document.Add(new Paragraph($"Saldo Atual: {saldo.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}\n"));

                            Dashboard dash = panelContent.Controls.OfType<Dashboard>().FirstOrDefault();

                            if (dash == null)
                            {
                                MessageBox.Show("Dashboard não está carregado.");
                                return;
                            }

                            Chart chart = FindChart(dash
                                );

                            if (chart == null)
                            {
                                MessageBox.Show("Gráfico não encontrado.");
                                return;
                            }

                            //  salva a imagem 
                            using (MemoryStream ms = new MemoryStream())
                            {
                                chart.SaveImage(ms, ChartImageFormat.Png);
                                ms.Position = 0;

                                var imageData = ImageDataFactory.Create(ms.ToArray());
                                var img = new iText.Layout.Element.Image(imageData)
                                    .SetMaxHeight(400)
                                    .SetAutoScale(true);

                                document.Add(new Paragraph("Gráfico Financeiro da Semana").SetFontSize(16));
                                document.Add(img);
                            }

                            // Clientes da semana
                            document.Add(new Paragraph("\nClientes Cadastrados na Semana").SetFontSize(16));
                            if (clientesSemana.Any())
                            {
                                foreach (var cliente in clientesSemana)
                                {
                                    document.Add(new Paragraph($"- {cliente}"));
                                }
                            }
                            else
                            {
                                document.Add(new Paragraph("Nenhum cliente cadastrado nesta semana."));
                            }

                            // Próximos horários
                            document.Add(new Paragraph("\nPróximos Horários Agendados").SetFontSize(16));
                            if (proximosHorarios.Any())
                            {
                                foreach (var horario in proximosHorarios)
                                {
                                    document.Add(new Paragraph($"- {horario}"));
                                }
                            }
                            else
                            {
                                document.Add(new Paragraph("Nenhum horário agendado para os próximos dias."));
                            }

                            document.Add(new Paragraph($"\nRelatório gerado automaticamente pelo SyncDesk. \nUsuário: {usuarioNome}"));
                        }

                        MessageBox.Show("Relatório PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        // Função para buscar valores do banco
        private decimal ObterValor(string tipo)
        {
            decimal valor = 0;
            string query = "SELECT COALESCE(SUM(valor), 0) FROM financeiro WHERE tipo = @tipo AND data_registro >= CURRENT_DATE - INTERVAL '7 days';";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("tipo", tipo);
                valor = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            return valor;
        }

        // Função para obter clientes cadastrados na semana
        private List<string> ObterClientesSemana()
        {
            List<string> clientes = new List<string>();
            string query = "SELECT nome FROM clientes WHERE criado_em >= date_trunc('week', CURRENT_DATE);";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    clientes.Add(reader["nome"].ToString());
                }
            }

            return clientes;
        }

        // Função para obter próximos horários agendados
        private List<string> ObterProximosHorarios()
        {
            List<string> horarios = new List<string>();
            string query = @"
        SELECT h.data_hora, h.hora, h.descricao, c.nome AS cliente
        FROM horarios h
        JOIN clientes c ON h.cliente_id = c.id
        WHERE h.data_hora >= NOW()
        ORDER BY h.data_hora ASC
        LIMIT 5;
    ";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime dataHora = Convert.ToDateTime(reader["data_hora"]);
                    string hora = reader["hora"].ToString();
                    string descricao = reader["descricao"].ToString();
                    string cliente = reader["cliente"].ToString();

                    horarios.Add($"{dataHora:dd/MM} às {hora} - {descricao} (Cliente: {cliente})");
                }
            }

            return horarios;
        }

        private Chart FindChart(Control parent) //função que mapeia toda estrutura para achar "CHART"
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Chart chart)
                    return chart;

                var childChart = FindChart(c);
                if (childChart != null)
                    return childChart;
            }
            return null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mostraHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
    

