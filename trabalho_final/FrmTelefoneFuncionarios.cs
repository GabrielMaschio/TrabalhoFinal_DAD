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
    public partial class FrmTelefoneFuncionarios : Form
    {
        public FrmTelefoneFuncionarios()
        {
            InitializeComponent();
        }

        private void itenstelefonefuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itenstelefonefuncionarioBindingSource.EndEdit();
        }

        private void FrmTelefoneFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelefonefuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonefuncionarioTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelefonefuncionario);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenstelefonefuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenstelefonefuncionarioTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenstelefonefuncionario);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenstelefonefuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenstelefonefuncionarioTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenstelefonefuncionario);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistema_unifunecDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelefonefuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonefuncionarioTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelefonefuncionario);

        }

        private void BtnPrimeiro_Click_1(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveFirst();
            vwitenstelefonefuncionarioBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click_1(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MovePrevious();
            vwitenstelefonefuncionarioBindingSource.MovePrevious();
        }

        private void BtnProximo_Click_1(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveNext();
            vwitenstelefonefuncionarioBindingSource.MoveNext();
        }

        private void BtnUltimo_Click_1(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveLast();
            vwitenstelefonefuncionarioBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtFuncionario.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnSalvar.Enabled = true;
            itenstelefonefuncionarioBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtFuncionario.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.RemoveCurrent();
            itenstelefonefuncionarioBindingSource.EndEdit();
            itenstelefonefuncionarioTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefonefuncionarioTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefonefuncionario);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtFuncionario.Enabled = false;
            TxtTelefone.Enabled = false;
            BtnSalvar.Enabled = false;
            itenstelefonefuncionarioBindingSource.EndEdit();
            itenstelefonefuncionarioTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelefonefuncionarioTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelefonefuncionario);
        }
    }
}
