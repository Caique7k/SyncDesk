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
using Npgsql;
using static SyncDesk.SyncDesk.Forms.AdicionarHorarioForm;
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{

    public partial class FormEditarEntrada : Form
    {
        public static string idEntra { get; set; }

        public event Action EntradaEditada;
        public FormEditarEntrada(string idEntrada, string valorEntrada, string dataEntrada, string DescricaoEntrada, string CriadoPor)
        {
            InitializeComponent();
            idEntra = idEntrada;

            if (decimal.TryParse(valorEntrada, out decimal valor))
            {
                txtBoxValorEdit.Text = valor.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                txtBoxValorEdit.Text = valorEntrada;
            }
            dateTimePickerEdit.Value = DateTime.Parse(dataEntrada);
            txtBoxDescricaoEdit.Text = DescricaoEntrada;
            label4.Text = CriadoPor;

            txtBoxValorEdit.KeyPress += txtBoxValorEdit_KeyPress;
            txtBoxValorEdit.Leave += txtBoxValorEdit_Leave;
            txtBoxValorEdit.Enter += txtBoxValorEdit_Enter;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBoxValorEdit_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxValorEdit.Text, out decimal valor))
            {
                txtBoxValorEdit.Text = valor.ToString("C2"); // Formata como moeda (ex: R$ 1.234,56)
            }
            else
            {
                txtBoxValorEdit.Text = "R$ 0,00";
            }
        }
        private void txtBoxValorEdit_Enter(object sender, EventArgs e)
        {
            string texto = txtBoxValorEdit.Text.Replace("R$", "").Trim();
            txtBoxValorEdit.Text = texto;
            txtBoxValorEdit.SelectAll(); // seleciona tudo para facilitar edição
        }
        private void txtBoxValorEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos, vírgula e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Impede mais de uma vírgula
            if (e.KeyChar == ',' && txtBoxValorEdit.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxValorEdit.Text) || string.IsNullOrWhiteSpace(txtBoxDescricaoEdit.Text))
                {
                    MessageBox.Show("Preencha todos os campos antes de salvar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    decimal valor = decimal.Parse(txtBoxValorEdit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                    string descricao = txtBoxDescricaoEdit.Text;
                    DateTime dataHorario = dateTimePickerEdit.Value.Date;

                    string query = "UPDATE financeiro SET valor = @valor, descricao = @descricao, data_registro = @data_registro WHERE id = @id";
                    using (var conn = Database.GetConnection())
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("valor", valor);
                        cmd.Parameters.AddWithValue("descricao", descricao);
                        cmd.Parameters.AddWithValue("data_registro", dataHorario);
                        cmd.Parameters.AddWithValue("id", int.Parse(idEntra));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Entrada atualizada com sucesso!");
                    EntradaEditada?.Invoke(); 
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar entrada: {ex.Message}");
            }
        }
    }
}
