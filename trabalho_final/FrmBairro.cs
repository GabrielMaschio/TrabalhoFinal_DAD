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
    public partial class FrmBairro : Form
    {
        public FrmBairro()
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

        private void bairroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bairroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmBairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.sistema_unifunecDataSet.bairro);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtBairro.Enabled = true;
            disableButtonsNavegation();
            bairroBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtBairro.Enabled = true;
            disableButtonsNavegation();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            bairroBindingSource.RemoveCurrent();
            bairroBindingSource.EndEdit();
            bairroTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            BtnSalvar.Enabled = false;
            TxtBairro.Enabled = false;
            bairroBindingSource.EndEdit();
            bairroTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
