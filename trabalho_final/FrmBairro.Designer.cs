namespace trabalho_final
{
    partial class FrmBairro
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
            System.Windows.Forms.Label codbairroLabel;
            System.Windows.Forms.Label nomebairroLabel;
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bairroTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.bairroTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.bairroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.codbairroTextBox = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            codbairroLabel = new System.Windows.Forms.Label();
            nomebairroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = this.bairroTableAdapter;
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
            // bairroDataGridView
            // 
            this.bairroDataGridView.AutoGenerateColumns = false;
            this.bairroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bairroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bairroDataGridView.DataSource = this.bairroBindingSource;
            this.bairroDataGridView.Enabled = false;
            this.bairroDataGridView.Location = new System.Drawing.Point(12, 12);
            this.bairroDataGridView.Name = "bairroDataGridView";
            this.bairroDataGridView.Size = new System.Drawing.Size(266, 220);
            this.bairroDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codbairro";
            this.dataGridViewTextBoxColumn1.HeaderText = "codbairro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomebairro";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomebairro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(232, 238);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(46, 23);
            this.BtnUltimo.TabIndex = 13;
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
            this.BtnAnterior.TabIndex = 12;
            this.BtnAnterior.Text = "<<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(180, 238);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(46, 23);
            this.BtnProximo.TabIndex = 11;
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
            this.BtnPrimeiro.TabIndex = 10;
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
            this.BtnSalvar.Location = new System.Drawing.Point(216, 331);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtnSalvar.TabIndex = 17;
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
            this.Excluir.Location = new System.Drawing.Point(148, 331);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(62, 23);
            this.Excluir.TabIndex = 16;
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
            this.BtnEditar.Location = new System.Drawing.Point(80, 331);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(62, 23);
            this.BtnEditar.TabIndex = 15;
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
            this.BtnNovo.Location = new System.Drawing.Point(12, 331);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(62, 23);
            this.BtnNovo.TabIndex = 14;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // codbairroLabel
            // 
            codbairroLabel.AutoSize = true;
            codbairroLabel.Location = new System.Drawing.Point(9, 275);
            codbairroLabel.Name = "codbairroLabel";
            codbairroLabel.Size = new System.Drawing.Size(43, 13);
            codbairroLabel.TabIndex = 17;
            codbairroLabel.Text = "Código:";
            // 
            // codbairroTextBox
            // 
            this.codbairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bairroBindingSource, "codbairro", true));
            this.codbairroTextBox.Enabled = false;
            this.codbairroTextBox.Location = new System.Drawing.Point(12, 291);
            this.codbairroTextBox.Name = "codbairroTextBox";
            this.codbairroTextBox.Size = new System.Drawing.Size(100, 20);
            this.codbairroTextBox.TabIndex = 18;
            // 
            // nomebairroLabel
            // 
            nomebairroLabel.AutoSize = true;
            nomebairroLabel.Location = new System.Drawing.Point(175, 275);
            nomebairroLabel.Name = "nomebairroLabel";
            nomebairroLabel.Size = new System.Drawing.Size(37, 13);
            nomebairroLabel.TabIndex = 19;
            nomebairroLabel.Text = "Bairro:";
            // 
            // TxtBairro
            // 
            this.TxtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bairroBindingSource, "nomebairro", true));
            this.TxtBairro.Enabled = false;
            this.TxtBairro.Location = new System.Drawing.Point(178, 291);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(100, 20);
            this.TxtBairro.TabIndex = 20;
            // 
            // FrmBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 379);
            this.Controls.Add(codbairroLabel);
            this.Controls.Add(this.codbairroTextBox);
            this.Controls.Add(nomebairroLabel);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.bairroDataGridView);
            this.KeyPreview = true;
            this.Name = "FrmBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Bairro";
            this.Load += new System.EventHandler(this.FrmBairro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private sistema_unifunecDataSetTableAdapters.bairroTableAdapter bairroTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bairroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.TextBox codbairroTextBox;
        private System.Windows.Forms.TextBox TxtBairro;
    }
}