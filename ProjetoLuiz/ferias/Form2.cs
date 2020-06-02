using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ferias
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
        }
        public static void ThreadProc()
        {
            Application.Run(new Form3());
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            // Criando string de conexão.
            SqlConnection conn = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=Ferias; User ID=sa;Password=167421es");

            // Declarando variável de string com o comando SQL de update.
            string SQL = "INSERT INTO CadastroFuncionarios (Nome, Cpf, Email, Celular, Sexo, Endereco, Bairro, Numero, Cep) values(@nome, @cpf, @email, @celular, @sexo, @endereco, @bairro, @numero, @cep)";

            // Instanciando a conexão passando a string de conexão e a string de insert
            SqlCommand c = new SqlCommand(SQL, conn);


            c.Parameters.AddWithValue("@nome", txtNome.Text);
            c.Parameters.AddWithValue("@cpf", txtCPF.Text);
            c.Parameters.AddWithValue("@email", txtEmail.Text);
            c.Parameters.AddWithValue("@celular", txtCelular.Text);
            // Verificação do radio button para definir o valor passado para o banco (sexo).
            if (txtMasculino.Checked)
                c.Parameters.AddWithValue("@sexo", 'M');
            else
            {
                c.Parameters.AddWithValue("@sexo", 'F');
            }
            c.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            c.Parameters.AddWithValue("@bairro", txtBairro.Text);
            c.Parameters.AddWithValue("@numero", txtNumero.Text);
            c.Parameters.AddWithValue("@cep", txtCep.Text);

            try
            {
                // Realizando abertura de conexão com o banco de dados, executando a query e fechando a conexão, ao final retorno de mensagem para o usuário.
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inclusão realizada!", "Sucesso");
                // Carrega o DataGridView atualizando o grid com a inclusão realizada.

            }
            catch (SqlException ex)
            {
                string msg;

                // Tratamento de constrain retornando mensagem mais agradável para usuário.
                if (ex.Message.Contains("UQ__MarcaFer"))
                    msg = "Já existe um funcionário cadastrado com esse CPF";
                else if (ex.Message.Contains("un_nome"))
                    msg = "Já existe um funcionário cadastrado com esse nome!";
                else if (ex.Message.Contains("FK_DEPT"))
                    msg = "Informe um departamento válido!";
                else
                    msg = "ERRO: " + ex.Message;

                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
