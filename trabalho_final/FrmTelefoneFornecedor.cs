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
    public partial class FrmTelefoneFornecedor : Form
    {
        public FrmTelefoneFornecedor()
        {
            InitializeComponent();
        }

        private void FrmTelefoneFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelefonefornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonefornecedorTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelefonefornecedor);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.sistema_unifunecDataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenstelefonefornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenstelefonefornecedorTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenstelefonefornecedor);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MoveFirst();
            vw_itenstelefonefornecedorBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MovePrevious();
            vw_itenstelefonefornecedorBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MoveNext();
            vw_itenstelefonefornecedorBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MoveLast();
            vw_itenstelefonefornecedorBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtFornecedor.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnSalvar.Enabled = true;
            itenstelefonefornecedorBindingSource.AddNew();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtFornecedor.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.RemoveCurrent();
            itenstelefonefornecedorBindingSource.EndEdit();
            itenstelefonefornecedorTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefonefornecedorTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefonefornecedor);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtFornecedor.Enabled = false;
            TxtTelefone.Enabled = false;
            BtnSalvar.Enabled = false;

            itenstelefonefornecedorBindingSource.EndEdit();
            itenstelefonefornecedorTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefonefornecedorTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefonefornecedor);

        }
    }
}
