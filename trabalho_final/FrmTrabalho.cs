using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_final.sistema_unifunecDataSetTableAdapters;

namespace trabalho_final
{
    public partial class FrmTrabalho : Form
    {
        public FrmTrabalho()
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

        private void FrmTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelefonetrabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonetrabalhoTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelefonetrabalho);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.sistema_unifunecDataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_trabalhoTableAdapter.Fill(this.sistema_unifunecDataSet.vw_trabalho);
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            BtnSalvar.Enabled = true;
            TxtNomeTrabalho.Enabled = true;
            trabalhoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            BtnSalvar.Enabled = true;
            TxtNomeTrabalho.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.RemoveCurrent();
            trabalhoBindingSource.EndEdit();
            trabalhoTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            BtnSalvar.Enabled = false;
            TxtNomeTrabalho.Enabled = false;
            trabalhoBindingSource.EndEdit();
            trabalhoTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
