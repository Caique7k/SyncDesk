using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class FormVisualizarSaida : Form
    {
        public FormVisualizarSaida(string valorSaida, string data, string descricao, string criado)
        {
            InitializeComponent();
            if (decimal.TryParse(valorSaida, out decimal valor))
            {
                txtBoxValor.Text = valor.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                txtBoxValor.Text = valorSaida;
            }
            txtBoxData.Text = data;
            txtBoxDescricao.Text = descricao;
            label4.Text = criado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
