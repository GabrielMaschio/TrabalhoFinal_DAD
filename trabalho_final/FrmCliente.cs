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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void enableTxtBox()
        {
            TxtNomeCliente.Enabled = true;
            DtpNasc.Enabled = true;
            TxtSexo.Enabled = true;
            TxtNumero.Enabled = true;
            TxtRua.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCep.Enabled = true;
            TxtCidade.Enabled = true;
            TxtTrabalho.Enabled = true;
            TxtSalario.Enabled = true;
            BtnAddImg.Enabled = true;
        }

        private void disableTxtBox() {
            TxtNomeCliente.Enabled = false;
            DtpNasc.Enabled = false;
            TxtSexo.Enabled = false;
            TxtNumero.Enabled = false;
            TxtRua.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCep.Enabled = false;
            TxtCidade.Enabled = false;
            TxtTrabalho.Enabled = false;
            TxtSalario.Enabled = false;
            BtnAddImg.Enabled = false;
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

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.sistema_unifunecDataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.sistema_unifunecDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_clienteTableAdapter.Fill(this.sistema_unifunecDataSet.vw_cliente);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.sistema_unifunecDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.sistema_unifunecDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.sistema_unifunecDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.sistema_unifunecDataSet.sexo);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.sistema_unifunecDataSet.cliente);

        }

        private void BtnAddImg_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicCliente.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveFirst();
            vw_clienteBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
            vw_clienteBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
            vw_clienteBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
            vw_clienteBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            enableTxtBox();
            disableButtonsNavegation();
            BtnSalvar.Enabled = true;
            clienteBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            enableTxtBox();
            disableButtonsNavegation();
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            clienteBindingSource.RemoveCurrent();
            clienteBindingSource.EndEdit();
            clienteTableAdapter.Update(sistema_unifunecDataSet);
            vw_clienteTableAdapter.Fill(sistema_unifunecDataSet.vw_cliente);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            disableTxtBox();
            enableButtonsNavegation();
            BtnSalvar.Enabled = false;

            clienteBindingSource.EndEdit();
            clienteTableAdapter.Update(sistema_unifunecDataSet);
            vw_clienteTableAdapter.Fill(sistema_unifunecDataSet.vw_cliente);
        }
    }
}
