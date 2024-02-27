using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace first_chalenge
{
    public partial class tmenu : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public tmenu()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_login_classe_mdi;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            toolStripStatusLabel.Text = variaveis.usuario;
        }

        private void usuárioSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
