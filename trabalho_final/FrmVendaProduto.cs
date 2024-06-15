using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_final.sistema_unifunecDataSetTableAdapters;

namespace trabalho_final
{
    public partial class FrmVendaProduto : Form
    {
        public FrmVendaProduto()
        {
            InitializeComponent();
        }

        private void vendaprodutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaprodutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmVendaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.parcelavenda'. Você pode movê-la ou removê-la conforme necessário.
            this.parcelavendaTableAdapter.Fill(this.sistema_unifunecDataSet.parcelavenda);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.sistema_unifunecDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itensvendaproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.itensvendaprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.itensvendaproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itensvendaproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itensvendaprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itensvendaproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.sistema_unifunecDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vendaproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.vendaproduto);

            if(!TxtCodVenda.Text.Equals(""))
            {
                int codvenda = Convert.ToInt32(TxtCodVenda.Text);

                vw_itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.vw_itensvendaproduto, codvenda);
                itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.itensvendaproduto, codvenda);
            }

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            vendaprodutoBindingSource.MovePrevious();

            int codvenda = Convert.ToInt32(TxtCodVenda.Text);

            vw_itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.vw_itensvendaproduto, codvenda);
            itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.itensvendaproduto, codvenda);

            //Variável que armazena o valor total da venda
            double valor = 0;

            //Realiza a consulta para capturar o total geral da venda
            valor = Convert.ToDouble(itensvendaprodutoTableAdapter.TotalVenda(codvenda).ToString());

            //Formata o valor para o Formato em Reais
            LblTotal.Text = valor.ToString("C", CultureInfo.CurrentCulture);
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            vendaprodutoBindingSource.MoveNext();

            int codvenda = Convert.ToInt32(TxtCodVenda.Text);

            vw_itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.vw_itensvendaproduto, codvenda);
            itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.itensvendaproduto, codvenda);

            //Variável que armazena o valor total da venda
            double valor = 0;

            //Realiza a consulta para capturar o total geral da venda
            valor = Convert.ToDouble(itensvendaprodutoTableAdapter.TotalVenda(codvenda).ToString());

            //Formata o valor para o Formato em Reais
            LblTotal.Text = valor.ToString("C", CultureInfo.CurrentCulture);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtData.Enabled = true;
            TxtCliente.Enabled = true;
            TxtFuncionario.Enabled = true;
            BtnSalvar.Enabled = true;

            LblTotal.Text = "R$ 0,00";
            vendaprodutoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtData.Enabled = true;
            TxtCliente.Enabled = true;
            TxtFuncionario.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codvenda = Convert.ToInt32(TxtCodVenda.Text);

            itensvendaprodutoTableAdapter.DeletarProdutos(codvenda);
            parcelavendaTableAdapter.DeletarParcelas(codvenda);

            vendaprodutoBindingSource.RemoveCurrent();
            vendaprodutoBindingSource.EndEdit();
            vendaprodutoTableAdapter.Update(sistema_unifunecDataSet.vendaproduto);

            if (TxtCodVenda.Text.Equals(""))
            {
                vw_itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.vw_itensvendaproduto, codvenda);
                itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.itensvendaproduto, codvenda);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtData.Enabled = false;
            TxtCliente.Enabled = false;
            TxtFuncionario.Enabled = false;
            BtnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnProximo.Enabled = false;
            BtnAnterior.Enabled = false;

            BoxAddProduto.Enabled = true;

            vendaprodutoBindingSource.EndEdit();
            vendaprodutoTableAdapter.Update(sistema_unifunecDataSet.vendaproduto);

            TxtCodVendaFK.Text = TxtCodVenda.Text;
        }

        private void BtnNovoP_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = true;
            TxtQuantidade.Enabled = true;
            TxtValor.Enabled = true;
            BtnSalvarP.Enabled = true;

            itensvendaprodutoBindingSource.AddNew();
            TxtCodVendaFK.Text = TxtCodVenda.Text;
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
            itensvendaprodutoBindingSource.RemoveCurrent();
            itensvendaprodutoBindingSource.EndEdit();
            itensvendaprodutoTableAdapter.Update(sistema_unifunecDataSet.itensvendaproduto);

            vw_itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.vw_itensvendaproduto, Convert.ToInt32(TxtCodVenda.Text));
            itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.itensvendaproduto, Convert.ToInt32(TxtCodVenda.Text));
        }

        private void BtnSalvarP_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = false;
            TxtQuantidade.Enabled = false;
            TxtValor.Enabled = false;
            BtnSalvarP.Enabled = false;

            int codvenda = Convert.ToInt32(TxtCodVenda.Text);
            String produto = TxtProduto.Text;
            int quantidade = Convert.ToInt32(TxtQuantidade.Text);

            //Executa a consulta que verifica se existe este produto nesta venda
            int contprodutovenda = (int)itensvendaprodutoTableAdapter.VerificarProdutoVenda(codvenda, produto);

            //Se não existir este produto nesta venda, insere no banco
            if (contprodutovenda == 0)
            {
                itensvendaprodutoBindingSource.EndEdit();
                itensvendaprodutoTableAdapter.Update(sistema_unifunecDataSet);
            }
            //Se existir este produto na venda, atualiza o total vendido na
            //tabela vendaproduto
            else
            {
                itensvendaprodutoBindingSource.CancelEdit();
                itensvendaprodutoTableAdapter.AtualizarProdutoRepetido(quantidade, codvenda, produto);
            }

            //Atualiza a tabela produto (estoque)... remove o que foi vendido                 
            produtoTableAdapter.AtualizarProdutoVenda(quantidade, produto);

            //Atualiza a View VendaProduto para Adicionar os elementos na tabela.
            vw_itensvendaprodutoTableAdapter.FillByCodVenda(sistema_unifunecDataSet.vw_itensvendaproduto, codvenda);

            //Variável que armazena o valor total da venda
            double valor = 0;

            //Realiza a consulta para capturar o total geral da venda
            valor = Convert.ToDouble(itensvendaprodutoTableAdapter.TotalVenda(codvenda).ToString());

            //Formata o valor para o Formato em Reais
            LblTotal.Text = valor.ToString("C", CultureInfo.CurrentCulture);
        }

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
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
    
    }
}
