using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_final
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.tipo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoTableAdapter.Fill(this.sistema_unifunecDataSet.tipo);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.sistema_unifunecDataSet.marca);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.sistema_unifunecDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_produtoTableAdapter.Fill(this.sistema_unifunecDataSet.vw_produto);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MoveFirst();
            vw_produtoBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MovePrevious();
            vw_produtoBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MoveNext();
            vw_produtoBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MoveLast();
            vw_produtoBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = true;
            TxtQuantidade.Enabled = true;
            TxtValor.Enabled = true;
            TxtTipo.Enabled = true;
            TxtMarca.Enabled = true;
            BtnSalvar.Enabled = true;
            produtoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = true;
            TxtQuantidade.Enabled = true;
            TxtValor.Enabled = true;
            TxtTipo.Enabled = true;
            TxtMarca.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            produtoBindingSource.RemoveCurrent();
            produtoBindingSource.EndEdit();
            produtoTableAdapter.Update(sistema_unifunecDataSet);
            vw_produtoTableAdapter.Fill(sistema_unifunecDataSet.vw_produto);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtProduto.Enabled = false;
            TxtQuantidade.Enabled = false;
            TxtValor.Enabled = false;
            TxtTipo.Enabled = false;
            TxtMarca.Enabled = false;
            BtnSalvar.Enabled = false;

            produtoBindingSource.EndEdit();
            produtoTableAdapter.Update(sistema_unifunecDataSet);
            vw_produtoTableAdapter.Fill(sistema_unifunecDataSet.vw_produto);
        }
    }
}
