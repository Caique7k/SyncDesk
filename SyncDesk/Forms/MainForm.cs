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
using SyncDesk.SyncDesk.Forms;
using static SyncDesk.SyncDesk.Forms.LoginForm;

namespace SyncDesk.SyncDesk.Forms
{
    public partial class MainForm : Form
    {
        public string usuarioNome;
        public string usuarioTipo;
        public MainForm(string nome, string tipo)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioTipo = tipo;
            label1.Text = $"Bem vindo, {usuarioNome}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
