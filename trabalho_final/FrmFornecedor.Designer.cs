namespace trabalho_final
{
    partial class FrmFornecedor
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
            System.Windows.Forms.Label codfornecedorLabel;
            System.Windows.Forms.Label nomefornecedorLabel;
            System.Windows.Forms.Label numerocasaLabel;
            System.Windows.Forms.Label codrua_fkLabel;
            System.Windows.Forms.Label codbairro_fkLabel;
            System.Windows.Forms.Label codcep_fkLabel;
            System.Windows.Forms.Label codcidade_fkLabel;
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.vw_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_fornecedorTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_fornecedorTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.vw_fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.fornecedorTableAdapter();
            this.codfornecedorTextBox = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtRua = new System.Windows.Forms.ComboBox();
            this.ruaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBairro = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCEP = new System.Windows.Forms.ComboBox();
            this.cepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCidade = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruaTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.ruaTableAdapter();
            this.bairroTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.bairroTableAdapter();
            this.cepTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.cepTableAdapter();
            this.cidadeTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.cidadeTableAdapter();
            codfornecedorLabel = new System.Windows.Forms.Label();
            nomefornecedorLabel = new System.Windows.Forms.Label();
            numerocasaLabel = new System.Windows.Forms.Label();
            codrua_fkLabel = new System.Windows.Forms.Label();
            codbairro_fkLabel = new System.Windows.Forms.Label();
            codcep_fkLabel = new System.Windows.Forms.Label();
            codcidade_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codfornecedorLabel
            // 
            codfornecedorLabel.AutoSize = true;
            codfornecedorLabel.Location = new System.Drawing.Point(9, 309);
            codfornecedorLabel.Name = "codfornecedorLabel";
            codfornecedorLabel.Size = new System.Drawing.Size(43, 13);
            codfornecedorLabel.TabIndex = 68;
            codfornecedorLabel.Text = "Código:";
            // 
            // nomefornecedorLabel
            // 
            nomefornecedorLabel.AutoSize = true;
            nomefornecedorLabel.Location = new System.Drawing.Point(73, 309);
            nomefornecedorLabel.Name = "nomefornecedorLabel";
            nomefornecedorLabel.Size = new System.Drawing.Size(38, 13);
            nomefornecedorLabel.TabIndex = 70;
            nomefornecedorLabel.Text = "Nome:";
            // 
            // numerocasaLabel
            // 
            numerocasaLabel.AutoSize = true;
            numerocasaLabel.Location = new System.Drawing.Point(201, 309);
            numerocasaLabel.Name = "numerocasaLabel";
            numerocasaLabel.Size = new System.Drawing.Size(47, 13);
            numerocasaLabel.TabIndex = 72;
            numerocasaLabel.Text = "Número:";
            // 
            // codrua_fkLabel
            // 
            codrua_fkLabel.AutoSize = true;
            codrua_fkLabel.Location = new System.Drawing.Point(307, 309);
            codrua_fkLabel.Name = "codrua_fkLabel";
            codrua_fkLabel.Size = new System.Drawing.Size(30, 13);
            codrua_fkLabel.TabIndex = 74;
            codrua_fkLabel.Text = "Rua:";
            // 
            // codbairro_fkLabel
            // 
            codbairro_fkLabel.AutoSize = true;
            codbairro_fkLabel.Location = new System.Drawing.Point(434, 309);
            codbairro_fkLabel.Name = "codbairro_fkLabel";
            codbairro_fkLabel.Size = new System.Drawing.Size(37, 13);
            codbairro_fkLabel.TabIndex = 76;
            codbairro_fkLabel.Text = "Bairro:";
            // 
            // codcep_fkLabel
            // 
            codcep_fkLabel.AutoSize = true;
            codcep_fkLabel.Location = new System.Drawing.Point(561, 309);
            codcep_fkLabel.Name = "codcep_fkLabel";
            codcep_fkLabel.Size = new System.Drawing.Size(31, 13);
            codcep_fkLabel.TabIndex = 78;
            codcep_fkLabel.Text = "CEP:";
            // 
            // codcidade_fkLabel
            // 
            codcidade_fkLabel.AutoSize = true;
            codcidade_fkLabel.Location = new System.Drawing.Point(688, 309);
            codcidade_fkLabel.Name = "codcidade_fkLabel";
            codcidade_fkLabel.Size = new System.Drawing.Size(43, 13);
            codcidade_fkLabel.TabIndex = 80;
            codcidade_fkLabel.Text = "Cidade:";
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_fornecedorBindingSource
            // 
            this.vw_fornecedorBindingSource.DataMember = "vw_fornecedor";
            this.vw_fornecedorBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vw_fornecedorTableAdapter
            // 
            this.vw_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraprodutoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // vw_fornecedorDataGridView
            // 
            this.vw_fornecedorDataGridView.AutoGenerateColumns = false;
            this.vw_fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vw_fornecedorDataGridView.DataSource = this.vw_fornecedorBindingSource;
            this.vw_fornecedorDataGridView.Enabled = false;
            this.vw_fornecedorDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vw_fornecedorDataGridView.Name = "vw_fornecedorDataGridView";
            this.vw_fornecedorDataGridView.Size = new System.Drawing.Size(800, 220);
            this.vw_fornecedorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codfornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomefornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numerocasa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Número";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nomerua";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rua";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nomebairro";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numerocep";
            this.dataGridViewTextBoxColumn6.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nomecidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(766, 238);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(46, 23);
            this.BtnUltimo.TabIndex = 64;
            this.BtnUltimo.Text = ">|";
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(64, 238);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(46, 23);
            this.BtnAnterior.TabIndex = 63;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(714, 238);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 62;
            this.BtnProximo.Text = ">>";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimeiro.Location = new System.Drawing.Point(12, 238);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(46, 23);
            this.BtnPrimeiro.TabIndex = 61;
            this.BtnPrimeiro.Text = "|<";
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(496, 238);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 68;
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
            this.Excluir.Location = new System.Drawing.Point(428, 238);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(62, 23);
            this.Excluir.TabIndex = 67;
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
            this.BtnEditar.Location = new System.Drawing.Point(326, 238);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 66;
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
            this.BtnNovo.Location = new System.Drawing.Point(258, 238);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 65;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // codfornecedorTextBox
            // 
            this.codfornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "codfornecedor", true));
            this.codfornecedorTextBox.Enabled = false;
            this.codfornecedorTextBox.Location = new System.Drawing.Point(12, 325);
            this.codfornecedorTextBox.Name = "codfornecedorTextBox";
            this.codfornecedorTextBox.Size = new System.Drawing.Size(58, 20);
            this.codfornecedorTextBox.TabIndex = 69;
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nomefornecedor", true));
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(76, 325);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(122, 20);
            this.TxtNome.TabIndex = 71;
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "numerocasa", true));
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(204, 325);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 73;
            // 
            // TxtRua
            // 
            this.TxtRua.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "codrua_fk", true));
            this.TxtRua.DataSource = this.ruaBindingSource;
            this.TxtRua.DisplayMember = "nomerua";
            this.TxtRua.Enabled = false;
            this.TxtRua.FormattingEnabled = true;
            this.TxtRua.Location = new System.Drawing.Point(310, 325);
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
            // TxtBairro
            // 
            this.TxtBairro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "codbairro_fk", true));
            this.TxtBairro.DataSource = this.bairroBindingSource;
            this.TxtBairro.DisplayMember = "nomebairro";
            this.TxtBairro.Enabled = false;
            this.TxtBairro.FormattingEnabled = true;
            this.TxtBairro.Location = new System.Drawing.Point(437, 325);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(121, 21);
            this.TxtBairro.TabIndex = 83;
            this.TxtBairro.ValueMember = "codbairro";
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "bairro";
            this.bairroBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtCEP
            // 
            this.TxtCEP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "codcep_fk", true));
            this.TxtCEP.DataSource = this.cepBindingSource;
            this.TxtCEP.DisplayMember = "numerocep";
            this.TxtCEP.Enabled = false;
            this.TxtCEP.FormattingEnabled = true;
            this.TxtCEP.Location = new System.Drawing.Point(564, 325);
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(121, 21);
            this.TxtCEP.TabIndex = 84;
            this.TxtCEP.ValueMember = "codcep";
            // 
            // cepBindingSource
            // 
            this.cepBindingSource.DataMember = "cep";
            this.cepBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtCidade
            // 
            this.TxtCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "codcidade_fk", true));
            this.TxtCidade.DataSource = this.cidadeBindingSource;
            this.TxtCidade.DisplayMember = "nomecidade";
            this.TxtCidade.Enabled = false;
            this.TxtCidade.FormattingEnabled = true;
            this.TxtCidade.Location = new System.Drawing.Point(691, 325);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(121, 21);
            this.TxtCidade.TabIndex = 85;
            this.TxtCidade.ValueMember = "codcidade";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // ruaTableAdapter
            // 
            this.ruaTableAdapter.ClearBeforeFill = true;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // cepTableAdapter
            // 
            this.cepTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 360);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtCEP);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(codfornecedorLabel);
            this.Controls.Add(this.codfornecedorTextBox);
            this.Controls.Add(nomefornecedorLabel);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(numerocasaLabel);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(codrua_fkLabel);
            this.Controls.Add(codbairro_fkLabel);
            this.Controls.Add(codcep_fkLabel);
            this.Controls.Add(codcidade_fkLabel);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.vw_fornecedorDataGridView);
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource vw_fornecedorBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_fornecedorTableAdapter vw_fornecedorTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vw_fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private sistema_unifunecDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.TextBox codfornecedorTextBox;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.ComboBox TxtRua;
        private System.Windows.Forms.ComboBox TxtBairro;
        private System.Windows.Forms.ComboBox TxtCEP;
        private System.Windows.Forms.ComboBox TxtCidade;
        private System.Windows.Forms.BindingSource ruaBindingSource;
        private sistema_unifunecDataSetTableAdapters.ruaTableAdapter ruaTableAdapter;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private sistema_unifunecDataSetTableAdapters.bairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.BindingSource cepBindingSource;
        private sistema_unifunecDataSetTableAdapters.cepTableAdapter cepTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private sistema_unifunecDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
    }
}