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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
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

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.sistema_unifunecDataSet.loja);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.funcaoTableAdapter.Fill(this.sistema_unifunecDataSet.funcao);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.sistema_unifunecDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.sistema_unifunecDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.sistema_unifunecDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.sistema_unifunecDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.vw_funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.funcionarios);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MoveFirst();
            vwfuncionariosBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MovePrevious();
            vwfuncionariosBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MoveNext();
            vwfuncionariosBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MoveLast();
            vwfuncionariosBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtNome.Enabled = true;
            TxtNumero.Enabled = true;
            TxtSalario.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCEP.Enabled = true;
            TxtCidade.Enabled = true;
            TxtFuncao.Enabled = true;
            TxtLoja.Enabled = true;
            TxtRua.Enabled = true;
            BtnSalvar.Enabled = true;
            funcionariosBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtNome.Enabled = true;
            TxtNumero.Enabled = true;
            TxtSalario.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCEP.Enabled = true;
            TxtCidade.Enabled = true;
            TxtFuncao.Enabled = true;
            TxtLoja.Enabled = true;
            TxtRua.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.RemoveCurrent();
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(sistema_unifunecDataSet);
            vw_funcionariosTableAdapter.Fill(sistema_unifunecDataSet.vw_funcionarios);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            TxtNome.Enabled = false;
            TxtNumero.Enabled = false;
            TxtSalario.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCEP.Enabled = false;
            TxtCidade.Enabled = false;
            TxtFuncao.Enabled = false;
            TxtLoja.Enabled = false;
            TxtRua.Enabled = false;
            BtnSalvar.Enabled = false;
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(sistema_unifunecDataSet);
            vw_funcionariosTableAdapter.Fill(sistema_unifunecDataSet.vw_funcionarios);
        }
    }
}
