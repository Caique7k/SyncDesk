using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SyncDesk.Data;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class AdicionarHorarioForm : Form
    {
        public string usuarioId;
        public string usuarioNome;
        public string usuarioTipo;
       

        public class Cliente
        {
            public string Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
        public event Action HorarioAdicionado;
        public AdicionarHorarioForm(string nome, string id)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioId = id;
            label5.Text = usuarioNome;
            carregarClientes();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdicionarCliente();
        }

        private void carregarClientes()
        {
            string query = "SELECT id, nome FROM clientes";
            using (var conn = Database.GetConnection())
            {

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Cliente> clientes = new List<Cliente>(); // cria a lista de clientes

                        while (reader.Read())
                        {
                            clientes.Add(new Cliente // adiciona as informações na classe cliente
                            {
                                Id = reader["id"].ToString(),
                                Nome = reader["nome"].ToString()
                            });
                        }

                        comboBoxCliente.DataSource = clientes; // adiciona os clientes na listagem do combobox
                        comboBoxCliente.DisplayMember = "Nome";
                        comboBoxCliente.ValueMember = "Id";
                        comboBoxCliente.Refresh();

                    }


                }
            }
        }
        private void AdicionarCliente()
        {
            if (comboBoxCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente para adicionar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            Cliente clienteSelecionado = (Cliente)comboBoxCliente.SelectedItem; // pega o cliente selecionado
            string descricao = textBoxDesc.Text;
            DateTime dataHorario = dateTimePicker1.Value.Date;
            string horario = maskedTextBoxHorario.Text;

            bool horarioValido = TimeSpan.TryParseExact(horario, @"hh\:mm", null, out TimeSpan horarioConvertido);

            if (!horarioValido || horarioConvertido.TotalHours >= 24 || horarioConvertido.TotalMinutes < 0)
            {
                MessageBox.Show("Informe um horário válido entre 00:00 e 23:59.", "Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(descricao) || !horarioValido)
            {
                MessageBox.Show("Preencha todos os campos corretamente antes de continuar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string query = "INSERT INTO horarios (cliente_id, data_hora, descricao, criado_por, criado_em, hora) " +
                   "VALUES (@clienteId, @dataHora, @descricao, @criadoPor, @criadoEm, @Hora)";

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
                        cmd.Parameters.AddWithValue("@clienteId", int.Parse(clienteSelecionado.Id));
                        cmd.Parameters.AddWithValue("@dataHora", dataHorario);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@criadoPor", int.Parse(usuarioId));
                        cmd.Parameters.AddWithValue("@criadoEm", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Hora", horario);

                       


                        cmd.ExecuteNonQuery();
                        HorarioAdicionado?.Invoke();
                        MessageBox.Show("Horário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        this.Close();


                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar horário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


