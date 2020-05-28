using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'feriasDataSet.MarcaFerias'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaFeriasTableAdapter.Fill(this.feriasDataSet.MarcaFerias);
            // TODO: esta linha de código carrega dados na tabela 'credenciaisDataSet.cred'. Você pode movê-la ou removê-la conforme necessário.
            this.credTableAdapter.Fill(this.credenciaisDataSet.cred);

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
    }
}
