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
    public partial class FrmImagemProduto : Form
    {
        public FrmImagemProduto()
        {
            InitializeComponent();
        }

        private void imagensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmImagemProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.sistema_unifunecDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_imagem'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_imagemTableAdapter.Fill(this.sistema_unifunecDataSet.vw_imagem);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.imagens'. Você pode movê-la ou removê-la conforme necessário.
            this.imagensTableAdapter.Fill(this.sistema_unifunecDataSet.imagens);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            imagensBindingSource.MoveFirst();
            vw_imagemBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            imagensBindingSource.MovePrevious();
            vw_imagemBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            imagensBindingSource.MoveNext();
            vw_imagemBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            imagensBindingSource.MoveLast();
            vw_imagemBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtDesc.Enabled = true;
            TxtProduto.Enabled = true;
            BtnAddImg.Enabled = true;
            BtnSalvar.Enabled = true;
            imagensBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtDesc.Enabled = true;
            TxtProduto.Enabled = true;
            BtnAddImg.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            imagensBindingSource.RemoveCurrent();
            imagensBindingSource.EndEdit();
            imagensTableAdapter.Update(sistema_unifunecDataSet);
            vw_imagemTableAdapter.Fill(sistema_unifunecDataSet.vw_imagem);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtDesc.Enabled = false;
            TxtProduto.Enabled = false;
            BtnAddImg.Enabled = false;
            BtnSalvar.Enabled = false;

            imagensBindingSource.EndEdit();
            imagensTableAdapter.Update(sistema_unifunecDataSet);
            vw_imagemTableAdapter.Fill(sistema_unifunecDataSet.vw_imagem);
        }

        private void BtnAddImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicProduto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
