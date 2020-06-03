using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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


        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'feriasDataSet.MarcaFerias'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);

        }
        private void limparCampos()
        {
            // Define valores padrões para os campos da .
            txtNome.Text = "";
            txtcpf.Text = "";
            txtDataInicio.Text = System.DateTime.Now.ToShortDateString();
            txtDataFim.Text = System.DateTime.Now.ToShortDateString();
            if (txtFeminino.Checked == true)
            {
                txtFeminino.Checked = false;
                txtMasculino.Checked = true;
            }
            txtDezDias.Checked = false;
            txtQuinzeDias.Checked = false;
            txtTrintaDias.Checked = false;

        }
        private void limparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void inclusao(object sender, EventArgs e)
        {
            // Criando string de conexão.
            SqlConnection conn = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=Ferias; User ID=sa;Password=167421es");

            // Declarando variável de string com o comando SQL de update.
            string SQL = "INSERT INTO MarcaFerias (Nome, Cpf, DataInicio, DataFim, sexo) values(@nome, @cpf, @datainicio, @datafim, @sexo)";

            // Instanciando a conexão passando a string de conexão e a string de insert
            SqlCommand c = new SqlCommand(SQL, conn);

            

            // Verifica se campo nome está preenchido.
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Necessário preencher o nome.");
                return;
            }
            // Retira os valores da máscara do CPF.
            string cpfMod = txtcpf.Text.Replace(".", "").Replace("-", "");

            // Verifica se o campo CPF possui 11 dígitos.
            if (cpfMod.Length != 11)
            {
                MessageBox.Show("O CPF deve possuir 11 dígitos.");
                return;
            }
            if (txtDataInicio.Text == txtDataFim.Text)
            {
                MessageBox.Show("O período deve ser informado.");
                return;

            }
            c.Parameters.AddWithValue("@nome", txtNome.Text);
            c.Parameters.AddWithValue("@cpf", cpfMod);
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
                // Realizando abertura de conexão com o banco de dados, executando a query e fecha a conexão, finaliza com o retorno de mensagem para o usuário.
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inclusão realizada!", "Sucesso");
                // Carrega o DataGridView atualizando o grid com a inclusão realizada e chama o método que reinicia os valores padrões dos campos.
                this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);
                limparCampos();

            }
            catch (SqlException ex)
            {
                string msg;

                // Tratamento de constrain retornando mensagem mais agradável para usuário e caso haja outra mensagem de erro retornado pelo banco a emite.
                if (ex.Message.Contains("UQ__MarcaFer"))
                    msg = "Já existe um funcionário cadastrado com esse CPF";
                else
                    msg = "ERRO: " + ex.Message;

                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        // Carrega o DataGridView atualizando o grid com a inclusão realizada e chama o método que reinicia os valores padrões dos campos.
                        this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);
                        limparCampos();
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
        // Método para atualizar a data de acordo com o valor selecionado.
        private void atualizarDias(object sender, EventArgs e)
        {
            int dias;
            if (txtDezDias.Checked == true)
                dias = 10;
            else if (txtQuinzeDias.Checked == true)
                dias = 15;
            else
                dias = 30;
            DateTime dtInicio = DateTime.Parse(txtDataInicio.Text);
            DateTime resposta = dtInicio.AddDays(dias);
            txtDataFim.Text = Convert.ToString(resposta);
        }
        // Método para reiniciar os valores quando alterado a data inicial.
        private void valoresDias(object sender, EventArgs e)
        {
            txtDezDias.Checked = false;
            txtQuinzeDias.Checked = false;
            txtTrintaDias.Checked = false;
            txtDataFim.Text = txtDataInicio.Text;
        }
    }
}
