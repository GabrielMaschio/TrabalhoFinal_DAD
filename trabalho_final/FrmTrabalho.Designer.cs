namespace trabalho_final
{
    partial class FrmTrabalho
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
            System.Windows.Forms.Label codtrabalhoLabel;
            System.Windows.Forms.Label lbl;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codtrabalhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometrabalhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.vwtrabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_trabalhoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.vw_trabalhoTableAdapter();
            this.trabalhoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.trabalhoTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.itenstelefonetrabalhoTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.itenstelefonetrabalhoTableAdapter();
            this.telefoneTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.telefoneTableAdapter();
            this.codtrabalhoTextBox = new System.Windows.Forms.TextBox();
            this.TxtNomeTrabalho = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.itenstelefonetrabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            codtrabalhoLabel = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtrabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonetrabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codtrabalhoLabel
            // 
            codtrabalhoLabel.AutoSize = true;
            codtrabalhoLabel.Location = new System.Drawing.Point(9, 232);
            codtrabalhoLabel.Name = "codtrabalhoLabel";
            codtrabalhoLabel.Size = new System.Drawing.Size(43, 13);
            codtrabalhoLabel.TabIndex = 2;
            codtrabalhoLabel.Text = "Código:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(175, 232);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(52, 13);
            lbl.TabIndex = 4;
            lbl.Text = "Trabalho:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtrabalhoDataGridViewTextBoxColumn,
            this.nometrabalhoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trabalhoBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // codtrabalhoDataGridViewTextBoxColumn
            // 
            this.codtrabalhoDataGridViewTextBoxColumn.DataPropertyName = "codtrabalho";
            this.codtrabalhoDataGridViewTextBoxColumn.HeaderText = "codtrabalho";
            this.codtrabalhoDataGridViewTextBoxColumn.Name = "codtrabalhoDataGridViewTextBoxColumn";
            this.codtrabalhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nometrabalhoDataGridViewTextBoxColumn
            // 
            this.nometrabalhoDataGridViewTextBoxColumn.DataPropertyName = "nometrabalho";
            this.nometrabalhoDataGridViewTextBoxColumn.HeaderText = "nometrabalho";
            this.nometrabalhoDataGridViewTextBoxColumn.Name = "nometrabalhoDataGridViewTextBoxColumn";
            // 
            // trabalhoBindingSource
            // 
            this.trabalhoBindingSource.DataMember = "trabalho";
            this.trabalhoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwtrabalhoBindingSource
            // 
            this.vwtrabalhoBindingSource.DataMember = "vw_trabalho";
            this.vwtrabalhoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // vw_trabalhoTableAdapter
            // 
            this.vw_trabalhoTableAdapter.ClearBeforeFill = true;
            // 
            // trabalhoTableAdapter
            // 
            this.trabalhoTableAdapter.ClearBeforeFill = true;
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
            // itenstelefonetrabalhoTableAdapter
            // 
            this.itenstelefonetrabalhoTableAdapter.ClearBeforeFill = true;
            // 
            // telefoneTableAdapter
            // 
            this.telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // codtrabalhoTextBox
            // 
            this.codtrabalhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabalhoBindingSource, "codtrabalho", true));
            this.codtrabalhoTextBox.Enabled = false;
            this.codtrabalhoTextBox.Location = new System.Drawing.Point(12, 248);
            this.codtrabalhoTextBox.Name = "codtrabalhoTextBox";
            this.codtrabalhoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codtrabalhoTextBox.TabIndex = 3;
            // 
            // TxtNomeTrabalho
            // 
            this.TxtNomeTrabalho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabalhoBindingSource, "nometrabalho", true));
            this.TxtNomeTrabalho.Enabled = false;
            this.TxtNomeTrabalho.Location = new System.Drawing.Point(178, 248);
            this.TxtNomeTrabalho.Name = "TxtNomeTrabalho";
            this.TxtNomeTrabalho.Size = new System.Drawing.Size(100, 20);
            this.TxtNomeTrabalho.TabIndex = 5;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(216, 284);
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
            this.Excluir.Location = new System.Drawing.Point(148, 284);
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
            this.BtnEditar.Location = new System.Drawing.Point(80, 284);
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
            this.BtnNovo.Location = new System.Drawing.Point(12, 284);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 22;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // itenstelefonetrabalhoBindingSource
            // 
            this.itenstelefonetrabalhoBindingSource.DataMember = "itenstelefonetrabalho";
            this.itenstelefonetrabalhoBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataMember = "telefone";
            this.telefoneBindingSource.DataSource = this.sistema_unifunecDataSet;
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(233, 188);
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
            this.BtnAnterior.Location = new System.Drawing.Point(66, 188);
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
            this.BtnProximo.Location = new System.Drawing.Point(181, 188);
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
            this.BtnPrimeiro.Location = new System.Drawing.Point(14, 188);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(46, 23);
            this.BtnPrimeiro.TabIndex = 26;
            this.BtnPrimeiro.Text = "|<";
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // FrmTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 345);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(lbl);
            this.Controls.Add(this.TxtNomeTrabalho);
            this.Controls.Add(codtrabalhoLabel);
            this.Controls.Add(this.codtrabalhoTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTrabalho";
            this.Text = "FrmTrabalho";
            this.Load += new System.EventHandler(this.FrmTrabalho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtrabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonetrabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource vwtrabalhoBindingSource;
        private sistema_unifunecDataSetTableAdapters.vw_trabalhoTableAdapter vw_trabalhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtrabalhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometrabalhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trabalhoBindingSource;
        private sistema_unifunecDataSetTableAdapters.trabalhoTableAdapter trabalhoTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codtrabalhoTextBox;
        private System.Windows.Forms.TextBox TxtNomeTrabalho;
        private sistema_unifunecDataSetTableAdapters.itenstelefonetrabalhoTableAdapter itenstelefonetrabalhoTableAdapter;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.BindingSource itenstelefonetrabalhoBindingSource;
        private sistema_unifunecDataSetTableAdapters.telefoneTableAdapter telefoneTableAdapter;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
    }
}