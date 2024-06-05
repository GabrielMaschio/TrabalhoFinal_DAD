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
    public partial class FrmTelefoneTrabalho : Form
    {
        public FrmTelefoneTrabalho()
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


        private void itenstelefonetrabalhoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itenstelefonetrabalhoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmTelefoneTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenstelefone'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenstelefoneTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenstelefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.sistema_unifunecDataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelefonetrabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonetrabalhoTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelefonetrabalho);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveFirst();
            vwitenstelefoneBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MovePrevious();
            vwitenstelefoneBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveNext();
            vwitenstelefoneBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveLast();
            vwitenstelefoneBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtTelefone.Enabled = true;
            TxtTrabalho.Enabled = true;
            BtnSalvar.Enabled = true;
            itenstelefonetrabalhoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtTelefone.Enabled = true;
            TxtTrabalho.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.RemoveCurrent();
            itenstelefonetrabalhoBindingSource.EndEdit();
            itenstelefonetrabalhoTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefoneTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefone);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            TxtTelefone.Enabled = false;
            TxtTrabalho.Enabled = false;
            BtnSalvar.Enabled = false;
            itenstelefonetrabalhoBindingSource.EndEdit();
            itenstelefonetrabalhoTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefoneTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefone);
        }
    }
}
