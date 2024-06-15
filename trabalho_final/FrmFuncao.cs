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
    public partial class FrmFuncao : Form
    {
        public FrmFuncao()
        {
            InitializeComponent();
        }

        private void enableButtonsNavegation()
        {
            BtnPrimeiro.Enabled = true;
            BtnAnterior.Enabled = true;
            BtnProximo.Enabled = true;
            BtnUltimo.Enabled = true;
        }

        private void disableButtonsNavegation()
        {
            BtnPrimeiro.Enabled = false;
            BtnAnterior.Enabled = false;
            BtnProximo.Enabled = false;
            BtnUltimo.Enabled = false;
        }

        private void funcaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmFuncao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.funcaoTableAdapter.Fill(this.sistema_unifunecDataSet.funcao);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtFuncao.Enabled = true;
            BtnSalvar.Enabled = true;
            funcaoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtFuncao.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.RemoveCurrent();
            funcaoBindingSource.EndEdit();
            funcaoTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            TxtFuncao.Enabled = false;
            BtnSalvar.Enabled = false;
            funcaoBindingSource.EndEdit();
            funcaoTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
