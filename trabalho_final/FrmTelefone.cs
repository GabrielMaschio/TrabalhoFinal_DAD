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
    public partial class FrmTelefone : Form
    {
        public FrmTelefone()
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

        private void telefoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmTelefone_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.vw_telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.sistema_unifunecDataSet.operadora);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtNumero.Enabled = true;
            TxtOperadora.Enabled = true;
            BtnSalvar.Enabled = true;
            disableButtonsNavegation();
            telefoneBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtNumero.Enabled = true;
            TxtOperadora.Enabled = true;    
            BtnSalvar.Enabled = true;
            disableButtonsNavegation();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.RemoveCurrent();
            telefoneBindingSource.EndEdit();
            telefoneTableAdapter.Update(sistema_unifunecDataSet);
            vw_telefoneTableAdapter.Fill(sistema_unifunecDataSet.vw_telefone);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtNumero.Enabled = false;
            TxtOperadora.Enabled = false;
            BtnSalvar.Enabled = false;
            enableButtonsNavegation();
            telefoneBindingSource.EndEdit();
            telefoneTableAdapter.Update(sistema_unifunecDataSet);
            vw_telefoneTableAdapter.Fill(sistema_unifunecDataSet.vw_telefone);
        }
    }
}
