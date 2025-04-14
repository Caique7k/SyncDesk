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
    public partial class AdicionarHorarioForm : Form
    {
        public string usuarioId;
        public string usuarioNome;
        public string usuarioTipo;


        public AdicionarHorarioForm(string nome, string id)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioId = id;
            label5.Text = usuarioNome;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Horário adicionado com sucesso!");
        }
    }
}
