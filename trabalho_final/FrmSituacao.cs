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
    public partial class FrmSituacao : Form
    {
        public FrmSituacao()
        {
            InitializeComponent();
        }

        private void situacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.situacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmSituacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.sistema_unifunecDataSet.situacao);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtSituacao.Enabled = true;
            BtnSalvar.Enabled = true;
            situacaoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtSituacao.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.RemoveCurrent();
            situacaoBindingSource.EndEdit();
            situacaoTableAdapter.Update(sistema_unifunecDataSet.situacao);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtSituacao.Enabled = false;
            BtnSalvar.Enabled = false;

            situacaoBindingSource.EndEdit();
            situacaoTableAdapter.Update(sistema_unifunecDataSet.situacao);
        }
    }
}
