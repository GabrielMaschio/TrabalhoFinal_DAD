using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_final.sistema_unifunecDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabalho_final
{
    public partial class FrmCompraProduto : Form
    {
        public FrmCompraProduto()
        {
            InitializeComponent();
        }

        private void FrmCompraProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.parcelacompra'. Você pode movê-la ou removê-la conforme necessário.
            this.parcelacompraTableAdapter.Fill(this.sistema_unifunecDataSet.parcelacompra);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.sistema_unifunecDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenscompraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.itenscompraprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.itenscompraproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.sistema_unifunecDataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenscompraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenscompraprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenscompraproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.compraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.compraprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.compraproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_compraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_compraprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.vw_compraproduto);
            if(!TxtCodCompra.Text.Equals(""))
            {
                int codcompra = Convert.ToInt32(TxtCodCompra.Text);
                itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.itenscompraproduto, codcompra);
                vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, codcompra);
            }

            

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.MovePrevious();

            int codcompra = Convert.ToInt32(TxtCodCompra.Text);
            TxtCodigoCompra.Text = TxtCodCompra.Text;


            itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
            vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, codcompra);

            double valor = 0;

            valor = Convert.ToDouble(itenscompraprodutoTableAdapter.TotalCompra(codcompra).ToString());

            LblTotal.Text = valor.ToString("C", CultureInfo.CurrentCulture);
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.MoveNext();

            int codcompra = Convert.ToInt32(TxtCodCompra.Text);
            TxtCodigoCompra.Text = TxtCodCompra.Text;


            itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
            vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, codcompra);

            double valor = 0;

            valor = Convert.ToDouble(itenscompraprodutoTableAdapter.TotalCompra(codcompra).ToString());

            LblTotal.Text = valor.ToString("C", CultureInfo.CurrentCulture);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtData.Enabled = true;
            TxtFornecedor.Enabled = true;
            TxtFuncionario.Enabled = true;
            BtnSalvar.Enabled = true;
            LblTotal.Text = "R$ 0,00";
            compraprodutoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtData.Enabled = true;
            TxtFornecedor.Enabled = true;
            TxtFuncionario.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            int codcompra = Convert.ToInt32(TxtCodCompra.Text);

            itenscompraprodutoTableAdapter.DeletarProduto(codcompra);
            parcelacompraTableAdapter.DeletarParcelas(codcompra);

            compraprodutoBindingSource.RemoveCurrent();
            compraprodutoBindingSource.EndEdit();
            compraprodutoTableAdapter.Update(sistema_unifunecDataSet.compraproduto);

            if(!TxtCodCompra.Text.Equals(""))
            {
                itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
                vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtData.Enabled = false;
            TxtFornecedor.Enabled = false;
            TxtFuncionario.Enabled = false;
            BtnAnterior.Enabled = false;
            BtnProximo.Enabled = false;
            BtnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = false;

            BoxAddProduto.Enabled = true;

            compraprodutoBindingSource.EndEdit();
            compraprodutoTableAdapter.Update(sistema_unifunecDataSet.compraproduto);

            itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
            vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));

            TxtCodigoCompra.Text = TxtCodCompra.Text;
        }

        private void BtnAnteriorP_Click(object sender, EventArgs e)
        {

        }

        private void BtnProximoP_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovoP_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = true;
            TxtQuantidade.Enabled = true;
            TxtValor.Enabled = true;
            BtnSalvarP.Enabled = true;

            itenscompraprodutoBindingSource.AddNew();
            TxtCodigoCompra.Text = TxtCodCompra.Text;
        }

        private void BtnEditarP_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = true;
            TxtQuantidade.Enabled = true;
            TxtValor.Enabled = true;
            BtnSalvarP.Enabled = true;
        }

        private void BtnExcluirP_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.RemoveCurrent();
            itenscompraprodutoBindingSource.EndEdit();
            itenscompraprodutoTableAdapter.Update(sistema_unifunecDataSet.itenscompraproduto);

            itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
            vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, Convert.ToInt32(TxtCodCompra.Text));
        }

        private void BtnSalvarP_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = false;
            TxtQuantidade.Enabled = false;
            TxtValor.Enabled = false;
            BtnSalvarP.Enabled = false;

            int codcompra = Convert.ToInt32(TxtCodigoCompra.Text);
            String produto = TxtProduto.Text;
            int quantidade = Convert.ToInt32(TxtQuantidade.Text);

            //Executa a consulta que verifica se existe este produto nesta venda
            int contprodutocompra = (int)itenscompraprodutoTableAdapter.VerificarProdutoNaCompra(codcompra, produto);

            //Se não existir este produto nesta venda, insere no banco
            if (contprodutocompra == 0)
            {
                itenscompraprodutoBindingSource.EndEdit();
                itenscompraprodutoTableAdapter.Update(sistema_unifunecDataSet);
            }
            //Se existir este produto na venda, atualiza o total vendido na
            //tabela vendaproduto
            else
            {
                itenscompraprodutoBindingSource.CancelEdit();
                itenscompraprodutoTableAdapter.AtualizaProdutoRepetido(quantidade, codcompra, produto);
            }

            //Atualiza a tabela produto (estoque)... remove o que foi vendido                 
            produtoTableAdapter.AtualizaProdutoCompra(quantidade, produto);

            //Atualiza a View VendaProduto para Adicionar os elementos na tabela.
            vw_itenscompraprodutoTableAdapter.FillByCodCompra(sistema_unifunecDataSet.vw_itenscompraproduto, codcompra);

            //Variável que armazena o valor total da venda
            double valor = 0;

            //Realiza a consulta para capturar o total geral da venda
            valor = Convert.ToDouble(itenscompraprodutoTableAdapter.TotalCompra(codcompra).ToString());

            //Formata o valor para o Formato em Reais
            LblTotal.Text = valor.ToString("C", CultureInfo.CurrentCulture);


        }

        private void TxtProduto_Leave(object sender, EventArgs e)
        {
            DataTable dt = null;

            //DataTable recebe a consulta de um TableAdapter
            dt = produtoTableAdapter.GetDataByNomeProduto(TxtProduto.Text);

            DataTableReader dtr = dt.CreateDataReader();

            if (dtr.Read())
            {
                TxtValor.Text = dtr["valor"].ToString();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itenscompraprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.itenscompraproduto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TxtProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtCodigoCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
