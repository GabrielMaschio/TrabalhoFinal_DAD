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
    public partial class FrmOperadora : Form
    {
        public FrmOperadora()
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

        private void operadoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operadoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void operadoraBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.operadoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmOperadora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.sistema_unifunecDataSet.operadora);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtOperadora.Enabled = true;
            BtnSalvar.Enabled = true;
            disableButtonsNavegation();
            operadoraBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtOperadora.Enabled = true;
            BtnSalvar.Enabled = true;
            disableButtonsNavegation();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.RemoveCurrent();
            operadoraBindingSource.EndEdit();
            operadoraTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtOperadora.Enabled = false;
            BtnSalvar.Enabled = false;
            enableButtonsNavegation();
            operadoraBindingSource.EndEdit();
            operadoraTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
