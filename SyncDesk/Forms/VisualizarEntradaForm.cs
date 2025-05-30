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
    public partial class VisualizarEntradaForm : Form
    {
        public VisualizarEntradaForm(string valorEntrada, string data, string descricao, string criado)
        {
            InitializeComponent();
            if (decimal.TryParse(valorEntrada, out decimal valor))
            {
                txtBoxValor.Text = valor.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                txtBoxValor.Text = valorEntrada; 
            }
            txtBoxData.Text = data;
            txtBoxDescricao.Text = descricao;
            label4.Text = criado;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
