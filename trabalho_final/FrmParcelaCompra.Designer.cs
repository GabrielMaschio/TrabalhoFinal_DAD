namespace trabalho_final
{
    partial class FrmParcelaCompra
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
            System.Windows.Forms.Label codparcelacompraLabel;
            System.Windows.Forms.Label codcompra_fkLabel;
            System.Windows.Forms.Label datavencimentoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codsituacao_fkLabel;
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.vw_parcelacompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_parcelacompraTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_parcelacompraTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.parcelacompraTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.parcelacompraTableAdapter();
            this.situacaoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.situacaoTableAdapter();
            this.vw_parcelacompraDataGridView = new System.Windows.Forms.DataGridView();
            this.parcelacompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtParcela = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.DateTimePicker();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtSituacao = new System.Windows.Forms.ComboBox();
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TxtCompra = new System.Windows.Forms.ComboBox();
            this.compraprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraprodutoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.compraprodutoTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codparcelacompraLabel = new System.Windows.Forms.Label();
            codcompra_fkLabel = new System.Windows.Forms.Label();
            datavencimentoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codsituacao_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_parcelacompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_parcelacompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelacompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraprodutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codparcelacompraLabel
            // 
            codparcelacompraLabel.AutoSize = true;
            codparcelacompraLabel.Location = new System.Drawing.Point(9, 283);
            codparcelacompraLabel.Name = "codparcelacompraLabel";
            codparcelacompraLabel.Size = new System.Drawing.Size(86, 13);
            codparcelacompraLabel.TabIndex = 1;
            codparcelacompraLabel.Text = "Número Parcela:";
            // 
            // codcompra_fkLabel
            // 
            codcompra_fkLabel.AutoSize = true;
            codcompra_fkLabel.Location = new System.Drawing.Point(101, 283);
            codcompra_fkLabel.Name = "codcompra_fkLabel";
            codcompra_fkLabel.Size = new System.Drawing.Size(82, 13);
            codcompra_fkLabel.TabIndex = 3;
            codcompra_fkLabel.Text = "Código Compra:";
            // 
            // datavencimentoLabel
            // 
            datavencimentoLabel.AutoSize = true;
            datavencimentoLabel.Location = new System.Drawing.Point(195, 283);
            datavencimentoLabel.Name = "datavencimentoLabel";
            datavencimentoLabel.Size = new System.Drawing.Size(92, 13);
            datavencimentoLabel.TabIndex = 5;
            datavencimentoLabel.Text = "Data Vencimento:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(305, 283);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // codsituacao_fkLabel
            // 
            codsituacao_fkLabel.AutoSize = true;
            codsituacao_fkLabel.Location = new System.Drawing.Point(410, 283);
            codsituacao_fkLabel.Name = "codsituacao_fkLabel";
            codsituacao_fkLabel.Size = new System.Drawing.Size(52, 13);
            codsituacao_fkLabel.TabIndex = 9;
            codsituacao_fkLabel.Text = "Situação:";
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_parcelacompraBindingSource
            // 
            this.vw_parcelacompraBindingSource.DataMember = "vw_parcelacompra";
            this.vw_parcelacompraBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vw_parcelacompraTableAdapter
            // 
            this.vw_parcelacompraTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.parcelacompraTableAdapter = this.parcelacompraTableAdapter;
            this.tableAdapterManager.parcelavendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.situacaoTableAdapter = this.situacaoTableAdapter;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // parcelacompraTableAdapter
            // 
            this.parcelacompraTableAdapter.ClearBeforeFill = true;
            // 
            // situacaoTableAdapter
            // 
            this.situacaoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_parcelacompraDataGridView
            // 
            this.vw_parcelacompraDataGridView.AutoGenerateColumns = false;
            this.vw_parcelacompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_parcelacompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vw_parcelacompraDataGridView.DataSource = this.vw_parcelacompraBindingSource;
            this.vw_parcelacompraDataGridView.Enabled = false;
            this.vw_parcelacompraDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vw_parcelacompraDataGridView.Name = "vw_parcelacompraDataGridView";
            this.vw_parcelacompraDataGridView.Size = new System.Drawing.Size(522, 220);
            this.vw_parcelacompraDataGridView.TabIndex = 1;
            // 
            // parcelacompraBindingSource
            // 
            this.parcelacompraBindingSource.DataMember = "parcelacompra";
            this.parcelacompraBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtParcela
            // 
            this.TxtParcela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelacompraBindingSource, "codparcelacompra", true));
            this.TxtParcela.Enabled = false;
            this.TxtParcela.Location = new System.Drawing.Point(12, 299);
            this.TxtParcela.Name = "TxtParcela";
            this.TxtParcela.Size = new System.Drawing.Size(86, 20);
            this.TxtParcela.TabIndex = 2;
            // 
            // TxtData
            // 
            this.TxtData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.parcelacompraBindingSource, "datavencimento", true));
            this.TxtData.Enabled = false;
            this.TxtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData.Location = new System.Drawing.Point(198, 299);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(104, 20);
            this.TxtData.TabIndex = 6;
            // 
            // TxtValor
            // 
            this.TxtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelacompraBindingSource, "valor", true));
            this.TxtValor.Enabled = false;
            this.TxtValor.Location = new System.Drawing.Point(308, 299);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(99, 20);
            this.TxtValor.TabIndex = 8;
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.parcelacompraBindingSource, "codsituacao_fk", true));
            this.TxtSituacao.DataSource = this.situacaoBindingSource;
            this.TxtSituacao.DisplayMember = "nomesituacao";
            this.TxtSituacao.Enabled = false;
            this.TxtSituacao.FormattingEnabled = true;
            this.TxtSituacao.Location = new System.Drawing.Point(413, 298);
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Size = new System.Drawing.Size(121, 21);
            this.TxtSituacao.TabIndex = 10;
            this.TxtSituacao.ValueMember = "codsituacao";
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataMember = "situacao";
            this.situacaoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(488, 238);
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
            this.BtnProximo.Location = new System.Drawing.Point(436, 238);
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
            this.BtnSalvar.Location = new System.Drawing.Point(368, 238);
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
            this.Excluir.Location = new System.Drawing.Point(300, 238);
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
            this.BtnEditar.Location = new System.Drawing.Point(184, 238);
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
            this.BtnNovo.Location = new System.Drawing.Point(116, 238);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 65;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TxtCompra
            // 
            this.TxtCompra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.parcelacompraBindingSource, "codcompra_fk", true));
            this.TxtCompra.DataSource = this.compraprodutoBindingSource;
            this.TxtCompra.DisplayMember = "codcompra";
            this.TxtCompra.Enabled = false;
            this.TxtCompra.FormattingEnabled = true;
            this.TxtCompra.Location = new System.Drawing.Point(104, 299);
            this.TxtCompra.Name = "TxtCompra";
            this.TxtCompra.Size = new System.Drawing.Size(88, 21);
            this.TxtCompra.TabIndex = 69;
            this.TxtCompra.ValueMember = "codcompra";
            // 
            // compraprodutoBindingSource
            // 
            this.compraprodutoBindingSource.DataMember = "compraproduto";
            this.compraprodutoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // compraprodutoTableAdapter
            // 
            this.compraprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codparcelacompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número Parcela";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codcompra_fk";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Compra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datavencimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nomesituacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmParcelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 345);
            this.Controls.Add(this.TxtCompra);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(codparcelacompraLabel);
            this.Controls.Add(this.TxtParcela);
            this.Controls.Add(codcompra_fkLabel);
            this.Controls.Add(datavencimentoLabel);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(codsituacao_fkLabel);
            this.Controls.Add(this.vw_parcelacompraDataGridView);
            this.Name = "FrmParcelaCompra";
            this.Text = "FrmParcelaCompra";
            this.Load += new System.EventHandler(this.FrmParcelaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_parcelacompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_parcelacompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelacompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraprodutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource vw_parcelacompraBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_parcelacompraTableAdapter vw_parcelacompraTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vw_parcelacompraDataGridView;
        private sistema_unifunecDataSetTableAdapters.parcelacompraTableAdapter parcelacompraTableAdapter;
        private System.Windows.Forms.BindingSource parcelacompraBindingSource;
        private sistema_unifunecDataSetTableAdapters.situacaoTableAdapter situacaoTableAdapter;
        private System.Windows.Forms.TextBox TxtParcela;
        private System.Windows.Forms.DateTimePicker TxtData;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.ComboBox TxtSituacao;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.ComboBox TxtCompra;
        private System.Windows.Forms.BindingSource compraprodutoBindingSource;
        private sistema_unifunecDataSetTableAdapters.compraprodutoTableAdapter compraprodutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}