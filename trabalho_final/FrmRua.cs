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
    public partial class FrmRua : Form
    {
        public FrmRua()
        {
            InitializeComponent();
        }

        private void ruaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ruaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_unifunecDataSet);

        }

        private void FrmRua_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.sistema_unifunecDataSet.rua);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveLast();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtRua.Enabled = true;
            BtnSalvar.Enabled = true;
            ruaBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TxtRua.Enabled = false;
            BtnSalvar.Enabled = false;
            ruaBindingSource.EndEdit();
            ruaTableAdapter.Update(sistema_unifunecDataSet);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtRua.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            ruaBindingSource.RemoveCurrent();
            ruaBindingSource.EndEdit();
            ruaTableAdapter.Update(sistema_unifunecDataSet);
        }
    }
}
