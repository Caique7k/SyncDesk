using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormAdicionarSaida : Form
    {
        public event Action SaidaAdicionada;

        public string idUsuario;
        public string nomeUsuario;
        public FormAdicionarSaida(string idUsuario, string nomeUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;
            label4.Text = nomeUsuario;

            txtBoxValor.KeyPress += txtBoxValor_KeyPress;
            txtBoxValor.Leave += txtBoxValor_Leave;
            txtBoxValor.Enter += txtBoxValor_Enter;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxValor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxValor.Text, out decimal valor))
            {
                txtBoxValor.Text = valor.ToString("C2"); // Formata como moeda (ex: R$ 1.234,56)
            }
            else
            {
                txtBoxValor.Text = "R$ 0,00";
            }
        }
        private void txtBoxValor_Enter(object sender, EventArgs e)
        {
            string texto = txtBoxValor.Text.Replace("R$", "").Trim();
            txtBoxValor.Text = texto;
            txtBoxValor.SelectAll(); // seleciona tudo para facilitar edição
        }
        private void txtBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos, vírgula e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Impede mais de uma vírgula
            if (e.KeyChar == ',' && txtBoxValor.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxValor.Text) || string.IsNullOrWhiteSpace(txtBoxDescricao.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                decimal valor = decimal.Parse(txtBoxValor.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                string descricao = txtBoxDescricao.Text;
                DateTime dataHorario = dateTimePicker1.Value.Date;

                string query = "INSERT INTO financeiro (tipo, valor, descricao, data_registro, registrado_por) " +
                   "VALUES (@tipo, @valor, @descricao, @dataHorario, @criado_por)";

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
                            cmd.Parameters.AddWithValue("@tipo", "saida");
                            cmd.Parameters.AddWithValue("@valor", valor);
                            cmd.Parameters.AddWithValue("@descricao", descricao);
                            cmd.Parameters.AddWithValue("@dataHorario", dataHorario);
                            cmd.Parameters.AddWithValue("@criado_por", int.Parse(idUsuario));

                            cmd.ExecuteNonQuery();
                            SaidaAdicionada?.Invoke();
                            MessageBox.Show("Entrada adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar saida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
