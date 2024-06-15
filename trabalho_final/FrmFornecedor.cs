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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.sistema_unifunecDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.sistema_unifunecDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.sistema_unifunecDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.sistema_unifunecDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.sistema_unifunecDataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_fornecedorTableAdapter.Fill(this.sistema_unifunecDataSet.vw_fornecedor);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveFirst();
            vw_fornecedorBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MovePrevious();
            vw_fornecedorBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveNext();
            vw_fornecedorBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveLast();
            vw_fornecedorBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = true;
            TxtNumero.Enabled = true;
            TxtRua.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCEP.Enabled = true;
            TxtCidade.Enabled = true;
            BtnSalvar.Enabled = true;
            fornecedorBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = true;
            TxtNumero.Enabled = true;
            TxtRua.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCEP.Enabled = true;
            TxtCidade.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.RemoveCurrent();
            fornecedorBindingSource.EndEdit();
            fornecedorTableAdapter.Update(sistema_unifunecDataSet);
            vw_fornecedorTableAdapter.Fill(sistema_unifunecDataSet.vw_fornecedor);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = false;
            TxtNumero.Enabled = false;
            TxtRua.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCEP.Enabled = false;
            TxtCidade.Enabled = false;
            BtnSalvar.Enabled = false;

            fornecedorBindingSource.EndEdit();
            fornecedorTableAdapter.Update(sistema_unifunecDataSet);
            vw_fornecedorTableAdapter.Fill(sistema_unifunecDataSet.vw_fornecedor);
        }
    }
}
