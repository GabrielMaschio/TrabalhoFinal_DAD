namespace trabalho_final
{
    partial class FrmVendaProduto
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
            System.Windows.Forms.Label codcompra_fkLabel;
            System.Windows.Forms.Label codproduto_fkLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorcLabel;
            System.Windows.Forms.Label codcompraLabel;
            System.Windows.Forms.Label datacompraLabel;
            System.Windows.Forms.Label codfornecedor_fkLabel;
            System.Windows.Forms.Label codfuncionario_fkLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BoxAddProduto = new System.Windows.Forms.GroupBox();
            this.BtnSalvarP = new System.Windows.Forms.Button();
            this.TxtCodVendaFK = new System.Windows.Forms.TextBox();
            this.itensvendaprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.BtnExcluirP = new System.Windows.Forms.Button();
            this.BtnNovoP = new System.Windows.Forms.Button();
            this.TxtProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.vw_itenscompraprodutoDataGridView = new System.Windows.Forms.DataGridView();
            this.codvendafkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwitensvendaprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TxtFuncionario = new System.Windows.Forms.ComboBox();
            this.vendaprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vendaprodutoTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.clienteTableAdapter();
            this.funcionariosTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.funcionariosTableAdapter();
            this.TxtData = new System.Windows.Forms.DateTimePicker();
            this.TxtCodVenda = new System.Windows.Forms.TextBox();
            this.sistemaunifunecDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_itensvendaprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_itensvendaprodutoTableAdapter();
            this.itensvendaprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.itensvendaprodutoTableAdapter();
            this.produtoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.produtoTableAdapter();
            this.parcelavendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelavendaTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.parcelavendaTableAdapter();
            codcompra_fkLabel = new System.Windows.Forms.Label();
            codproduto_fkLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorcLabel = new System.Windows.Forms.Label();
            codcompraLabel = new System.Windows.Forms.Label();
            datacompraLabel = new System.Windows.Forms.Label();
            codfornecedor_fkLabel = new System.Windows.Forms.Label();
            codfuncionario_fkLabel = new System.Windows.Forms.Label();
            this.BoxAddProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensvendaprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itenscompraprodutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitensvendaprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaunifunecDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelavendaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // codcompraLabel
            // 
            codcompraLabel.AutoSize = true;
            codcompraLabel.Location = new System.Drawing.Point(9, 8);
            codcompraLabel.Name = "codcompraLabel";
            codcompraLabel.Size = new System.Drawing.Size(43, 13);
            codcompraLabel.TabIndex = 60;
            codcompraLabel.Text = "Código:";
            // 
            // datacompraLabel
            // 
            datacompraLabel.AutoSize = true;
            datacompraLabel.Location = new System.Drawing.Point(80, 8);
            datacompraLabel.Name = "datacompraLabel";
            datacompraLabel.Size = new System.Drawing.Size(30, 13);
            datacompraLabel.TabIndex = 62;
            datacompraLabel.Text = "Data";
            // 
            // codfornecedor_fkLabel
            // 
            codfornecedor_fkLabel.AutoSize = true;
            codfornecedor_fkLabel.Location = new System.Drawing.Point(192, 7);
            codfornecedor_fkLabel.Name = "codfornecedor_fkLabel";
            codfornecedor_fkLabel.Size = new System.Drawing.Size(42, 13);
            codfornecedor_fkLabel.TabIndex = 64;
            codfornecedor_fkLabel.Text = "Cliente:";
            // 
            // codfuncionario_fkLabel
            // 
            codfuncionario_fkLabel.AutoSize = true;
            codfuncionario_fkLabel.Location = new System.Drawing.Point(319, 8);
            codfuncionario_fkLabel.Name = "codfuncionario_fkLabel";
            codfuncionario_fkLabel.Size = new System.Drawing.Size(65, 13);
            codfuncionario_fkLabel.TabIndex = 65;
            codfuncionario_fkLabel.Text = "Funcionário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Total:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(60, 481);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(82, 20);
            this.LblTotal.TabIndex = 76;
            this.LblTotal.Text = "R$ 00,00";
            // 
            // BoxAddProduto
            // 
            this.BoxAddProduto.Controls.Add(this.BtnSalvarP);
            this.BoxAddProduto.Controls.Add(this.TxtCodVendaFK);
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
            this.BoxAddProduto.Location = new System.Drawing.Point(12, 115);
            this.BoxAddProduto.Name = "BoxAddProduto";
            this.BoxAddProduto.Size = new System.Drawing.Size(575, 119);
            this.BoxAddProduto.TabIndex = 75;
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
            this.BtnSalvarP.Location = new System.Drawing.Point(146, 75);
            this.BtnSalvarP.Name = "BtnSalvarP";
            this.BtnSalvarP.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvarP.TabIndex = 61;
            this.BtnSalvarP.Text = "Salvar";
            this.BtnSalvarP.UseVisualStyleBackColor = false;
            this.BtnSalvarP.Click += new System.EventHandler(this.BtnSalvarP_Click);
            // 
            // TxtCodVendaFK
            // 
            this.TxtCodVendaFK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensvendaprodutoBindingSource, "codvenda_fk", true));
            this.TxtCodVendaFK.Enabled = false;
            this.TxtCodVendaFK.Location = new System.Drawing.Point(6, 37);
            this.TxtCodVendaFK.Name = "TxtCodVendaFK";
            this.TxtCodVendaFK.Size = new System.Drawing.Size(65, 20);
            this.TxtCodVendaFK.TabIndex = 49;
            // 
            // itensvendaprodutoBindingSource
            // 
            this.itensvendaprodutoBindingSource.DataMember = "itensvendaproduto";
            this.itensvendaprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnExcluirP
            // 
            this.BtnExcluirP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExcluirP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluirP.Location = new System.Drawing.Point(78, 75);
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
            // TxtProduto
            // 
            this.TxtProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensvendaprodutoBindingSource, "codproduto_fk", true));
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
            // TxtValor
            // 
            this.TxtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensvendaprodutoBindingSource, "valor", true));
            this.TxtValor.Enabled = false;
            this.TxtValor.Location = new System.Drawing.Point(310, 37);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 55;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensvendaprodutoBindingSource, "quantidade", true));
            this.TxtQuantidade.Enabled = false;
            this.TxtQuantidade.Location = new System.Drawing.Point(204, 37);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade.TabIndex = 53;
            this.TxtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            // 
            // vw_itenscompraprodutoDataGridView
            // 
            this.vw_itenscompraprodutoDataGridView.AutoGenerateColumns = false;
            this.vw_itenscompraprodutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_itenscompraprodutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codvendafkDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.vw_itenscompraprodutoDataGridView.DataSource = this.vwitensvendaprodutoBindingSource;
            this.vw_itenscompraprodutoDataGridView.Location = new System.Drawing.Point(12, 258);
            this.vw_itenscompraprodutoDataGridView.Name = "vw_itenscompraprodutoDataGridView";
            this.vw_itenscompraprodutoDataGridView.Size = new System.Drawing.Size(575, 220);
            this.vw_itenscompraprodutoDataGridView.TabIndex = 74;
            // 
            // codvendafkDataGridViewTextBoxColumn
            // 
            this.codvendafkDataGridViewTextBoxColumn.DataPropertyName = "codvenda_fk";
            this.codvendafkDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codvendafkDataGridViewTextBoxColumn.Name = "codvendafkDataGridViewTextBoxColumn";
            this.codvendafkDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // vwitensvendaprodutoBindingSource
            // 
            this.vwitensvendaprodutoBindingSource.DataMember = "vw_itensvendaproduto";
            this.vwitensvendaprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(345, 60);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(46, 23);
            this.BtnAnterior.TabIndex = 73;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(397, 60);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 72;
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
            this.BtnSalvar.Location = new System.Drawing.Point(216, 60);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 71;
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
            this.BtnExcluir.Location = new System.Drawing.Point(148, 60);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(62, 23);
            this.BtnExcluir.TabIndex = 70;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEditar.Location = new System.Drawing.Point(80, 60);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 69;
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
            this.BtnNovo.Location = new System.Drawing.Point(12, 60);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 68;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TxtFuncionario
            // 
            this.TxtFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaprodutoBindingSource, "codfuncionario_fk", true));
            this.TxtFuncionario.DataSource = this.funcionariosBindingSource;
            this.TxtFuncionario.DisplayMember = "nomefuncionario";
            this.TxtFuncionario.Enabled = false;
            this.TxtFuncionario.FormattingEnabled = true;
            this.TxtFuncionario.Location = new System.Drawing.Point(322, 23);
            this.TxtFuncionario.Name = "TxtFuncionario";
            this.TxtFuncionario.Size = new System.Drawing.Size(121, 21);
            this.TxtFuncionario.TabIndex = 67;
            this.TxtFuncionario.ValueMember = "codfuncionario";
            // 
            // vendaprodutoBindingSource
            // 
            this.vendaprodutoBindingSource.DataMember = "vendaproduto";
            this.vendaprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtCliente
            // 
            this.TxtCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaprodutoBindingSource, "codcliente_fk", true));
            this.TxtCliente.DataSource = this.clienteBindingSource;
            this.TxtCliente.DisplayMember = "nomecliente";
            this.TxtCliente.Enabled = false;
            this.TxtCliente.FormattingEnabled = true;
            this.TxtCliente.Location = new System.Drawing.Point(195, 23);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(121, 21);
            this.TxtCliente.TabIndex = 66;
            this.TxtCliente.ValueMember = "codcliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vendaprodutoTableAdapter
            // 
            this.vendaprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.compraprodutoTableAdapter = null;
            this.tableAdapterManager.controlelogsistemaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = null;
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
            this.tableAdapterManager.vendaprodutoTableAdapter = this.vendaprodutoTableAdapter;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // TxtData
            // 
            this.TxtData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaprodutoBindingSource, "datavenda", true));
            this.TxtData.Enabled = false;
            this.TxtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData.Location = new System.Drawing.Point(83, 24);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(106, 20);
            this.TxtData.TabIndex = 79;
            // 
            // TxtCodVenda
            // 
            this.TxtCodVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaprodutoBindingSource, "codvenda", true));
            this.TxtCodVenda.Enabled = false;
            this.TxtCodVenda.Location = new System.Drawing.Point(12, 24);
            this.TxtCodVenda.Name = "TxtCodVenda";
            this.TxtCodVenda.Size = new System.Drawing.Size(65, 20);
            this.TxtCodVenda.TabIndex = 80;
            // 
            // sistemaunifunecDataSetBindingSource
            // 
            this.sistemaunifunecDataSetBindingSource.DataSource = this.sistema_unifunecDataSet;
            this.sistemaunifunecDataSetBindingSource.Position = 0;
            // 
            // vw_itensvendaprodutoTableAdapter
            // 
            this.vw_itensvendaprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // itensvendaprodutoTableAdapter
            // 
            this.itensvendaprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // parcelavendaBindingSource
            // 
            this.parcelavendaBindingSource.DataMember = "parcelavenda";
            this.parcelavendaBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // parcelavendaTableAdapter
            // 
            this.parcelavendaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 510);
            this.Controls.Add(this.TxtCodVenda);
            this.Controls.Add(this.TxtData);
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
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(codcompraLabel);
            this.Controls.Add(datacompraLabel);
            this.Controls.Add(codfornecedor_fkLabel);
            this.Controls.Add(codfuncionario_fkLabel);
            this.Name = "FrmVendaProduto";
            this.Text = "FrmVendaProduto";
            this.Load += new System.EventHandler(this.FrmVendaProduto_Load);
            this.BoxAddProduto.ResumeLayout(false);
            this.BoxAddProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensvendaprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itenscompraprodutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitensvendaprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaunifunecDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelavendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.GroupBox BoxAddProduto;
        private System.Windows.Forms.Button BtnSalvarP;
        private System.Windows.Forms.TextBox TxtCodVendaFK;
        private System.Windows.Forms.Button BtnNovoP;
        private System.Windows.Forms.ComboBox TxtProduto;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.DataGridView vw_itenscompraprodutoDataGridView;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.ComboBox TxtFuncionario;
        private System.Windows.Forms.ComboBox TxtCliente;
        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource vendaprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.vendaprodutoTableAdapter vendaprodutoTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker TxtData;
        private System.Windows.Forms.TextBox TxtCodVenda;
        private sistema_unifunecDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private sistema_unifunecDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.BindingSource sistemaunifunecDataSetBindingSource;
        private System.Windows.Forms.BindingSource vwitensvendaprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_itensvendaprodutoTableAdapter vw_itensvendaprodutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codvendafkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itensvendaprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.itensvendaprodutoTableAdapter itensvendaprodutoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private sistema_unifunecDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button BtnExcluirP;
        private System.Windows.Forms.BindingSource parcelavendaBindingSource;
        private sistema_unifunecDataSetTableAdapters.parcelavendaTableAdapter parcelavendaTableAdapter;
    }
}