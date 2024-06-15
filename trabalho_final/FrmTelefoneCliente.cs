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
    public partial class FrmTelefoneCliente : Form
    {
        public FrmTelefoneCliente()
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

        private void FrmTelefoneCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.sistema_unifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itenstelcliente'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelclienteTableAdapter.Fill(this.sistema_unifunecDataSet.itenstelcliente);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.sistema_unifunecDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_itenstelcliente'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_itenstelclienteTableAdapter.Fill(this.sistema_unifunecDataSet.vw_itenstelcliente);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelclienteBindingSource.MoveFirst();
            vw_itenstelclienteBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            itenstelclienteBindingSource.MovePrevious();
            vw_itenstelclienteBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            itenstelclienteBindingSource.MoveNext();
            vw_itenstelclienteBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            itenstelclienteBindingSource.MoveLast();
            vw_itenstelclienteBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtCliente.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnSalvar.Enabled = true;
            itenstelclienteBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            disableButtonsNavegation();
            TxtCliente.Enabled = true;
            TxtTelefone.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            itenstelclienteBindingSource.RemoveCurrent();
            itenstelclienteBindingSource.EndEdit();
            itenstelclienteTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelclienteTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelcliente);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            enableButtonsNavegation();
            TxtCliente.Enabled = false;
            TxtTelefone.Enabled = false;
            BtnSalvar.Enabled = false;
            itenstelclienteBindingSource.EndEdit();
            itenstelclienteTableAdapter.Update(sistema_unifunecDataSet);
            vw_itenstelclienteTableAdapter.Fill(sistema_unifunecDataSet.vw_itenstelcliente);
        }
    }
}
