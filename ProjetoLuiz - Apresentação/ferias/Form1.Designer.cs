namespace ferias
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.meuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaFeriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feriasDataSet = new ferias.FeriasDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasculino = new System.Windows.Forms.RadioButton();
            this.txtFeminino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.marcaFeriasTableAdapter = new ferias.FeriasDataSetTableAdapters.MarcaFeriasTableAdapter();
            this.credBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtDezDias = new System.Windows.Forms.RadioButton();
            this.txtQuinzeDias = new System.Windows.Forms.RadioButton();
            this.txtTrintaDias = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaFeriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataInicio.Location = new System.Drawing.Point(30, 138);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(224, 20);
            this.txtDataInicio.TabIndex = 4;
            // 
            // txtDataFim
            // 
            this.txtDataFim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataFim.Location = new System.Drawing.Point(332, 138);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataFim.Size = new System.Drawing.Size(219, 20);
            this.txtDataFim.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.inclusao);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.limparCampos_Click);
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(11, 24);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 0;
            // 
            // meuMenu
            // 
            this.meuMenu.Name = "contextMenuStrip1";
            this.meuMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.id});
            this.dataGridView.DataSource = this.marcaFeriasBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(8, 203);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(543, 260);
            this.dataGridView.TabIndex = 9;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "dataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "Data de Início";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            this.dataInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "dataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "Data de Fim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            this.dataFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // marcaFeriasBindingSource
            // 
            this.marcaFeriasBindingSource.DataMember = "MarcaFerias";
            this.marcaFeriasBindingSource.DataSource = this.feriasDataSet;
            // 
            // feriasDataSet
            // 
            this.feriasDataSet.DataSetName = "FeriasDataSet";
            this.feriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CPF";
            // 
            // txtMasculino
            // 
            this.txtMasculino.AutoSize = true;
            this.txtMasculino.Checked = true;
            this.txtMasculino.Location = new System.Drawing.Point(11, 109);
            this.txtMasculino.Name = "txtMasculino";
            this.txtMasculino.Size = new System.Drawing.Size(73, 17);
            this.txtMasculino.TabIndex = 2;
            this.txtMasculino.Text = "Masculino";
            this.txtMasculino.UseVisualStyleBackColor = true;
            // 
            // txtFeminino
            // 
            this.txtFeminino.AutoSize = true;
            this.txtFeminino.Location = new System.Drawing.Point(107, 109);
            this.txtFeminino.Name = "txtFeminino";
            this.txtFeminino.Size = new System.Drawing.Size(67, 17);
            this.txtFeminino.TabIndex = 3;
            this.txtFeminino.Text = "Feminino";
            this.txtFeminino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sexo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Excluir Reg.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.excluir_Click);
            // 
            // marcaFeriasTableAdapter
            // 
            this.marcaFeriasTableAdapter.ClearBeforeFill = true;
            // 
            // credBindingSource
            // 
            this.credBindingSource.DataMember = "cred";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(11, 62);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(87, 20);
            this.txtcpf.TabIndex = 1;
            // 
            // txtDezDias
            // 
            this.txtDezDias.AutoSize = true;
            this.txtDezDias.Location = new System.Drawing.Point(332, 109);
            this.txtDezDias.Name = "txtDezDias";
            this.txtDezDias.Size = new System.Drawing.Size(59, 17);
            this.txtDezDias.TabIndex = 26;
            this.txtDezDias.Text = "10 dias";
            this.txtDezDias.UseVisualStyleBackColor = true;
            this.txtDezDias.CheckedChanged += new System.EventHandler(this.atualizaDezDias);
            // 
            // txtQuinzeDias
            // 
            this.txtQuinzeDias.AutoSize = true;
            this.txtQuinzeDias.Location = new System.Drawing.Point(397, 109);
            this.txtQuinzeDias.Name = "txtQuinzeDias";
            this.txtQuinzeDias.Size = new System.Drawing.Size(59, 17);
            this.txtQuinzeDias.TabIndex = 27;
            this.txtQuinzeDias.Text = "15 dias";
            this.txtQuinzeDias.UseVisualStyleBackColor = true;
            this.txtQuinzeDias.CheckedChanged += new System.EventHandler(this.atualizaQuinzeDias);
            // 
            // txtTrintaDias
            // 
            this.txtTrintaDias.AutoSize = true;
            this.txtTrintaDias.Location = new System.Drawing.Point(462, 109);
            this.txtTrintaDias.Name = "txtTrintaDias";
            this.txtTrintaDias.Size = new System.Drawing.Size(59, 17);
            this.txtTrintaDias.TabIndex = 28;
            this.txtTrintaDias.Text = "30 dias";
            this.txtTrintaDias.UseVisualStyleBackColor = true;
            this.txtTrintaDias.CheckedChanged += new System.EventHandler(this.atualizaTrintaDias);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 473);
            this.Controls.Add(this.txtTrintaDias);
            this.Controls.Add(this.txtQuinzeDias);
            this.Controls.Add(this.txtDezDias);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFeminino);
            this.Controls.Add(this.txtMasculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.txtDataInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "Form1";
            this.Text = "Férias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaFeriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.DateTimePicker txtDataFim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ContextMenuStrip meuMenu;
        private System.Windows.Forms.BindingSource credBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private FeriasDataSet feriasDataSet;
        private System.Windows.Forms.BindingSource marcaFeriasBindingSource;
        private FeriasDataSetTableAdapters.MarcaFeriasTableAdapter marcaFeriasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton txtMasculino;
        private System.Windows.Forms.RadioButton txtFeminino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.RadioButton txtDezDias;
        private System.Windows.Forms.RadioButton txtQuinzeDias;
        private System.Windows.Forms.RadioButton txtTrintaDias;
    }
}

