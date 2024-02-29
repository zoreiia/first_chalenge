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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace first_chalenge
{


    public partial class tcadastro : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string escolha;
        string id;


        public tcadastro()
        {
            servidor = "Server=localhost;Database=bd_login_classe_mdi;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            InitializeComponent();
            atualiza_lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttoncadastrar.Text == "Salvar")
            {

                DialogResult messageescolha = MessageBox.Show("Deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageescolha == DialogResult.Yes)
                {
                    try
                    {
                        if (radioButtonadm.Checked)
                        {
                            escolha = "Administrador";
                        }
                        else
                        {
                            escolha = "Usuário";
                        }

                        conexao.Open();
                        comando.CommandText = "UPDATE tbl_login SET nome = '" + textBoxnome.Text + "', senha = '" + textBoxsenha.Text + "', usuario = '" + textBoxuser.Text + "', nivel = '" + escolha + "' WHERE  id = " + id + ";";
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Alterado com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Contato não encontrado");
                        }
                    }
                    catch (Exception erro_mysql)
                    {
                        MessageBox.Show(erro_mysql.Message);
                    }
                    finally
                    {
                        textBoxnome.Clear(); textBoxsenha.Clear(); textBoxuser.Clear(); radioButtonadm.Checked = false; radioButtonuser.Checked = false;
                        conexao.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelado com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                buttoncadastrar.Text = "Cadastrar";
            }
            else
            {
                try
                {
                    if (radioButtonadm.Checked)
                    {
                        escolha = "Administrador";
                    }
                    else
                    {
                        escolha = "Usuário";
                    }
                    if (textBoxnome.Text != "" && textBoxsenha.Text != "")
                    {
                        conexao.Open();
                        comando.CommandText = "INSERT INTO tbl_login(nome,senha,usuario,nivel) VALUES('" + textBoxnome.Text + "', '" + textBoxsenha.Text + "', '" + textBoxuser.Text + "', '" + escolha + "');";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastrado");

                    }
                    else
                    {
                        MessageBox.Show("Campos Nome e Senha obrigatórios.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (Exception erro_mysql)
                {
                    //MessageBox.Show(erro_mysql.Message);
                    MessageBox.Show("Erro de Sistema. Informe o suporte");
                }
                finally
                {
                    conexao.Close();
                    textBoxnome.Clear(); textBoxsenha.Clear(); textBoxuser.Clear(); radioButtonadm.Checked = false; radioButtonuser.Checked = false;
                }

            }
            buttonalterar.Enabled = true;
            buttonexcluir.Enabled = true;
            atualiza_lista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonalterar.Enabled = false;
            buttonexcluir.Enabled = false;
            buttoncadastrar.Text = "Salvar";


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxnome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxuser.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxsenha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Usuário")
            {
                radioButtonuser.Checked = true;
            }
            else
            {
                radioButtonadm.Checked = true;
            }

        }

        private void atualiza_lista()
        {
            try
            {

                conexao.Open();

                comando.CommandText = "SELECT * FROM tbl_login;";
                MySqlDataAdapter adaptadoruser = new MySqlDataAdapter(comando);
                DataTable tabelauser = new DataTable();
                adaptadoruser.Fill(tabelauser);
                dataGridView1.DataSource = tabelauser;



            }
            catch (Exception erro_mysql)
            {

                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {

                conexao.Close();
            }
            


        }

        private void buttonexcluir_Click(object sender, EventArgs e)
        {
            try
            {

                conexao.Open();
                comando.CommandText = "DELETE FROM tbl_login WHERE id = " + id + ";";
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Usuário Excluido com Sucesso!!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }

            }
            catch (Exception erro_mysql)
            {

                MessageBox.Show("Erro de Sistema. Informe o suporte");

            }
            finally
            {
                textBoxnome.Clear(); textBoxsenha.Clear(); textBoxuser.Clear(); radioButtonadm.Checked = false; radioButtonuser.Checked = false;
                conexao.Close();

            }
            atualiza_lista();
        }
    }
}
