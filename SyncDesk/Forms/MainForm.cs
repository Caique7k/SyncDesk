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
        public string usuarioId;
        public MainForm(string nome, string tipo, string usuarioId)
        {
            InitializeComponent();
            usuarioNome = nome;
            usuarioTipo = tipo;
            label1.Text = $"Bem vindo, {usuarioNome}";
            this.usuarioId = usuarioId;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadContent(new Dashboard());
        }

        private void LoadContent(UserControl control) // Função para carregar o conteúdo no painel
        {
            panelContent.Controls.Clear();  // Limpa o conteúdo atual
            control.Dock = DockStyle.Fill;  // Ajusta ao tamanho do painel
            panelContent.Controls.Add(control);  // Adiciona o novo UserControl
        }

        private void lblsair_Click(object sender, EventArgs e)
        {
            Logout();//chama a função de logout
        }

        private void picturesair_Click(object sender, EventArgs e)
        {
            Logout();//chama a função de logout
        }

        //função para fazer logout
        public static void Logout()
        {
            Application.Restart();// reinicia a aplicação (eficiente para limpar a memória em uso)

        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {
            LoadContent(new Dashboard());
        }

        private void picturedashboard_Click(object sender, EventArgs e)
        {
            LoadContent(new Dashboard());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadContent(new Clientes(usuarioNome, usuarioId));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadContent(new Clientes(usuarioNome, usuarioId));
        }

        private void lblhorarios_Click(object sender, EventArgs e)
        {
            LoadContent(new Horarios());
        }

        private void pictureHorarios_Click(object sender, EventArgs e)
        {
            LoadContent(new Horarios());
        }

        private void lblentrada_Click(object sender, EventArgs e)
        {
            LoadContent(new Entradas());
        }

        private void pictureEntrada_Click(object sender, EventArgs e)
        {
            LoadContent(new Entradas());
        }

        private void lblsaida_Click(object sender, EventArgs e)
        {
            LoadContent(new Saida());
        }

        private void pictureSaida_Click(object sender, EventArgs e)
        {
            LoadContent(new Saida());
        }

        private void lblusuarios_Click(object sender, EventArgs e)
        {
            LoadContent(new Usuario());
        }

        private void pictureUsuario_Click(object sender, EventArgs e)
        {
            LoadContent(new Usuario());
        }
    }
}
