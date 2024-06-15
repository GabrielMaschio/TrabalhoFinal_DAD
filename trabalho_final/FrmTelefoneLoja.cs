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
    public partial class FrmTelefoneLoja : Form
    {
        public FrmTelefoneLoja()
        {
            InitializeComponent();
        }

        private void FrmTelefoneLoja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenstelefoneloja'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenstelefonelojaTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenstelefoneloja);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelefoneloja'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonelojaTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelefoneloja);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.sistema_unifunecDataSet.loja);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveFirst();
            vwitenstelefonelojaBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MovePrevious();
            vwitenstelefonelojaBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveNext();
            vwitenstelefonelojaBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveLast();
            vwitenstelefonelojaBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtLoja.Enabled = true;
            TxtTelefone.Enabled = true;
            itenstelefonelojaBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtLoja.Enabled = true;
            TxtTelefone.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.RemoveCurrent();
            itenstelefonelojaBindingSource.EndEdit();
            itenstelefonelojaTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefonelojaTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefoneloja);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = false;
            TxtLoja.Enabled = false;
            TxtTelefone.Enabled = false;    
            itenstelefonelojaBindingSource.EndEdit();
            itenstelefonelojaTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefonelojaTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefoneloja);
        }
    }
}
