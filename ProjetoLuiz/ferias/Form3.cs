﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroFuncionarios._CadastroFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            // this.cadastroFuncionariosTableAdapter.Fill(this.cadastroFuncionarios._CadastroFuncionarios);

        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        private void atualizar (object sender, EventArgs e)
=======
        private void button2_Click(object sender, EventArgs e)
>>>>>>> 03e548645587099b0a93d5537e44ce13194bb4bc
        {
            this.cadastroFuncionariosTableAdapter.Fill(this.cadastroFuncionarios._CadastroFuncionarios);
        }
    }
}
