using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class VisualizarHorarioForm : Form
    {
        public VisualizarHorarioForm(string nomeCliente, string data, string horario, string descricao, string criadoPor)
        {
            InitializeComponent();
            txtCliente.Text = nomeCliente;
            txtData.Text = data;
            txtHora.Text = horario;
            textBoxDesc.Text = descricao;
            label5.Text = criadoPor;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
