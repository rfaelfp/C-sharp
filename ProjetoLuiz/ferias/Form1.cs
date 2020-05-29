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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'feriasDataSet.MarcaFerias'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);
            // TODO: esta linha de código carrega dados na tabela 'credenciaisDataSet.cred'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=Ferias; User ID=sa;Password=167421es");

            string SQL = "INSERT INTO MarcaFerias (Nome, Cpf, DataInicio, DataFim, sexo) values(@nome, @cpf, @datainicio, @datafim, @sexo)";

            SqlCommand c = new SqlCommand(SQL, conn);

            c.Parameters.AddWithValue("@nome", txtNome.Text);
            c.Parameters.AddWithValue("@cpf", txtcpf.Text);
            c.Parameters.AddWithValue("@datainicio", txtDataInicio.Text);
            c.Parameters.AddWithValue("@datafim", txtDataFim.Text);
            c.Parameters.AddWithValue("@sexo", 'M');

            try
            {
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCESSO!!", "Sucesso");
            }
            catch (SqlException ex)
            {
                string msg;

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
    }
}
