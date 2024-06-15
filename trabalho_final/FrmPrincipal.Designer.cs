namespace trabalho_final
{
    partial class FrmPrincipal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuEndereco = new System.Windows.Forms.ToolStripMenuItem();
            this.ruaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTelefone = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroOperadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTelefoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTelefoneTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTelefoneClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFunçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTelefoneFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTelefoneFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarImagemProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.compraProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSituaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarParcelaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTelefoneLojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCadastroLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCadastroAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistema_unifunecDataSet = new trabalho_final.sistema_unifunecDataSet();
            this.logarTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.logarTableAdapter();
            this.tableAdapterManager = new trabalho_final.sistema_unifunecDataSetTableAdapters.TableAdapterManager();
            this.itensacessologinTableAdapter = new trabalho_final.sistema_unifunecDataSetTableAdapters.itensacessologinTableAdapter();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.Text = "Usuário:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MnuEndereco
            // 
            this.MnuEndereco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruaToolStripMenuItem,
            this.bairroToolStripMenuItem,
            this.cepToolStripMenuItem});
            this.MnuEndereco.Name = "MnuEndereco";
            this.MnuEndereco.Size = new System.Drawing.Size(68, 20);
            this.MnuEndereco.Text = "Endereço";
            this.MnuEndereco.Visible = false;
            // 
            // ruaToolStripMenuItem
            // 
            this.ruaToolStripMenuItem.Name = "ruaToolStripMenuItem";
            this.ruaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ruaToolStripMenuItem.Text = "Cadastro Rua";
            this.ruaToolStripMenuItem.Click += new System.EventHandler(this.ruaToolStripMenuItem_Click);
            // 
            // bairroToolStripMenuItem
            // 
            this.bairroToolStripMenuItem.Name = "bairroToolStripMenuItem";
            this.bairroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bairroToolStripMenuItem.Text = "Cadastro Bairro";
            this.bairroToolStripMenuItem.Click += new System.EventHandler(this.bairroToolStripMenuItem_Click);
            // 
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cepToolStripMenuItem.Text = "Cadastro CEP";
            this.cepToolStripMenuItem.Click += new System.EventHandler(this.cepToolStripMenuItem_Click);
            // 
            // MnuTelefone
            // 
            this.MnuTelefone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroOperadoraToolStripMenuItem,
            this.cadastroTelefoneToolStripMenuItem});
            this.MnuTelefone.Name = "MnuTelefone";
            this.MnuTelefone.Size = new System.Drawing.Size(63, 20);
            this.MnuTelefone.Text = "Telefone";
            this.MnuTelefone.Visible = false;
            // 
            // cadastroOperadoraToolStripMenuItem
            // 
            this.cadastroOperadoraToolStripMenuItem.Name = "cadastroOperadoraToolStripMenuItem";
            this.cadastroOperadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroOperadoraToolStripMenuItem.Text = "Cadastro Operadora";
            this.cadastroOperadoraToolStripMenuItem.Click += new System.EventHandler(this.cadastroOperadoraToolStripMenuItem_Click);
            // 
            // cadastroTelefoneToolStripMenuItem
            // 
            this.cadastroTelefoneToolStripMenuItem.Name = "cadastroTelefoneToolStripMenuItem";
            this.cadastroTelefoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroTelefoneToolStripMenuItem.Text = "Cadastro Telefone";
            this.cadastroTelefoneToolStripMenuItem.Click += new System.EventHandler(this.cadastroTelefoneToolStripMenuItem_Click);
            // 
            // MnuCliente
            // 
            this.MnuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroTrabalhoToolStripMenuItem,
            this.cadastroTelefoneTrabalhoToolStripMenuItem,
            this.cadastroClienteToolStripMenuItem,
            this.cadastroTelefoneClienteToolStripMenuItem});
            this.MnuCliente.Name = "MnuCliente";
            this.MnuCliente.Size = new System.Drawing.Size(56, 20);
            this.MnuCliente.Text = "Cliente";
            this.MnuCliente.Visible = false;
            // 
            // cadastroTrabalhoToolStripMenuItem
            // 
            this.cadastroTrabalhoToolStripMenuItem.Name = "cadastroTrabalhoToolStripMenuItem";
            this.cadastroTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cadastroTrabalhoToolStripMenuItem.Text = "Cadastro Trabalho";
            this.cadastroTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.cadastroTrabalhoToolStripMenuItem_Click);
            // 
            // cadastroTelefoneTrabalhoToolStripMenuItem
            // 
            this.cadastroTelefoneTrabalhoToolStripMenuItem.Name = "cadastroTelefoneTrabalhoToolStripMenuItem";
            this.cadastroTelefoneTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cadastroTelefoneTrabalhoToolStripMenuItem.Text = "Cadastro Telefone Trabalho";
            this.cadastroTelefoneTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.cadastroTelefoneTrabalhoToolStripMenuItem_Click);
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // cadastroTelefoneClienteToolStripMenuItem
            // 
            this.cadastroTelefoneClienteToolStripMenuItem.Name = "cadastroTelefoneClienteToolStripMenuItem";
            this.cadastroTelefoneClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cadastroTelefoneClienteToolStripMenuItem.Text = "Cadastro Telefone Cliente";
            this.cadastroTelefoneClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroTelefoneClienteToolStripMenuItem_Click);
            // 
            // MnuFuncionario
            // 
            this.MnuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFunçãoToolStripMenuItem,
            this.cadastroFuncionárioToolStripMenuItem,
            this.cadastroTelefoneFuncionárioToolStripMenuItem});
            this.MnuFuncionario.Name = "MnuFuncionario";
            this.MnuFuncionario.Size = new System.Drawing.Size(82, 20);
            this.MnuFuncionario.Text = "Funcionario";
            this.MnuFuncionario.Visible = false;
            // 
            // cadastroFunçãoToolStripMenuItem
            // 
            this.cadastroFunçãoToolStripMenuItem.Name = "cadastroFunçãoToolStripMenuItem";
            this.cadastroFunçãoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.cadastroFunçãoToolStripMenuItem.Text = "Cadastro Função";
            this.cadastroFunçãoToolStripMenuItem.Click += new System.EventHandler(this.cadastroFunçãoToolStripMenuItem_Click);
            // 
            // cadastroFuncionárioToolStripMenuItem
            // 
            this.cadastroFuncionárioToolStripMenuItem.Name = "cadastroFuncionárioToolStripMenuItem";
            this.cadastroFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.cadastroFuncionárioToolStripMenuItem.Text = "Cadastro Funcionário";
            this.cadastroFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroFuncionárioToolStripMenuItem_Click);
            // 
            // cadastroTelefoneFuncionárioToolStripMenuItem
            // 
            this.cadastroTelefoneFuncionárioToolStripMenuItem.Name = "cadastroTelefoneFuncionárioToolStripMenuItem";
            this.cadastroTelefoneFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.cadastroTelefoneFuncionárioToolStripMenuItem.Text = "Cadastro Telefone Funcionário";
            this.cadastroTelefoneFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroTelefoneFuncionárioToolStripMenuItem_Click);
            // 
            // MnuFornecedor
            // 
            this.MnuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem,
            this.cadastroTelefoneFornecedorToolStripMenuItem});
            this.MnuFornecedor.Name = "MnuFornecedor";
            this.MnuFornecedor.Size = new System.Drawing.Size(79, 20);
            this.MnuFornecedor.Text = "Fornecedor";
            this.MnuFornecedor.Visible = false;
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // cadastroTelefoneFornecedorToolStripMenuItem
            // 
            this.cadastroTelefoneFornecedorToolStripMenuItem.Name = "cadastroTelefoneFornecedorToolStripMenuItem";
            this.cadastroTelefoneFornecedorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cadastroTelefoneFornecedorToolStripMenuItem.Text = "Cadastro Telefone Fornecedor";
            this.cadastroTelefoneFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroTelefoneFornecedorToolStripMenuItem_Click);
            // 
            // MnuProduto
            // 
            this.MnuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTipoToolStripMenuItem,
            this.cadastrarMarcaToolStripMenuItem,
            this.cadastroProdutoToolStripMenuItem,
            this.cadastrarImagemProdutoToolStripMenuItem});
            this.MnuProduto.Name = "MnuProduto";
            this.MnuProduto.Size = new System.Drawing.Size(62, 20);
            this.MnuProduto.Text = "Produto";
            this.MnuProduto.Visible = false;
            // 
            // cadastrarTipoToolStripMenuItem
            // 
            this.cadastrarTipoToolStripMenuItem.Name = "cadastrarTipoToolStripMenuItem";
            this.cadastrarTipoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarTipoToolStripMenuItem.Text = "Cadastrar Tipo";
            this.cadastrarTipoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTipoToolStripMenuItem_Click);
            // 
            // cadastrarMarcaToolStripMenuItem
            // 
            this.cadastrarMarcaToolStripMenuItem.Name = "cadastrarMarcaToolStripMenuItem";
            this.cadastrarMarcaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarMarcaToolStripMenuItem.Text = "Cadastrar Marca";
            this.cadastrarMarcaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMarcaToolStripMenuItem_Click);
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            this.cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            this.cadastroProdutoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            this.cadastroProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutoToolStripMenuItem_Click);
            // 
            // cadastrarImagemProdutoToolStripMenuItem
            // 
            this.cadastrarImagemProdutoToolStripMenuItem.Name = "cadastrarImagemProdutoToolStripMenuItem";
            this.cadastrarImagemProdutoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarImagemProdutoToolStripMenuItem.Text = "Cadastrar Imagem Produto";
            this.cadastrarImagemProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarImagemProdutoToolStripMenuItem_Click);
            // 
            // MnuCompra
            // 
            this.MnuCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraProdutoToolStripMenuItem});
            this.MnuCompra.Name = "MnuCompra";
            this.MnuCompra.Size = new System.Drawing.Size(62, 20);
            this.MnuCompra.Text = "Compra";
            this.MnuCompra.Visible = false;
            // 
            // compraProdutoToolStripMenuItem
            // 
            this.compraProdutoToolStripMenuItem.Name = "compraProdutoToolStripMenuItem";
            this.compraProdutoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.compraProdutoToolStripMenuItem.Text = "Compra Produto";
            this.compraProdutoToolStripMenuItem.Click += new System.EventHandler(this.compraProdutoToolStripMenuItem_Click);
            // 
            // MnuVenda
            // 
            this.MnuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaProdutoToolStripMenuItem});
            this.MnuVenda.Name = "MnuVenda";
            this.MnuVenda.Size = new System.Drawing.Size(51, 20);
            this.MnuVenda.Text = "Venda";
            this.MnuVenda.Visible = false;
            // 
            // vendaProdutoToolStripMenuItem
            // 
            this.vendaProdutoToolStripMenuItem.Name = "vendaProdutoToolStripMenuItem";
            this.vendaProdutoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendaProdutoToolStripMenuItem.Text = "Venda Produto";
            this.vendaProdutoToolStripMenuItem.Click += new System.EventHandler(this.vendaProdutoToolStripMenuItem_Click);
            // 
            // MnuFinanceiro
            // 
            this.MnuFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarSituaçãoToolStripMenuItem,
            this.cadastrarParcelaCompraToolStripMenuItem,
            this.cToolStripMenuItem});
            this.MnuFinanceiro.Name = "MnuFinanceiro";
            this.MnuFinanceiro.Size = new System.Drawing.Size(74, 20);
            this.MnuFinanceiro.Text = "Financeiro";
            this.MnuFinanceiro.Visible = false;
            // 
            // cadastrarSituaçãoToolStripMenuItem
            // 
            this.cadastrarSituaçãoToolStripMenuItem.Name = "cadastrarSituaçãoToolStripMenuItem";
            this.cadastrarSituaçãoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cadastrarSituaçãoToolStripMenuItem.Text = "Cadastrar Situação";
            this.cadastrarSituaçãoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSituaçãoToolStripMenuItem_Click);
            // 
            // cadastrarParcelaCompraToolStripMenuItem
            // 
            this.cadastrarParcelaCompraToolStripMenuItem.Name = "cadastrarParcelaCompraToolStripMenuItem";
            this.cadastrarParcelaCompraToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cadastrarParcelaCompraToolStripMenuItem.Text = "Cadastrar Parcela Compra";
            this.cadastrarParcelaCompraToolStripMenuItem.Click += new System.EventHandler(this.cadastrarParcelaCompraToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cToolStripMenuItem.Text = "Cadastrar Parcela Venda";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // MnuLoja
            // 
            this.MnuLoja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLojaToolStripMenuItem,
            this.cadastrarTelefoneLojasToolStripMenuItem});
            this.MnuLoja.Name = "MnuLoja";
            this.MnuLoja.Size = new System.Drawing.Size(41, 20);
            this.MnuLoja.Text = "Loja";
            this.MnuLoja.Visible = false;
            // 
            // cadastrarLojaToolStripMenuItem
            // 
            this.cadastrarLojaToolStripMenuItem.Name = "cadastrarLojaToolStripMenuItem";
            this.cadastrarLojaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadastrarLojaToolStripMenuItem.Text = "Cadastrar Loja";
            this.cadastrarLojaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLojaToolStripMenuItem_Click);
            // 
            // cadastrarTelefoneLojasToolStripMenuItem
            // 
            this.cadastrarTelefoneLojasToolStripMenuItem.Name = "cadastrarTelefoneLojasToolStripMenuItem";
            this.cadastrarTelefoneLojasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadastrarTelefoneLojasToolStripMenuItem.Text = "Cadastrar Telefone Loja";
            this.cadastrarTelefoneLojasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTelefoneLojasToolStripMenuItem_Click);
            // 
            // MnuLogin
            // 
            this.MnuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadastroLogin,
            this.MnuCadastroAcesso,
            this.MnuRegistros,
            this.logOutToolStripMenuItem});
            this.MnuLogin.Name = "MnuLogin";
            this.MnuLogin.Size = new System.Drawing.Size(49, 20);
            this.MnuLogin.Text = "Login";
            // 
            // MnuCadastroLogin
            // 
            this.MnuCadastroLogin.Name = "MnuCadastroLogin";
            this.MnuCadastroLogin.Size = new System.Drawing.Size(197, 22);
            this.MnuCadastroLogin.Text = "Cadastrar Login";
            this.MnuCadastroLogin.Visible = false;
            this.MnuCadastroLogin.Click += new System.EventHandler(this.MnuCadastroLogin_Click);
            // 
            // MnuCadastroAcesso
            // 
            this.MnuCadastroAcesso.Name = "MnuCadastroAcesso";
            this.MnuCadastroAcesso.Size = new System.Drawing.Size(197, 22);
            this.MnuCadastroAcesso.Text = "Cadastrar Acesso Login";
            this.MnuCadastroAcesso.Visible = false;
            this.MnuCadastroAcesso.Click += new System.EventHandler(this.MnuCadastroAcesso_Click);
            // 
            // MnuRegistros
            // 
            this.MnuRegistros.Name = "MnuRegistros";
            this.MnuRegistros.Size = new System.Drawing.Size(197, 22);
            this.MnuRegistros.Text = "Registros";
            this.MnuRegistros.Visible = false;
            this.MnuRegistros.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::trabalho_final.Properties.Resources.exit_to_app;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEndereco,
            this.MnuTelefone,
            this.MnuCliente,
            this.MnuLoja,
            this.MnuFuncionario,
            this.MnuFornecedor,
            this.MnuProduto,
            this.MnuCompra,
            this.MnuVenda,
            this.MnuFinanceiro,
            this.MnuLogin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistema_unifunecDataSet
            // 
            this.sistema_unifunecDataSet.DataSetName = "sistema_unifunecDataSet";
            this.sistema_unifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logarTableAdapter
            // 
            this.logarTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.logarTableAdapter = this.logarTableAdapter;
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
            // itensacessologinTableAdapter
            // 
            this.itensacessologinTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 500);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_unifunecDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sistema_unifunecDataSet sistema_unifunecDataSet;
        private sistema_unifunecDataSetTableAdapters.logarTableAdapter logarTableAdapter;
        private sistema_unifunecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sistema_unifunecDataSetTableAdapters.itensacessologinTableAdapter itensacessologinTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuEndereco;
        private System.Windows.Forms.ToolStripMenuItem ruaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuTelefone;
        private System.Windows.Forms.ToolStripMenuItem cadastroOperadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTelefoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCliente;
        private System.Windows.Forms.ToolStripMenuItem cadastroTrabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTelefoneTrabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTelefoneClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MnuProduto;
        private System.Windows.Forms.ToolStripMenuItem MnuCompra;
        private System.Windows.Forms.ToolStripMenuItem MnuVenda;
        private System.Windows.Forms.ToolStripMenuItem MnuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem MnuLoja;
        private System.Windows.Forms.ToolStripMenuItem MnuLogin;
        private System.Windows.Forms.ToolStripMenuItem MnuCadastroLogin;
        private System.Windows.Forms.ToolStripMenuItem MnuCadastroAcesso;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroFunçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTelefoneFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTelefoneLojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistros;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTelefoneFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarImagemProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSituaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarParcelaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
    }
}