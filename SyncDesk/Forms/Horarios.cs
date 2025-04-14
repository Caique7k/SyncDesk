using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class Horarios : UserControl
    {
        public string usuarioNome;
        public string usuarioTipo;
        public string usuarioId;

        public Horarios(string id, string nome)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioId = id;
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            AdicionarHorarioForm adicionarHorarioForm = new AdicionarHorarioForm(usuarioNome, usuarioId);
            adicionarHorarioForm.ShowDialog();
        }
    }
}
