namespace trabalho_final
{
    partial class FrmFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codfuncionarioLabel;
            System.Windows.Forms.Label nomefuncionarioLabel;
            System.Windows.Forms.Label numerocasaLabel;
            System.Windows.Forms.Label codrua_fkLabel;
            System.Windows.Forms.Label codbairro_fkLabel;
            System.Windows.Forms.Label codcep_fkLabel;
            System.Windows.Forms.Label codcidade_fkLabel;
            System.Windows.Forms.Label codfuncao_fkLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label codloja_fkLabel;
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.funcionariosTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.codfuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.vw_funcionariosDataGridView = new System.Windows.Forms.DataGridView();
            this.vwfuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomebairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefuncaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomelojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.vw_funcionariosTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_funcionariosTableAdapter();
            this.vw_funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtLoja = new System.Windows.Forms.ComboBox();
            this.TxtFuncao = new System.Windows.Forms.ComboBox();
            this.TxtCidade = new System.Windows.Forms.ComboBox();
            this.TxtCEP = new System.Windows.Forms.ComboBox();
            this.TxtBairro = new System.Windows.Forms.ComboBox();
            this.TxtRua = new System.Windows.Forms.ComboBox();
            this.ruaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruaTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.ruaTableAdapter();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bairroTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.bairroTableAdapter();
            this.cepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cepTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.cepTableAdapter();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.cidadeTableAdapter();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcaoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.funcaoTableAdapter();
            this.lojaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.lojaTableAdapter();
            codfuncionarioLabel = new System.Windows.Forms.Label();
            nomefuncionarioLabel = new System.Windows.Forms.Label();
            numerocasaLabel = new System.Windows.Forms.Label();
            codrua_fkLabel = new System.Windows.Forms.Label();
            codbairro_fkLabel = new System.Windows.Forms.Label();
            codcep_fkLabel = new System.Windows.Forms.Label();
            codcidade_fkLabel = new System.Windows.Forms.Label();
            codfuncao_fkLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            codloja_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_funcionariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwfuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = this.bairroTableAdapter;
            this.tableAdapterManager.cepTableAdapter = this.cepTableAdapter;
            this.tableAdapterManager.cidadeTableAdapter = this.cidadeTableAdapter;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraprodutoTableAdapter = null;
            this.tableAdapterManager.controlelogsistemaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = this.funcaoTableAdapter;
            this.tableAdapterManager.funcionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.imagensTableAdapter = null;
            this.tableAdapterManager.itensacessologinTableAdapter = null;
            this.tableAdapterManager.itenscompraprodutoTableAdapter = null;
            this.tableAdapterManager.itenstelclienteTableAdapter = null;
            this.tableAdapterManager.itenstelefonefornecedorTableAdapter = null;
            this.tableAdapterManager.itenstelefonefuncionarioTableAdapter = null;
            this.tableAdapterManager.itenstelefonelojaTableAdapter = null;
            this.tableAdapterManager.itenstelefonetrabalhoTableAdapter = null;
            this.tableAdapterManager.itensvendaprodutoTableAdapter = null;
            this.tableAdapterManager.logarTableAdapter = null;
            this.tableAdapterManager.lojaTableAdapter = this.lojaTableAdapter;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.operadoraTableAdapter = null;
            this.tableAdapterManager.parcelacompraTableAdapter = null;
            this.tableAdapterManager.parcelavendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = this.ruaTableAdapter;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.situacaoTableAdapter = null;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // codfuncionarioLabel
            // 
            codfuncionarioLabel.AutoSize = true;
            codfuncionarioLabel.Location = new System.Drawing.Point(9, 330);
            codfuncionarioLabel.Name = "codfuncionarioLabel";
            codfuncionarioLabel.Size = new System.Drawing.Size(43, 13);
            codfuncionarioLabel.TabIndex = 1;
            codfuncionarioLabel.Text = "Código:";
            // 
            // codfuncionarioTextBox
            // 
            this.codfuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "codfuncionario", true));
            this.codfuncionarioTextBox.Enabled = false;
            this.codfuncionarioTextBox.Location = new System.Drawing.Point(12, 346);
            this.codfuncionarioTextBox.Name = "codfuncionarioTextBox";
            this.codfuncionarioTextBox.Size = new System.Drawing.Size(54, 20);
            this.codfuncionarioTextBox.TabIndex = 2;
            // 
            // nomefuncionarioLabel
            // 
            nomefuncionarioLabel.AutoSize = true;
            nomefuncionarioLabel.Location = new System.Drawing.Point(69, 331);
            nomefuncionarioLabel.Name = "nomefuncionarioLabel";
            nomefuncionarioLabel.Size = new System.Drawing.Size(38, 13);
            nomefuncionarioLabel.TabIndex = 3;
            nomefuncionarioLabel.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "nomefuncionario", true));
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(72, 346);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(135, 20);
            this.TxtNome.TabIndex = 4;
            // 
            // numerocasaLabel
            // 
            numerocasaLabel.AutoSize = true;
            numerocasaLabel.Location = new System.Drawing.Point(337, 330);
            numerocasaLabel.Name = "numerocasaLabel";
            numerocasaLabel.Size = new System.Drawing.Size(47, 13);
            numerocasaLabel.TabIndex = 5;
            numerocasaLabel.Text = "Número:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "numerocasa", true));
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(340, 346);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(68, 20);
            this.TxtNumero.TabIndex = 6;
            // 
            // codrua_fkLabel
            // 
            codrua_fkLabel.AutoSize = true;
            codrua_fkLabel.Location = new System.Drawing.Point(210, 330);
            codrua_fkLabel.Name = "codrua_fkLabel";
            codrua_fkLabel.Size = new System.Drawing.Size(30, 13);
            codrua_fkLabel.TabIndex = 7;
            codrua_fkLabel.Text = "Rua:";
            // 
            // codbairro_fkLabel
            // 
            codbairro_fkLabel.AutoSize = true;
            codbairro_fkLabel.Location = new System.Drawing.Point(411, 329);
            codbairro_fkLabel.Name = "codbairro_fkLabel";
            codbairro_fkLabel.Size = new System.Drawing.Size(37, 13);
            codbairro_fkLabel.TabIndex = 9;
            codbairro_fkLabel.Text = "Bairro:";
            // 
            // codcep_fkLabel
            // 
            codcep_fkLabel.AutoSize = true;
            codcep_fkLabel.Location = new System.Drawing.Point(538, 330);
            codcep_fkLabel.Name = "codcep_fkLabel";
            codcep_fkLabel.Size = new System.Drawing.Size(31, 13);
            codcep_fkLabel.TabIndex = 11;
            codcep_fkLabel.Text = "CEP:";
            // 
            // codcidade_fkLabel
            // 
            codcidade_fkLabel.AutoSize = true;
            codcidade_fkLabel.Location = new System.Drawing.Point(665, 330);
            codcidade_fkLabel.Name = "codcidade_fkLabel";
            codcidade_fkLabel.Size = new System.Drawing.Size(43, 13);
            codcidade_fkLabel.TabIndex = 13;
            codcidade_fkLabel.Text = "Cidade:";
            // 
            // codfuncao_fkLabel
            // 
            codfuncao_fkLabel.AutoSize = true;
            codfuncao_fkLabel.Location = new System.Drawing.Point(792, 331);
            codfuncao_fkLabel.Name = "codfuncao_fkLabel";
            codfuncao_fkLabel.Size = new System.Drawing.Size(46, 13);
            codfuncao_fkLabel.TabIndex = 15;
            codfuncao_fkLabel.Text = "Função:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(919, 331);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 17;
            salarioLabel.Text = "Salário:";
            // 
            // TxtSalario
            // 
            this.TxtSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "salario", true));
            this.TxtSalario.Enabled = false;
            this.TxtSalario.Location = new System.Drawing.Point(922, 347);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(79, 20);
            this.TxtSalario.TabIndex = 18;
            // 
            // codloja_fkLabel
            // 
            codloja_fkLabel.AutoSize = true;
            codloja_fkLabel.Location = new System.Drawing.Point(1004, 330);
            codloja_fkLabel.Name = "codloja_fkLabel";
            codloja_fkLabel.Size = new System.Drawing.Size(30, 13);
            codloja_fkLabel.TabIndex = 19;
            codloja_fkLabel.Text = "Loja:";
            // 
            // vw_funcionariosDataGridView
            // 
            this.vw_funcionariosDataGridView.AutoGenerateColumns = false;
            this.vw_funcionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_funcionariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codfuncionarioDataGridViewTextBoxColumn,
            this.nomefuncionarioDataGridViewTextBoxColumn,
            this.nomeruaDataGridViewTextBoxColumn,
            this.numerocasaDataGridViewTextBoxColumn,
            this.nomebairroDataGridViewTextBoxColumn,
            this.numerocepDataGridViewTextBoxColumn,
            this.nomecidadeDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.nomefuncaoDataGridViewTextBoxColumn,
            this.nomelojaDataGridViewTextBoxColumn});
            this.vw_funcionariosDataGridView.DataSource = this.vwfuncionariosBindingSource;
            this.vw_funcionariosDataGridView.Enabled = false;
            this.vw_funcionariosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vw_funcionariosDataGridView.Name = "vw_funcionariosDataGridView";
            this.vw_funcionariosDataGridView.Size = new System.Drawing.Size(1102, 220);
            this.vw_funcionariosDataGridView.TabIndex = 21;
            // 
            // vwfuncionariosBindingSource
            // 
            this.vwfuncionariosBindingSource.DataMember = "vw_funcionarios";
            this.vwfuncionariosBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // codfuncionarioDataGridViewTextBoxColumn
            // 
            this.codfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "codfuncionario";
            this.codfuncionarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codfuncionarioDataGridViewTextBoxColumn.Name = "codfuncionarioDataGridViewTextBoxColumn";
            this.codfuncionarioDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomefuncionarioDataGridViewTextBoxColumn
            // 
            this.nomefuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomefuncionarioDataGridViewTextBoxColumn.DataPropertyName = "nomefuncionario";
            this.nomefuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomefuncionarioDataGridViewTextBoxColumn.Name = "nomefuncionarioDataGridViewTextBoxColumn";
            // 
            // nomeruaDataGridViewTextBoxColumn
            // 
            this.nomeruaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeruaDataGridViewTextBoxColumn.DataPropertyName = "nomerua";
            this.nomeruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.nomeruaDataGridViewTextBoxColumn.Name = "nomeruaDataGridViewTextBoxColumn";
            // 
            // numerocasaDataGridViewTextBoxColumn
            // 
            this.numerocasaDataGridViewTextBoxColumn.DataPropertyName = "numerocasa";
            this.numerocasaDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numerocasaDataGridViewTextBoxColumn.Name = "numerocasaDataGridViewTextBoxColumn";
            this.numerocasaDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomebairroDataGridViewTextBoxColumn
            // 
            this.nomebairroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomebairroDataGridViewTextBoxColumn.DataPropertyName = "nomebairro";
            this.nomebairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.nomebairroDataGridViewTextBoxColumn.Name = "nomebairroDataGridViewTextBoxColumn";
            // 
            // numerocepDataGridViewTextBoxColumn
            // 
            this.numerocepDataGridViewTextBoxColumn.DataPropertyName = "numerocep";
            this.numerocepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.numerocepDataGridViewTextBoxColumn.Name = "numerocepDataGridViewTextBoxColumn";
            this.numerocepDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomecidadeDataGridViewTextBoxColumn
            // 
            this.nomecidadeDataGridViewTextBoxColumn.DataPropertyName = "nomecidade";
            this.nomecidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.nomecidadeDataGridViewTextBoxColumn.Name = "nomecidadeDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salário";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // nomefuncaoDataGridViewTextBoxColumn
            // 
            this.nomefuncaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomefuncaoDataGridViewTextBoxColumn.DataPropertyName = "nomefuncao";
            this.nomefuncaoDataGridViewTextBoxColumn.HeaderText = "Função";
            this.nomefuncaoDataGridViewTextBoxColumn.Name = "nomefuncaoDataGridViewTextBoxColumn";
            // 
            // nomelojaDataGridViewTextBoxColumn
            // 
            this.nomelojaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomelojaDataGridViewTextBoxColumn.DataPropertyName = "nomeloja";
            this.nomelojaDataGridViewTextBoxColumn.HeaderText = "Loja";
            this.nomelojaDataGridViewTextBoxColumn.Name = "nomelojaDataGridViewTextBoxColumn";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(628, 238);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 64;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Excluir.Location = new System.Drawing.Point(560, 238);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(62, 23);
            this.Excluir.TabIndex = 63;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEditar.Location = new System.Drawing.Point(492, 238);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 62;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNovo.Location = new System.Drawing.Point(424, 238);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 61;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(903, 238);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(46, 23);
            this.BtnUltimo.TabIndex = 60;
            this.BtnUltimo.Text = ">|";
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(225, 238);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(46, 23);
            this.BtnAnterior.TabIndex = 59;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(851, 238);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 58;
            this.BtnProximo.Text = ">>";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimeiro.Location = new System.Drawing.Point(173, 238);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(46, 23);
            this.BtnPrimeiro.TabIndex = 57;
            this.BtnPrimeiro.Text = "|<";
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // vw_funcionariosTableAdapter
            // 
            this.vw_funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // vw_funcionariosBindingSource
            // 
            this.vw_funcionariosBindingSource.DataMember = "vw_funcionarios";
            this.vw_funcionariosBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtLoja
            // 
            this.TxtLoja.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "codloja_fk", true));
            this.TxtLoja.DataSource = this.lojaBindingSource;
            this.TxtLoja.DisplayMember = "nomeloja";
            this.TxtLoja.Enabled = false;
            this.TxtLoja.FormattingEnabled = true;
            this.TxtLoja.Location = new System.Drawing.Point(1007, 346);
            this.TxtLoja.Name = "TxtLoja";
            this.TxtLoja.Size = new System.Drawing.Size(121, 21);
            this.TxtLoja.TabIndex = 87;
            this.TxtLoja.ValueMember = "codloja";
            // 
            // TxtFuncao
            // 
            this.TxtFuncao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "codfuncao_fk", true));
            this.TxtFuncao.DataSource = this.funcaoBindingSource;
            this.TxtFuncao.DisplayMember = "nomefuncao";
            this.TxtFuncao.Enabled = false;
            this.TxtFuncao.FormattingEnabled = true;
            this.TxtFuncao.Location = new System.Drawing.Point(795, 347);
            this.TxtFuncao.Name = "TxtFuncao";
            this.TxtFuncao.Size = new System.Drawing.Size(121, 21);
            this.TxtFuncao.TabIndex = 86;
            this.TxtFuncao.ValueMember = "codfuncao";
            // 
            // TxtCidade
            // 
            this.TxtCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "codcidade_fk", true));
            this.TxtCidade.DataSource = this.cidadeBindingSource;
            this.TxtCidade.DisplayMember = "nomecidade";
            this.TxtCidade.Enabled = false;
            this.TxtCidade.FormattingEnabled = true;
            this.TxtCidade.Location = new System.Drawing.Point(668, 346);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(121, 21);
            this.TxtCidade.TabIndex = 85;
            this.TxtCidade.ValueMember = "codcidade";
            // 
            // TxtCEP
            // 
            this.TxtCEP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "codcep_fk", true));
            this.TxtCEP.DataSource = this.cepBindingSource;
            this.TxtCEP.DisplayMember = "numerocep";
            this.TxtCEP.Enabled = false;
            this.TxtCEP.FormattingEnabled = true;
            this.TxtCEP.Location = new System.Drawing.Point(541, 346);
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(121, 21);
            this.TxtCEP.TabIndex = 84;
            this.TxtCEP.ValueMember = "codcep";
            // 
            // TxtBairro
            // 
            this.TxtBairro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "codbairro_fk", true));
            this.TxtBairro.DataSource = this.bairroBindingSource;
            this.TxtBairro.DisplayMember = "nomebairro";
            this.TxtBairro.Enabled = false;
            this.TxtBairro.FormattingEnabled = true;
            this.TxtBairro.Location = new System.Drawing.Point(414, 345);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(121, 21);
            this.TxtBairro.TabIndex = 83;
            this.TxtBairro.ValueMember = "codbairro";
            // 
            // TxtRua
            // 
            this.TxtRua.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "codrua_fk", true));
            this.TxtRua.DataSource = this.ruaBindingSource;
            this.TxtRua.DisplayMember = "nomerua";
            this.TxtRua.Enabled = false;
            this.TxtRua.FormattingEnabled = true;
            this.TxtRua.Location = new System.Drawing.Point(213, 345);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(121, 21);
            this.TxtRua.TabIndex = 82;
            this.TxtRua.ValueMember = "codrua";
            // 
            // ruaBindingSource
            // 
            this.ruaBindingSource.DataMember = "rua";
            this.ruaBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // ruaTableAdapter
            // 
            this.ruaTableAdapter.ClearBeforeFill = true;
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "bairro";
            this.bairroBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // cepBindingSource
            // 
            this.cepBindingSource.DataMember = "cep";
            this.cepBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // cepTableAdapter
            // 
            this.cepTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // funcaoBindingSource
            // 
            this.funcaoBindingSource.DataMember = "funcao";
            this.funcaoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // funcaoTableAdapter
            // 
            this.funcaoTableAdapter.ClearBeforeFill = true;
            // 
            // lojaBindingSource
            // 
            this.lojaBindingSource.DataMember = "loja";
            this.lojaBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // lojaTableAdapter
            // 
            this.lojaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 442);
            this.Controls.Add(this.TxtLoja);
            this.Controls.Add(this.TxtFuncao);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtCEP);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.vw_funcionariosDataGridView);
            this.Controls.Add(codfuncionarioLabel);
            this.Controls.Add(this.codfuncionarioTextBox);
            this.Controls.Add(nomefuncionarioLabel);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(numerocasaLabel);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(codrua_fkLabel);
            this.Controls.Add(codbairro_fkLabel);
            this.Controls.Add(codcep_fkLabel);
            this.Controls.Add(codcidade_fkLabel);
            this.Controls.Add(codfuncao_fkLabel);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(codloja_fkLabel);
            this.Name = "FrmFuncionarios";
            this.Text = "FrmFuncionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_funcionariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwfuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private sistema_unifunecDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codfuncionarioTextBox;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.DataGridView vw_funcionariosDataGridView;
        private System.Windows.Forms.BindingSource vwfuncionariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomebairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomelojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
        private sistema_unifunecDataSetTableAdapters.vw_funcionariosTableAdapter vw_funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource vw_funcionariosBindingSource;
        private System.Windows.Forms.ComboBox TxtLoja;
        private System.Windows.Forms.ComboBox TxtFuncao;
        private System.Windows.Forms.ComboBox TxtCidade;
        private System.Windows.Forms.ComboBox TxtCEP;
        private System.Windows.Forms.ComboBox TxtBairro;
        private System.Windows.Forms.ComboBox TxtRua;
        private sistema_unifunecDataSetTableAdapters.ruaTableAdapter ruaTableAdapter;
        private System.Windows.Forms.BindingSource ruaBindingSource;
        private sistema_unifunecDataSetTableAdapters.bairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private sistema_unifunecDataSetTableAdapters.cepTableAdapter cepTableAdapter;
        private System.Windows.Forms.BindingSource cepBindingSource;
        private sistema_unifunecDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private sistema_unifunecDataSetTableAdapters.funcaoTableAdapter funcaoTableAdapter;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private sistema_unifunecDataSetTableAdapters.lojaTableAdapter lojaTableAdapter;
        private System.Windows.Forms.BindingSource lojaBindingSource;
    }
}