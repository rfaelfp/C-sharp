using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace ferias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Fixar janela para não maximizar.
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'feriasDataSet.MarcaFerias'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void limparCampos_Click(object sender, EventArgs e)
        {
            // Atribui novos valores para os objetos fazendo com que seja iniciado como "limpos".
            txtNome.Text = "";
            txtcpf.Text = "";
            txtDataInicio.Text = System.DateTime.Now.ToShortDateString();
            txtDataFim.Text = System.DateTime.Now.ToShortDateString();
            if (txtFeminino.Checked)
            {
                txtFeminino.Checked = false;
                txtMasculino.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Criando string de conexão.
            SqlConnection conn = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=Ferias; User ID=sa;Password=167421es");

            // Declarando variável de string com o comando SQL de update.
            string SQL = "INSERT INTO MarcaFerias (Nome, Cpf, DataInicio, DataFim, sexo) values(@nome, @cpf, @datainicio, @datafim, @sexo)";

            // Instanciando a conexão passando a string de conexão e a string de insert
            SqlCommand c = new SqlCommand(SQL, conn);


            c.Parameters.AddWithValue("@nome", txtNome.Text);
            c.Parameters.AddWithValue("@cpf", txtcpf.Text);
            c.Parameters.AddWithValue("@datainicio", txtDataInicio.Text);
            c.Parameters.AddWithValue("@datafim", txtDataFim.Text);
            // Verificação do radio button para definir o valor passado para o banco (sexo).
            if (txtMasculino.Checked)
                c.Parameters.AddWithValue("@sexo", 'M');
            else
            {
                c.Parameters.AddWithValue("@sexo", 'F');
            }

            try
            {
                // Realizando abertura de conexão com o banco de dados, executando a query e fechando a conexão, ao final retorno de mensagem para o usuário.
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inclusão realizada!", "Sucesso");
                // Carrega o DataGridView atualizando o grid com a inclusão realizada.
                this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);
                
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void excluir_Click(object sender, EventArgs e)
        {
            // Realiza questionamento ao usuário para que confirme a exclusão.
            string confirmacao;
            confirmacao = "Tem certeza que deseja excluir o registro?";
            DialogResult resultadoMessege = MessageBox.Show(confirmacao, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // Caso a confirmação ocorra será executado a exclusão do registro.
            if (resultadoMessege == DialogResult.Yes)
            {
                if (dataGridView.Rows.Count > 0)
                // Consultando o valor do id do data grid view para passar como parâmetro.
                {
                    int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                    string valorId = Convert.ToString(selectedRow.Cells["id"].Value);

                    // Criando string de conexão.
                    SqlConnection conn = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=Ferias; User ID=sa;Password=167421es");

                    // Declarando variável de string com o comando SQL de update.
                    string SQL = $"delete MarcaFerias where id = {valorId}";

                    // Instanciando a conexão passando a string de conexão e a string de insert
                    SqlCommand c = new SqlCommand(SQL, conn);
                    try
                    {
                        // Abertura de conexão, execução do delete e atualização do data grid view;
                        conn.Open();
                        c.ExecuteNonQuery();
                        conn.Close();
                        this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);
                    }
                    catch (SqlException ex)
                    {
                        // Mostra o erro de exceção que seja relacionado ao banco de dados.
                        string msg;
                        msg = "Erro: " + ex.Message;
                        MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não há registro selecionado!");
                }
            }
            else
                {
                    MessageBox.Show("A rotina de exclusão foi cancelada!");
                }
        }
        public static void ThreadProc()
        {
            Application.Run(new Form2());
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
