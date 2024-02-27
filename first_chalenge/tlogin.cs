using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_chalenge
{
    public partial class tlogin : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;


        public tlogin()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_login_classe_mdi;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha, nivel FROM tbl_login WHERE usuario = '" + textBoxuser.Text + "' AND senha = '" + textBoxsenha.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    variaveis.usuario = "Usuário: " + resultado.GetString("usuario") + " | Nível: " + resultado.GetString("nivel");
                    MessageBox.Show("Usuário e Senha corretos!");
                    this.Hide();
                    Form telalogin = new tmenu();
                    telalogin.Closed += (s, args) => this.Close();
                    telalogin.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
