namespace trabalho_final
{
    partial class FrmCliente
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
            System.Windows.Forms.Label nomeclienteLabel;
            System.Windows.Forms.Label datanascLabel;
            System.Windows.Forms.Label codsexo_fkLabel;
            System.Windows.Forms.Label codrua_fkLabel;
            System.Windows.Forms.Label codbairro_fkLabel;
            System.Windows.Forms.Label codcep_fkLabel;
            System.Windows.Forms.Label codcidade_fkLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label codtrabalho_fkLabel;
            System.Windows.Forms.Label numerocasaLabel;
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.bairroTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.bairroTableAdapter();
            this.cepTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.cepTableAdapter();
            this.ruaTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.ruaTableAdapter();
            this.sexoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.sexoTableAdapter();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.DtpNasc = new System.Windows.Forms.DateTimePicker();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtSexo = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtRua = new System.Windows.Forms.ComboBox();
            this.ruaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBairro = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCep = new System.Windows.Forms.ComboBox();
            this.cepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCidade = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtTrabalho = new System.Windows.Forms.ComboBox();
            this.trabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.BtnAddImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.vw_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_clienteTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_clienteTableAdapter();
            this.vw_clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.cidadeTableAdapter();
            this.trabalhoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.trabalhoTableAdapter();
            nomeclienteLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            codsexo_fkLabel = new System.Windows.Forms.Label();
            codrua_fkLabel = new System.Windows.Forms.Label();
            codbairro_fkLabel = new System.Windows.Forms.Label();
            codcep_fkLabel = new System.Windows.Forms.Label();
            codcidade_fkLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            codtrabalho_fkLabel = new System.Windows.Forms.Label();
            numerocasaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeclienteLabel
            // 
            nomeclienteLabel.AutoSize = true;
            nomeclienteLabel.Location = new System.Drawing.Point(9, 248);
            nomeclienteLabel.Name = "nomeclienteLabel";
            nomeclienteLabel.Size = new System.Drawing.Size(73, 13);
            nomeclienteLabel.TabIndex = 3;
            nomeclienteLabel.Text = "Nome Cliente:";
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.Location = new System.Drawing.Point(215, 248);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(107, 13);
            datanascLabel.TabIndex = 5;
            datanascLabel.Text = "Data de Nascimento:";
            // 
            // codsexo_fkLabel
            // 
            codsexo_fkLabel.AutoSize = true;
            codsexo_fkLabel.Location = new System.Drawing.Point(421, 247);
            codsexo_fkLabel.Name = "codsexo_fkLabel";
            codsexo_fkLabel.Size = new System.Drawing.Size(34, 13);
            codsexo_fkLabel.TabIndex = 7;
            codsexo_fkLabel.Text = "Sexo:";
            // 
            // codrua_fkLabel
            // 
            codrua_fkLabel.AutoSize = true;
            codrua_fkLabel.Location = new System.Drawing.Point(629, 247);
            codrua_fkLabel.Name = "codrua_fkLabel";
            codrua_fkLabel.Size = new System.Drawing.Size(30, 13);
            codrua_fkLabel.TabIndex = 9;
            codrua_fkLabel.Text = "Rua:";
            // 
            // codbairro_fkLabel
            // 
            codbairro_fkLabel.AutoSize = true;
            codbairro_fkLabel.Location = new System.Drawing.Point(756, 246);
            codbairro_fkLabel.Name = "codbairro_fkLabel";
            codbairro_fkLabel.Size = new System.Drawing.Size(37, 13);
            codbairro_fkLabel.TabIndex = 11;
            codbairro_fkLabel.Text = "Bairro:";
            // 
            // codcep_fkLabel
            // 
            codcep_fkLabel.AutoSize = true;
            codcep_fkLabel.Location = new System.Drawing.Point(9, 297);
            codcep_fkLabel.Name = "codcep_fkLabel";
            codcep_fkLabel.Size = new System.Drawing.Size(29, 13);
            codcep_fkLabel.TabIndex = 13;
            codcep_fkLabel.Text = "Cep:";
            // 
            // codcidade_fkLabel
            // 
            codcidade_fkLabel.AutoSize = true;
            codcidade_fkLabel.Location = new System.Drawing.Point(139, 296);
            codcidade_fkLabel.Name = "codcidade_fkLabel";
            codcidade_fkLabel.Size = new System.Drawing.Size(43, 13);
            codcidade_fkLabel.TabIndex = 15;
            codcidade_fkLabel.Text = "Cidade:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(500, 295);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 17;
            salarioLabel.Text = "Salário:";
            // 
            // codtrabalho_fkLabel
            // 
            codtrabalho_fkLabel.AutoSize = true;
            codtrabalho_fkLabel.Location = new System.Drawing.Point(342, 296);
            codtrabalho_fkLabel.Name = "codtrabalho_fkLabel";
            codtrabalho_fkLabel.Size = new System.Drawing.Size(52, 13);
            codtrabalho_fkLabel.TabIndex = 19;
            codtrabalho_fkLabel.Text = "Trabalho:";
            // 
            // numerocasaLabel
            // 
            numerocasaLabel.AutoSize = true;
            numerocasaLabel.Location = new System.Drawing.Point(548, 247);
            numerocasaLabel.Name = "numerocasaLabel";
            numerocasaLabel.Size = new System.Drawing.Size(47, 13);
            numerocasaLabel.TabIndex = 21;
            numerocasaLabel.Text = "Número:";
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = this.bairroTableAdapter;
            this.tableAdapterManager.cepTableAdapter = this.cepTableAdapter;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.compraprodutoTableAdapter = null;
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
            this.tableAdapterManager.ruaTableAdapter = this.ruaTableAdapter;
            this.tableAdapterManager.sexoTableAdapter = this.sexoTableAdapter;
            this.tableAdapterManager.situacaoTableAdapter = null;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // cepTableAdapter
            // 
            this.cepTableAdapter.ClearBeforeFill = true;
            // 
            // ruaTableAdapter
            // 
            this.ruaTableAdapter.ClearBeforeFill = true;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nomecliente", true));
            this.TxtNomeCliente.Enabled = false;
            this.TxtNomeCliente.Location = new System.Drawing.Point(12, 264);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(200, 20);
            this.TxtNomeCliente.TabIndex = 4;
            // 
            // DtpNasc
            // 
            this.DtpNasc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "datanasc", true));
            this.DtpNasc.Enabled = false;
            this.DtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNasc.Location = new System.Drawing.Point(218, 264);
            this.DtpNasc.Name = "DtpNasc";
            this.DtpNasc.Size = new System.Drawing.Size(200, 20);
            this.DtpNasc.TabIndex = 6;
            // 
            // TxtSalario
            // 
            this.TxtSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "salario", true));
            this.TxtSalario.Enabled = false;
            this.TxtSalario.Location = new System.Drawing.Point(503, 312);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(104, 20);
            this.TxtSalario.TabIndex = 18;
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "numerocasa", true));
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(551, 263);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(75, 20);
            this.TxtNumero.TabIndex = 22;
            // 
            // TxtSexo
            // 
            this.TxtSexo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codsexo_fk", true));
            this.TxtSexo.DataSource = this.sexoBindingSource;
            this.TxtSexo.DisplayMember = "nomesexo";
            this.TxtSexo.Enabled = false;
            this.TxtSexo.FormattingEnabled = true;
            this.TxtSexo.Location = new System.Drawing.Point(424, 263);
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(121, 21);
            this.TxtSexo.TabIndex = 23;
            this.TxtSexo.ValueMember = "codsexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "sexo";
            this.sexoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtRua
            // 
            this.TxtRua.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codrua_fk", true));
            this.TxtRua.DataSource = this.ruaBindingSource;
            this.TxtRua.DisplayMember = "nomerua";
            this.TxtRua.Enabled = false;
            this.TxtRua.FormattingEnabled = true;
            this.TxtRua.Location = new System.Drawing.Point(632, 262);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(121, 21);
            this.TxtRua.TabIndex = 24;
            this.TxtRua.ValueMember = "codrua";
            // 
            // ruaBindingSource
            // 
            this.ruaBindingSource.DataMember = "rua";
            this.ruaBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtBairro
            // 
            this.TxtBairro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codbairro_fk", true));
            this.TxtBairro.DataSource = this.bairroBindingSource;
            this.TxtBairro.DisplayMember = "nomebairro";
            this.TxtBairro.Enabled = false;
            this.TxtBairro.FormattingEnabled = true;
            this.TxtBairro.Location = new System.Drawing.Point(759, 262);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(121, 21);
            this.TxtBairro.TabIndex = 25;
            this.TxtBairro.ValueMember = "codbairro";
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "bairro";
            this.bairroBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtCep
            // 
            this.TxtCep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codcep_fk", true));
            this.TxtCep.DataSource = this.cepBindingSource;
            this.TxtCep.DisplayMember = "numerocep";
            this.TxtCep.Enabled = false;
            this.TxtCep.FormattingEnabled = true;
            this.TxtCep.Location = new System.Drawing.Point(12, 312);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(121, 21);
            this.TxtCep.TabIndex = 26;
            this.TxtCep.ValueMember = "codcep";
            // 
            // cepBindingSource
            // 
            this.cepBindingSource.DataMember = "cep";
            this.cepBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtCidade
            // 
            this.TxtCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codcidade_fk", true));
            this.TxtCidade.DataSource = this.cidadeBindingSource;
            this.TxtCidade.DisplayMember = "nomecidade";
            this.TxtCidade.Enabled = false;
            this.TxtCidade.FormattingEnabled = true;
            this.TxtCidade.Location = new System.Drawing.Point(139, 312);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(200, 21);
            this.TxtCidade.TabIndex = 27;
            this.TxtCidade.ValueMember = "codcidade";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtTrabalho
            // 
            this.TxtTrabalho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codtrabalho_fk", true));
            this.TxtTrabalho.DataSource = this.trabalhoBindingSource;
            this.TxtTrabalho.DisplayMember = "nometrabalho";
            this.TxtTrabalho.Enabled = false;
            this.TxtTrabalho.FormattingEnabled = true;
            this.TxtTrabalho.Location = new System.Drawing.Point(345, 312);
            this.TxtTrabalho.Name = "TxtTrabalho";
            this.TxtTrabalho.Size = new System.Drawing.Size(152, 21);
            this.TxtTrabalho.TabIndex = 28;
            this.TxtTrabalho.ValueMember = "codtrabalho";
            // 
            // trabalhoBindingSource
            // 
            this.trabalhoBindingSource.DataMember = "trabalho";
            this.trabalhoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // PicCliente
            // 
            this.PicCliente.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "foto", true));
            this.PicCliente.Location = new System.Drawing.Point(632, 338);
            this.PicCliente.Name = "PicCliente";
            this.PicCliente.Size = new System.Drawing.Size(248, 231);
            this.PicCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCliente.TabIndex = 31;
            this.PicCliente.TabStop = false;
            // 
            // BtnAddImg
            // 
            this.BtnAddImg.Enabled = false;
            this.BtnAddImg.Location = new System.Drawing.Point(632, 309);
            this.BtnAddImg.Name = "BtnAddImg";
            this.BtnAddImg.Size = new System.Drawing.Size(248, 23);
            this.BtnAddImg.TabIndex = 32;
            this.BtnAddImg.Text = "Adicionar Imagem";
            this.BtnAddImg.UseVisualStyleBackColor = true;
            this.BtnAddImg.Click += new System.EventHandler(this.BtnAddImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(384, 475);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 36;
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
            this.Excluir.Location = new System.Drawing.Point(298, 475);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(62, 23);
            this.Excluir.TabIndex = 35;
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
            this.BtnEditar.Location = new System.Drawing.Point(208, 475);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 34;
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
            this.BtnNovo.Location = new System.Drawing.Point(119, 475);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 33;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(400, 418);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(46, 23);
            this.BtnUltimo.TabIndex = 40;
            this.BtnUltimo.Text = ">|";
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(171, 418);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(46, 23);
            this.BtnAnterior.TabIndex = 39;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(348, 418);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 38;
            this.BtnProximo.Text = ">>";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimeiro.Location = new System.Drawing.Point(119, 418);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(46, 23);
            this.BtnPrimeiro.TabIndex = 37;
            this.BtnPrimeiro.Text = "|<";
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // vw_clienteBindingSource
            // 
            this.vw_clienteBindingSource.DataMember = "vw_cliente";
            this.vw_clienteBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vw_clienteTableAdapter
            // 
            this.vw_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // vw_clienteDataGridView
            // 
            this.vw_clienteDataGridView.AutoGenerateColumns = false;
            this.vw_clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vw_clienteDataGridView.DataSource = this.vw_clienteBindingSource;
            this.vw_clienteDataGridView.Enabled = false;
            this.vw_clienteDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vw_clienteDataGridView.Name = "vw_clienteDataGridView";
            this.vw_clienteDataGridView.Size = new System.Drawing.Size(1077, 220);
            this.vw_clienteDataGridView.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nomecliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datanasc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Nasc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomesexo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numerocasa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Número";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nomerua";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rua";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nomebairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "numerocep";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nomecidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nometrabalho";
            this.dataGridViewTextBoxColumn9.HeaderText = "Trabalho";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "salario";
            this.dataGridViewTextBoxColumn10.HeaderText = "Salário";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // trabalhoTableAdapter
            // 
            this.trabalhoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 578);
            this.Controls.Add(this.vw_clienteDataGridView);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnAddImg);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.TxtTrabalho);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(this.TxtSexo);
            this.Controls.Add(nomeclienteLabel);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(datanascLabel);
            this.Controls.Add(this.DtpNasc);
            this.Controls.Add(codsexo_fkLabel);
            this.Controls.Add(codrua_fkLabel);
            this.Controls.Add(codbairro_fkLabel);
            this.Controls.Add(codcep_fkLabel);
            this.Controls.Add(codcidade_fkLabel);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(codtrabalho_fkLabel);
            this.Controls.Add(numerocasaLabel);
            this.Controls.Add(this.TxtNumero);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private sistema_unifunecDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.DateTimePicker DtpNasc;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.TextBox TxtNumero;
        private sistema_unifunecDataSetTableAdapters.sexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.ComboBox TxtSexo;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private sistema_unifunecDataSetTableAdapters.ruaTableAdapter ruaTableAdapter;
        private System.Windows.Forms.ComboBox TxtRua;
        private System.Windows.Forms.ComboBox TxtBairro;
        private System.Windows.Forms.BindingSource ruaBindingSource;
        private sistema_unifunecDataSetTableAdapters.bairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private sistema_unifunecDataSetTableAdapters.cepTableAdapter cepTableAdapter;
        private System.Windows.Forms.ComboBox TxtCep;
        private System.Windows.Forms.BindingSource cepBindingSource;
        private System.Windows.Forms.ComboBox TxtCidade;
        private System.Windows.Forms.ComboBox TxtTrabalho;
        private System.Windows.Forms.PictureBox PicCliente;
        private System.Windows.Forms.Button BtnAddImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.BindingSource vw_clienteBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_clienteTableAdapter vw_clienteTableAdapter;
        private System.Windows.Forms.DataGridView vw_clienteDataGridView;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private sistema_unifunecDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource trabalhoBindingSource;
        private sistema_unifunecDataSetTableAdapters.trabalhoTableAdapter trabalhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}