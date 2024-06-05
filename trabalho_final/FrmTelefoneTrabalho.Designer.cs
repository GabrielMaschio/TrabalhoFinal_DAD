namespace trabalho_final
{
    partial class FrmTelefoneTrabalho
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
            System.Windows.Forms.Label Trabalho;
            System.Windows.Forms.Label codtelefone_fkLabel;
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.itenstelefonetrabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itenstelefonetrabalhoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.itenstelefonetrabalhoTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.telefoneTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.telefoneTableAdapter();
            this.trabalhoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.trabalhoTableAdapter();
            this.itenstelefonetrabalhoDataGridView = new System.Windows.Forms.DataGridView();
            this.TxtTrabalho = new System.Windows.Forms.ComboBox();
            this.trabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtTelefone = new System.Windows.Forms.ComboBox();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.vwitenstelefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_itenstelefoneTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_itenstelefoneTableAdapter();
            this.nometrabalhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Trabalho = new System.Windows.Forms.Label();
            codtelefone_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonetrabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonetrabalhoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitenstelefoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Trabalho
            // 
            Trabalho.AutoSize = true;
            Trabalho.Location = new System.Drawing.Point(10, 274);
            Trabalho.Name = "Trabalho";
            Trabalho.Size = new System.Drawing.Size(52, 13);
            Trabalho.TabIndex = 1;
            Trabalho.Text = "Trabalho:";
            // 
            // codtelefone_fkLabel
            // 
            codtelefone_fkLabel.AutoSize = true;
            codtelefone_fkLabel.Location = new System.Drawing.Point(189, 274);
            codtelefone_fkLabel.Name = "codtelefone_fkLabel";
            codtelefone_fkLabel.Size = new System.Drawing.Size(52, 13);
            codtelefone_fkLabel.TabIndex = 3;
            codtelefone_fkLabel.Text = "Telefone:";
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itenstelefonetrabalhoBindingSource
            // 
            this.itenstelefonetrabalhoBindingSource.DataMember = "itenstelefonetrabalho";
            this.itenstelefonetrabalhoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // itenstelefonetrabalhoTableAdapter
            // 
            this.itenstelefonetrabalhoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.itenstelefonetrabalhoTableAdapter = this.itenstelefonetrabalhoTableAdapter;
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
            this.tableAdapterManager.telefoneTableAdapter = this.telefoneTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = this.trabalhoTableAdapter;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // telefoneTableAdapter
            // 
            this.telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // trabalhoTableAdapter
            // 
            this.trabalhoTableAdapter.ClearBeforeFill = true;
            // 
            // itenstelefonetrabalhoDataGridView
            // 
            this.itenstelefonetrabalhoDataGridView.AutoGenerateColumns = false;
            this.itenstelefonetrabalhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itenstelefonetrabalhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nometrabalhoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.itenstelefonetrabalhoDataGridView.DataSource = this.vwitenstelefoneBindingSource;
            this.itenstelefonetrabalhoDataGridView.Enabled = false;
            this.itenstelefonetrabalhoDataGridView.Location = new System.Drawing.Point(12, 12);
            this.itenstelefonetrabalhoDataGridView.Name = "itenstelefonetrabalhoDataGridView";
            this.itenstelefonetrabalhoDataGridView.Size = new System.Drawing.Size(300, 220);
            this.itenstelefonetrabalhoDataGridView.TabIndex = 1;
            // 
            // TxtTrabalho
            // 
            this.TxtTrabalho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itenstelefonetrabalhoBindingSource, "codtrabalho_fk", true));
            this.TxtTrabalho.DataSource = this.trabalhoBindingSource;
            this.TxtTrabalho.DisplayMember = "nometrabalho";
            this.TxtTrabalho.Enabled = false;
            this.TxtTrabalho.FormattingEnabled = true;
            this.TxtTrabalho.Location = new System.Drawing.Point(13, 290);
            this.TxtTrabalho.Name = "TxtTrabalho";
            this.TxtTrabalho.Size = new System.Drawing.Size(121, 21);
            this.TxtTrabalho.TabIndex = 5;
            this.TxtTrabalho.ValueMember = "codtrabalho";
            // 
            // trabalhoBindingSource
            // 
            this.trabalhoBindingSource.DataMember = "trabalho";
            this.trabalhoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itenstelefonetrabalhoBindingSource, "codtelefone_fk", true));
            this.TxtTelefone.DataSource = this.telefoneBindingSource;
            this.TxtTelefone.DisplayMember = "numero";
            this.TxtTelefone.Enabled = false;
            this.TxtTelefone.FormattingEnabled = true;
            this.TxtTelefone.Location = new System.Drawing.Point(192, 290);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(121, 21);
            this.TxtTelefone.TabIndex = 6;
            this.TxtTelefone.ValueMember = "codtelefone";
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataMember = "telefone";
            this.telefoneBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(250, 332);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 25;
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
            this.Excluir.Location = new System.Drawing.Point(168, 332);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(62, 23);
            this.Excluir.TabIndex = 24;
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
            this.BtnEditar.Location = new System.Drawing.Point(89, 332);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 23;
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
            this.BtnNovo.Location = new System.Drawing.Point(13, 332);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 22;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(267, 238);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(46, 23);
            this.BtnUltimo.TabIndex = 29;
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
            this.BtnAnterior.TabIndex = 28;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(215, 238);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 27;
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
            this.BtnPrimeiro.TabIndex = 26;
            this.BtnPrimeiro.Text = "|<";
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // vwitenstelefoneBindingSource
            // 
            this.vwitenstelefoneBindingSource.DataMember = "vw_itenstelefone";
            this.vwitenstelefoneBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vw_itenstelefoneTableAdapter
            // 
            this.vw_itenstelefoneTableAdapter.ClearBeforeFill = true;
            // 
            // nometrabalhoDataGridViewTextBoxColumn
            // 
            this.nometrabalhoDataGridViewTextBoxColumn.DataPropertyName = "nometrabalho";
            this.nometrabalhoDataGridViewTextBoxColumn.HeaderText = "nometrabalho";
            this.nometrabalhoDataGridViewTextBoxColumn.Name = "nometrabalhoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // FrmTelefoneTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 369);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtTrabalho);
            this.Controls.Add(Trabalho);
            this.Controls.Add(codtelefone_fkLabel);
            this.Controls.Add(this.itenstelefonetrabalhoDataGridView);
            this.Name = "FrmTelefoneTrabalho";
            this.Text = "FrmTelefoneTrabalho";
            this.Load += new System.EventHandler(this.FrmTelefoneTrabalho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonetrabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonetrabalhoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitenstelefoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource itenstelefonetrabalhoBindingSource;
        private sistema_unifunecDataSetTableAdapters.itenstelefonetrabalhoTableAdapter itenstelefonetrabalhoTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itenstelefonetrabalhoDataGridView;
        private sistema_unifunecDataSetTableAdapters.trabalhoTableAdapter trabalhoTableAdapter;
        private System.Windows.Forms.ComboBox TxtTrabalho;
        private System.Windows.Forms.BindingSource trabalhoBindingSource;
        private System.Windows.Forms.ComboBox TxtTelefone;
        private sistema_unifunecDataSetTableAdapters.telefoneTableAdapter telefoneTableAdapter;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.BindingSource vwitenstelefoneBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_itenstelefoneTableAdapter vw_itenstelefoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometrabalhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
    }
}