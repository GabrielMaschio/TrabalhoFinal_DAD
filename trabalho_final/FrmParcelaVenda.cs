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
    public partial class FrmParcelaVenda : Form
    {
        public FrmParcelaVenda()
        {
            InitializeComponent();
        }

        private void FrmParcelaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.sistema_unifunecDataSet.situacao);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vendaproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaprodutoTableAdapter.Fill(this.sistema_unifunecDataSet.vendaproduto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.parcelavenda'. Você pode movê-la ou removê-la conforme necessário.
            this.parcelavendaTableAdapter.Fill(this.sistema_unifunecDataSet.parcelavenda);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_parcelavenda'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_parcelavendaTableAdapter.Fill(this.sistema_unifunecDataSet.vw_parcelavenda);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            parcelavendaBindingSource.MoveFirst();
            vw_parcelavendaBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            parcelavendaBindingSource.MovePrevious();
            vw_parcelavendaBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            parcelavendaBindingSource.MoveNext();
            vw_parcelavendaBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            parcelavendaBindingSource.MoveLast();
            vw_parcelavendaBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtParcela.Enabled = true;
            TxtVenda.Enabled = true;
            TxtData.Enabled = true;
            TxtValor.Enabled = true;
            TxtSituacao.Enabled = true;
            BtnSalvar.Enabled = true;

            parcelavendaBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtParcela.Enabled = true;
            TxtVenda.Enabled = true;
            TxtData.Enabled = true;
            TxtValor.Enabled = true;
            TxtSituacao.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            parcelavendaBindingSource.RemoveCurrent();
            parcelavendaBindingSource.EndEdit();
            parcelavendaTableAdapter.Update(sistema_unifunecDataSet.parcelavenda);
            vw_parcelavendaTableAdapter.Fill(sistema_unifunecDataSet.vw_parcelavenda);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtParcela.Enabled = false;
            TxtVenda.Enabled = false;
            TxtData.Enabled = false;
            TxtValor.Enabled = false;
            TxtSituacao.Enabled = false;
            BtnSalvar.Enabled = false;

            parcelavendaBindingSource.EndEdit();
            parcelavendaTableAdapter.Update(sistema_unifunecDataSet.parcelavenda);
            vw_parcelavendaTableAdapter.Fill(sistema_unifunecDataSet.vw_parcelavenda);
        }
    }
}
