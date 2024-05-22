using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_final.sistema_unifunecDataSetTableAdapters;

namespace trabalho_final
{
    public partial class FrmCEP : Form
    {
        public FrmCEP()
        {
            InitializeComponent();
        }

        private void cepBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cepBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmCEP_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.sistema_unifunecDataSet.cep);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            cepBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtBairro.Enabled = true;
            cepBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtBairro.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            cepBindingSource.RemoveCurrent();
            cepBindingSource.EndEdit();
            cepTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = false;
            TxtBairro.Enabled = false;
            cepBindingSource.EndEdit();
            cepTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
