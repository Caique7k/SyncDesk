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
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormEditarHorario : Form
    {
        public string horarioId;
        public string usuarioNome;
        public string usuarioId;

        public event Action HorarioEditado;
        public FormEditarHorario(string idHorario, string clienteId, string nomeCliente, string data, string horario, string descricao, string UsuarioId, string UsuarioNome)
        {
            InitializeComponent();
            this.horarioId = idHorario;
            this.usuarioId = UsuarioId;
            this.usuarioNome = UsuarioNome;

            CarregarClientes();

            comboBoxClienteEdit.SelectedValue = clienteId;
            dateTimePickerEdit.Value = DateTime.Parse(data);
            maskedTextBoxHorarioEdit.Text = horario;
            textBoxDescEdit.Text = descricao;
        }
        private void CarregarClientes()
        {
            string query = "SELECT id, nome FROM clientes ORDER BY nome ASC";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var adapter = new NpgsqlDataAdapter(cmd))
            {
                try
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    comboBoxClienteEdit.DataSource = dt;
                    comboBoxClienteEdit.DisplayMember = "nome";
                    comboBoxClienteEdit.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string clienteId = comboBoxClienteEdit.SelectedValue.ToString();
                DateTime dataHora = dateTimePickerEdit.Value.Date;
                string hora = maskedTextBoxHorarioEdit.Text;
                string descricao = textBoxDescEdit.Text;
                bool horarioValido = TimeSpan.TryParse(hora, out TimeSpan horarioConvertido);
                if (string.IsNullOrWhiteSpace(descricao) || !horarioValido)
                {
                    MessageBox.Show("Preencha todos os campos corretamente antes de continuar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                string query = "UPDATE horarios SET cliente_id = @cliente_id, data_hora = @data_hora, hora = @hora, descricao = @descricao, criado_por = @criado_por WHERE id = @id";

                using (var conn = Database.GetConnection())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("cliente_id", int.Parse(clienteId));
                    cmd.Parameters.AddWithValue("data_hora", dataHora);
                    cmd.Parameters.AddWithValue("hora", hora);
                    cmd.Parameters.AddWithValue("descricao", descricao);
                    cmd.Parameters.AddWithValue("criado_por", int.Parse(usuarioId));
                    cmd.Parameters.AddWithValue("id", int.Parse(horarioId));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Horário atualizado com sucesso!");
                HorarioEditado?.Invoke(); // Dispara evento pro UserControl atualizar a lista
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar horário: {ex.Message}");
            }
        }
    }
}
