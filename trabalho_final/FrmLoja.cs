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
    public partial class FrmLoja : Form
    {
        public FrmLoja()
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


        private void lojaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lojaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmLoja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.sistema_unifunecDataSet.loja);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtNome.Enabled = true;
            TxtCnpJ.Enabled = true;
            TxtFantasia.Enabled = true;
            TxtRazao.Enabled = true;
            BtnSalvar.Enabled = true;
            lojaBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtNome.Enabled = true;
            TxtCnpJ.Enabled = true;
            TxtFantasia.Enabled = true;
            TxtRazao.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            lojaBindingSource.RemoveCurrent();
            lojaBindingSource.EndEdit();
            lojaTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            TxtNome.Enabled = false;
            TxtCnpJ.Enabled = false;
            TxtFantasia.Enabled = false;
            TxtRazao.Enabled = false;
            BtnSalvar.Enabled = false;
            lojaBindingSource.EndEdit();
            lojaTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
