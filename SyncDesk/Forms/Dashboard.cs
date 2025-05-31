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
    public partial class Dashboard: UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            CarregarResumoFinanceiro();
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
    }
}
