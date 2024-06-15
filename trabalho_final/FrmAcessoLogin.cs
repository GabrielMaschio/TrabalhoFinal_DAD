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
    public partial class FrmAcessoLogin : Form
    {
        public FrmAcessoLogin()
        {
            InitializeComponent();
        }

        private void FrmAcessoLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.acessoTableAdapter.Fill(this.sistema_unifunecDataSet.acesso);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itensacessologin'. Você pode movê-la ou removê-la conforme necessário.
            this.itensacessologinTableAdapter.Fill(this.sistema_unifunecDataSet.itensacessologin);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.logar'. Você pode movê-la ou removê-la conforme necessário.
            this.logarTableAdapter.Fill(this.sistema_unifunecDataSet.logar);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itensacessologin'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itensacessologinTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itensacessologin);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveFirst();
            vw_itensacessologinBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MovePrevious();
            vw_itensacessologinBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveNext();
            vw_itensacessologinBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveLast();
            vw_itensacessologinBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtUsuario.Enabled = true;
            TxtAcesso.Enabled = true;
            BtnSalvar.Enabled = true;
            itensacessologinBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Enabled = true;
            TxtAcesso.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.RemoveCurrent();
            itensacessologinBindingSource.EndEdit();
            itensacessologinTableAdapter.Update(sistema_unifunecDataSet);
            vw_itensacessologinTableAdapter.Fill(sistema_unifunecDataSet.vw_itensacessologin);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtAcesso.Enabled = false;
            TxtUsuario.Enabled = false;
            BtnSalvar.Enabled = false;

            itensacessologinBindingSource.EndEdit();
            itensacessologinTableAdapter.Update(sistema_unifunecDataSet);
            vw_itensacessologinTableAdapter.Fill(sistema_unifunecDataSet.vw_itensacessologin);
        }
    }
}
