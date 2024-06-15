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
    public partial class FrmCadastrarLogin : Form
    {
        public FrmCadastrarLogin()
        {
            InitializeComponent();
        }

        private void FrmCadastrarLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.logar'. Você pode movê-la ou removê-la conforme necessário.
            this.logarTableAdapter.Fill(this.sistema_unifunecDataSet.logar);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_logar'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_logarTableAdapter.Fill(this.sistema_unifunecDataSet.vw_logar);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            logarBindingSource.MoveFirst();
            vw_logarBindingSource.MoveFirst();
            
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            logarBindingSource.MovePrevious();
            vw_logarBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            logarBindingSource.MoveNext();
            vw_logarBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            logarBindingSource.MoveLast();
            vw_logarBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtFuncionario.Enabled = true;
            TxtSenha.Enabled = true;
            TxtUsuario.Enabled = true;
            logarBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            TxtFuncionario.Enabled = true;
            TxtSenha.Enabled = true;
            TxtUsuario.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            logarBindingSource.RemoveCurrent();
            logarBindingSource.EndEdit();
            logarTableAdapter.Update(sistema_unifunecDataSet.logar);
            vw_logarTableAdapter.Fill(sistema_unifunecDataSet.vw_logar);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = false;
            TxtFuncionario.Enabled = false;
            TxtSenha.Enabled = false;
            TxtUsuario.Enabled = false;
            logarBindingSource.EndEdit();
            logarTableAdapter.Update(sistema_unifunecDataSet.logar);
            vw_logarTableAdapter.Fill(sistema_unifunecDataSet.vw_logar);
        }
    }
}
