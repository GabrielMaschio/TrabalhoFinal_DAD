namespace trabalho_final
{
    partial class FrmCompraProduto
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
            System.Windows.Forms.Label codcompraLabel;
            System.Windows.Forms.Label datacompraLabel;
            System.Windows.Forms.Label codfornecedor_fkLabel;
            System.Windows.Forms.Label codfuncionario_fkLabel;
            System.Windows.Forms.Label codcompra_fkLabel;
            System.Windows.Forms.Label codproduto_fkLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorcLabel;
            this.TxtCodCompra = new System.Windows.Forms.TextBox();
            this.compraprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.TxtData = new System.Windows.Forms.DateTimePicker();
            this.TxtFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtFuncionario = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.vw_itenscompraprodutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vw_itenscompraprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCodigoCompra = new System.Windows.Forms.TextBox();
            this.itenscompraprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoxAddProduto = new System.Windows.Forms.GroupBox();
            this.BtnSalvarP = new System.Windows.Forms.Button();
            this.BtnExcluirP = new System.Windows.Forms.Button();
            this.BtnNovoP = new System.Windows.Forms.Button();
            this.vw_compraprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_compraprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_compraprodutoTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.compraprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.compraprodutoTableAdapter();
            this.vw_itenscompraprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_itenscompraprodutoTableAdapter();
            this.fornecedorTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.fornecedorTableAdapter();
            this.funcionariosTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.funcionariosTableAdapter();
            this.itenscompraprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.itenscompraprodutoTableAdapter();
            this.produtoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.produtoTableAdapter();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parcelacompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelacompraTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.parcelacompraTableAdapter();
            codcompraLabel = new System.Windows.Forms.Label();
            datacompraLabel = new System.Windows.Forms.Label();
            codfornecedor_fkLabel = new System.Windows.Forms.Label();
            codfuncionario_fkLabel = new System.Windows.Forms.Label();
            codcompra_fkLabel = new System.Windows.Forms.Label();
            codproduto_fkLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorcLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compraprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itenscompraprodutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itenscompraprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenscompraprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.BoxAddProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_compraprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelacompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codcompraLabel
            // 
            codcompraLabel.AutoSize = true;
            codcompraLabel.Location = new System.Drawing.Point(9, 12);
            codcompraLabel.Name = "codcompraLabel";
            codcompraLabel.Size = new System.Drawing.Size(43, 13);
            codcompraLabel.TabIndex = 1;
            codcompraLabel.Text = "Código:";
            // 
            // datacompraLabel
            // 
            datacompraLabel.AutoSize = true;
            datacompraLabel.Location = new System.Drawing.Point(86, 12);
            datacompraLabel.Name = "datacompraLabel";
            datacompraLabel.Size = new System.Drawing.Size(30, 13);
            datacompraLabel.TabIndex = 3;
            datacompraLabel.Text = "Data";
            // 
            // codfornecedor_fkLabel
            // 
            codfornecedor_fkLabel.AutoSize = true;
            codfornecedor_fkLabel.Location = new System.Drawing.Point(192, 11);
            codfornecedor_fkLabel.Name = "codfornecedor_fkLabel";
            codfornecedor_fkLabel.Size = new System.Drawing.Size(64, 13);
            codfornecedor_fkLabel.TabIndex = 5;
            codfornecedor_fkLabel.Text = "Fornecedor:";
            // 
            // codfuncionario_fkLabel
            // 
            codfuncionario_fkLabel.AutoSize = true;
            codfuncionario_fkLabel.Location = new System.Drawing.Point(319, 12);
            codfuncionario_fkLabel.Name = "codfuncionario_fkLabel";
            codfuncionario_fkLabel.Size = new System.Drawing.Size(65, 13);
            codfuncionario_fkLabel.TabIndex = 7;
            codfuncionario_fkLabel.Text = "Funcionário:";
            // 
            // codcompra_fkLabel
            // 
            codcompra_fkLabel.AutoSize = true;
            codcompra_fkLabel.Location = new System.Drawing.Point(3, 21);
            codcompra_fkLabel.Name = "codcompra_fkLabel";
            codcompra_fkLabel.Size = new System.Drawing.Size(43, 13);
            codcompra_fkLabel.TabIndex = 48;
            codcompra_fkLabel.Text = "Código:";
            // 
            // codproduto_fkLabel
            // 
            codproduto_fkLabel.AutoSize = true;
            codproduto_fkLabel.Location = new System.Drawing.Point(75, 21);
            codproduto_fkLabel.Name = "codproduto_fkLabel";
            codproduto_fkLabel.Size = new System.Drawing.Size(47, 13);
            codproduto_fkLabel.TabIndex = 50;
            codproduto_fkLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(202, 21);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 52;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorcLabel
            // 
            valorcLabel.AutoSize = true;
            valorcLabel.Location = new System.Drawing.Point(308, 21);
            valorcLabel.Name = "valorcLabel";
            valorcLabel.Size = new System.Drawing.Size(34, 13);
            valorcLabel.TabIndex = 54;
            valorcLabel.Text = "Valor:";
            // 
            // TxtCodCompra
            // 
            this.TxtCodCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraprodutoBindingSource, "codcompra", true));
            this.TxtCodCompra.Enabled = false;
            this.TxtCodCompra.Location = new System.Drawing.Point(12, 28);
            this.TxtCodCompra.Name = "TxtCodCompra";
            this.TxtCodCompra.Size = new System.Drawing.Size(71, 20);
            this.TxtCodCompra.TabIndex = 2;
            // 
            // compraprodutoBindingSource
            // 
            this.compraprodutoBindingSource.DataMember = "compraproduto";
            this.compraprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtData
            // 
            this.TxtData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraprodutoBindingSource, "datacompra", true));
            this.TxtData.Enabled = false;
            this.TxtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData.Location = new System.Drawing.Point(89, 28);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(100, 20);
            this.TxtData.TabIndex = 4;
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compraprodutoBindingSource, "codfornecedor_fk", true));
            this.TxtFornecedor.DataSource = this.fornecedorBindingSource;
            this.TxtFornecedor.DisplayMember = "nomefornecedor";
            this.TxtFornecedor.Enabled = false;
            this.TxtFornecedor.FormattingEnabled = true;
            this.TxtFornecedor.Location = new System.Drawing.Point(195, 27);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(121, 21);
            this.TxtFornecedor.TabIndex = 8;
            this.TxtFornecedor.ValueMember = "codfornecedor";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtFuncionario
            // 
            this.TxtFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compraprodutoBindingSource, "codfuncionario_fk", true));
            this.TxtFuncionario.DataSource = this.funcionariosBindingSource;
            this.TxtFuncionario.DisplayMember = "nomefuncionario";
            this.TxtFuncionario.Enabled = false;
            this.TxtFuncionario.FormattingEnabled = true;
            this.TxtFuncionario.Location = new System.Drawing.Point(322, 27);
            this.TxtFuncionario.Name = "TxtFuncionario";
            this.TxtFuncionario.Size = new System.Drawing.Size(121, 21);
            this.TxtFuncionario.TabIndex = 9;
            this.TxtFuncionario.ValueMember = "codfuncionario";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(345, 64);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(46, 23);
            this.BtnAnterior.TabIndex = 47;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(397, 64);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 46;
            this.BtnProximo.Text = ">>";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(216, 64);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 44;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluir.Location = new System.Drawing.Point(148, 64);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(62, 23);
            this.BtnExcluir.TabIndex = 43;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEditar.Location = new System.Drawing.Point(80, 64);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 42;
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
            this.BtnNovo.Location = new System.Drawing.Point(12, 64);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 41;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // vw_itenscompraprodutoDataGridView
            // 
            this.vw_itenscompraprodutoDataGridView.AutoGenerateColumns = false;
            this.vw_itenscompraprodutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_itenscompraprodutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vw_itenscompraprodutoDataGridView.DataSource = this.vw_itenscompraprodutoBindingSource;
            this.vw_itenscompraprodutoDataGridView.Location = new System.Drawing.Point(12, 262);
            this.vw_itenscompraprodutoDataGridView.Name = "vw_itenscompraprodutoDataGridView";
            this.vw_itenscompraprodutoDataGridView.Size = new System.Drawing.Size(575, 220);
            this.vw_itenscompraprodutoDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "codcompra_fk";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nomeproduto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto:";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantidade:";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valorc";
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor:";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // vw_itenscompraprodutoBindingSource
            // 
            this.vw_itenscompraprodutoBindingSource.DataMember = "vw_itenscompraproduto";
            this.vw_itenscompraprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtCodigoCompra
            // 
            this.TxtCodigoCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itenscompraprodutoBindingSource, "codcompra_fk", true));
            this.TxtCodigoCompra.Enabled = false;
            this.TxtCodigoCompra.Location = new System.Drawing.Point(6, 37);
            this.TxtCodigoCompra.Name = "TxtCodigoCompra";
            this.TxtCodigoCompra.Size = new System.Drawing.Size(65, 20);
            this.TxtCodigoCompra.TabIndex = 49;
            this.TxtCodigoCompra.TextChanged += new System.EventHandler(this.TxtCodigoCompra_TextChanged);
            // 
            // itenscompraprodutoBindingSource
            // 
            this.itenscompraprodutoBindingSource.DataMember = "itenscompraproduto";
            this.itenscompraprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itenscompraprodutoBindingSource, "quantidade", true));
            this.TxtQuantidade.Enabled = false;
            this.TxtQuantidade.Location = new System.Drawing.Point(204, 37);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade.TabIndex = 53;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.TxtQuantidade_TextChanged);
            // 
            // TxtValor
            // 
            this.TxtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itenscompraprodutoBindingSource, "valorc", true));
            this.TxtValor.Enabled = false;
            this.TxtValor.Location = new System.Drawing.Point(310, 37);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 55;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // TxtProduto
            // 
            this.TxtProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itenscompraprodutoBindingSource, "codproduto_fk", true));
            this.TxtProduto.DataSource = this.produtoBindingSource;
            this.TxtProduto.DisplayMember = "nomeproduto";
            this.TxtProduto.Enabled = false;
            this.TxtProduto.FormattingEnabled = true;
            this.TxtProduto.Location = new System.Drawing.Point(77, 37);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(121, 21);
            this.TxtProduto.TabIndex = 56;
            this.TxtProduto.ValueMember = "codproduto";
            this.TxtProduto.Leave += new System.EventHandler(this.TxtProduto_Leave);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // BoxAddProduto
            // 
            this.BoxAddProduto.Controls.Add(this.BtnSalvarP);
            this.BoxAddProduto.Controls.Add(this.TxtCodigoCompra);
            this.BoxAddProduto.Controls.Add(this.BtnExcluirP);
            this.BoxAddProduto.Controls.Add(codcompra_fkLabel);
            this.BoxAddProduto.Controls.Add(this.BtnNovoP);
            this.BoxAddProduto.Controls.Add(codproduto_fkLabel);
            this.BoxAddProduto.Controls.Add(this.TxtProduto);
            this.BoxAddProduto.Controls.Add(quantidadeLabel);
            this.BoxAddProduto.Controls.Add(this.TxtValor);
            this.BoxAddProduto.Controls.Add(valorcLabel);
            this.BoxAddProduto.Controls.Add(this.TxtQuantidade);
            this.BoxAddProduto.Enabled = false;
            this.BoxAddProduto.Location = new System.Drawing.Point(12, 119);
            this.BoxAddProduto.Name = "BoxAddProduto";
            this.BoxAddProduto.Size = new System.Drawing.Size(575, 119);
            this.BoxAddProduto.TabIndex = 57;
            this.BoxAddProduto.TabStop = false;
            this.BoxAddProduto.Text = "Adicionar Produto";
            // 
            // BtnSalvarP
            // 
            this.BtnSalvarP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvarP.Enabled = false;
            this.BtnSalvarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvarP.Location = new System.Drawing.Point(154, 75);
            this.BtnSalvarP.Name = "BtnSalvarP";
            this.BtnSalvarP.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvarP.TabIndex = 61;
            this.BtnSalvarP.Text = "Salvar";
            this.BtnSalvarP.UseVisualStyleBackColor = false;
            this.BtnSalvarP.Click += new System.EventHandler(this.BtnSalvarP_Click);
            // 
            // BtnExcluirP
            // 
            this.BtnExcluirP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExcluirP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluirP.Location = new System.Drawing.Point(77, 75);
            this.BtnExcluirP.Name = "BtnExcluirP";
            this.BtnExcluirP.Size = new System.Drawing.Size(62, 23);
            this.BtnExcluirP.TabIndex = 60;
            this.BtnExcluirP.Text = "Excluir";
            this.BtnExcluirP.UseVisualStyleBackColor = false;
            this.BtnExcluirP.Click += new System.EventHandler(this.BtnExcluirP_Click);
            // 
            // BtnNovoP
            // 
            this.BtnNovoP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNovoP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNovoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovoP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNovoP.Location = new System.Drawing.Point(6, 75);
            this.BtnNovoP.Name = "BtnNovoP";
            this.BtnNovoP.Size = new System.Drawing.Size(62, 23);
            this.BtnNovoP.TabIndex = 58;
            this.BtnNovoP.Text = "Novo";
            this.BtnNovoP.UseVisualStyleBackColor = false;
            this.BtnNovoP.Click += new System.EventHandler(this.BtnNovoP_Click);
            // 
            // vw_compraprodutoBindingSource
            // 
            this.vw_compraprodutoBindingSource.DataMember = "vw_compraproduto";
            this.vw_compraprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vw_compraprodutoTableAdapter
            // 
            this.vw_compraprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraprodutoTableAdapter = this.compraprodutoTableAdapter;
            this.tableAdapterManager.controlelogsistemaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
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
            this.tableAdapterManager.lojaTableAdapter = null;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.operadoraTableAdapter = null;
            this.tableAdapterManager.parcelacompraTableAdapter = null;
            this.tableAdapterManager.parcelavendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.situacaoTableAdapter = null;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // compraprodutoTableAdapter
            // 
            this.compraprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_itenscompraprodutoTableAdapter
            // 
            this.vw_itenscompraprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // itenscompraprodutoTableAdapter
            // 
            this.itenscompraprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(60, 485);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(82, 20);
            this.LblTotal.TabIndex = 58;
            this.LblTotal.Text = "R$ 00,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Total:";
            // 
            // parcelacompraBindingSource
            // 
            this.parcelacompraBindingSource.DataMember = "parcelacompra";
            this.parcelacompraBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // parcelacompraTableAdapter
            // 
            this.parcelacompraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCompraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BoxAddProduto);
            this.Controls.Add(this.vw_itenscompraprodutoDataGridView);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TxtFuncionario);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(codcompraLabel);
            this.Controls.Add(this.TxtCodCompra);
            this.Controls.Add(datacompraLabel);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(codfornecedor_fkLabel);
            this.Controls.Add(codfuncionario_fkLabel);
            this.Name = "FrmCompraProduto";
            this.Text = "FrmCompraProduto";
            this.Load += new System.EventHandler(this.FrmCompraProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itenscompraprodutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itenscompraprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenscompraprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.BoxAddProduto.ResumeLayout(false);
            this.BoxAddProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_compraprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelacompraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource vw_compraprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_compraprodutoTableAdapter vw_compraprodutoTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sistema_unifunecDataSetTableAdapters.compraprodutoTableAdapter compraprodutoTableAdapter;
        private System.Windows.Forms.BindingSource compraprodutoBindingSource;
        private System.Windows.Forms.TextBox TxtCodCompra;
        private System.Windows.Forms.DateTimePicker TxtData;
        private System.Windows.Forms.ComboBox TxtFornecedor;
        private System.Windows.Forms.ComboBox TxtFuncionario;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.BindingSource vw_itenscompraprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_itenscompraprodutoTableAdapter vw_itenscompraprodutoTableAdapter;
        private System.Windows.Forms.DataGridView vw_itenscompraprodutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private sistema_unifunecDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private sistema_unifunecDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource itenscompraprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.itenscompraprodutoTableAdapter itenscompraprodutoTableAdapter;
        private System.Windows.Forms.TextBox TxtCodigoCompra;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.ComboBox TxtProduto;
        private System.Windows.Forms.GroupBox BoxAddProduto;
        private System.Windows.Forms.Button BtnSalvarP;
        private System.Windows.Forms.Button BtnExcluirP;
        private System.Windows.Forms.Button BtnNovoP;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private sistema_unifunecDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource parcelacompraBindingSource;
        private sistema_unifunecDataSetTableAdapters.parcelacompraTableAdapter parcelacompraTableAdapter;
    }
}