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
    public partial class FrmParcelaCompra : Form
    {
        public FrmParcelaCompra()
        {
            InitializeComponent();
        }

        private void FrmParcelaCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.compraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.compraprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.compraproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.sistema_unifunecDataSet.situacao);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.parcelacompra'. Você pode movê-la ou removê-la conforme necessário.
            this.parcelacompraTableAdapter.Fill(this.sistema_unifunecDataSet.parcelacompra);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_parcelacompra'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_parcelacompraTableAdapter.Fill(this.sistema_unifunecDataSet.vw_parcelacompra);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MoveFirst();
            vw_parcelacompraBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MovePrevious();
            vw_parcelacompraBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MoveNext();
            vw_parcelacompraBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MoveLast();
            vw_parcelacompraBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtParcela.Enabled = true;
            TxtCompra.Enabled = true;
            TxtData.Enabled = true;
            TxtValor.Enabled = true;
            TxtSituacao.Enabled = true;
            BtnSalvar.Enabled = true;
            parcelacompraBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtParcela.Enabled = true;
            TxtCompra.Enabled = true;
            TxtData.Enabled = true;
            TxtValor.Enabled = true;
            TxtSituacao.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.RemoveCurrent();
            parcelacompraBindingSource.EndEdit();
            parcelacompraTableAdapter.Update(sistema_unifunecDataSet.parcelacompra);
            vw_parcelacompraTableAdapter.Fill(sistema_unifunecDataSet.vw_parcelacompra);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtParcela.Enabled = false;
            TxtCompra.Enabled = false;
            TxtData.Enabled = false;
            TxtValor.Enabled = false;
            TxtSituacao.Enabled = false;
            BtnSalvar.Enabled = false;

            parcelacompraBindingSource.EndEdit();
            parcelacompraTableAdapter.Update(sistema_unifunecDataSet.parcelacompra);
            vw_parcelacompraTableAdapter.Fill(sistema_unifunecDataSet.vw_parcelacompra);
        }
    }
}
