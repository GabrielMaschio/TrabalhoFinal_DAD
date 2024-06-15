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
    public partial class FrmRegistros : Form
    {
        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.vw_controlelogsistema'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_controlelogsistemaTableAdapter.Fill(this.sistema_unifunecDataSet.vw_controlelogsistema);

        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            vw_controlelogsistemaBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            vw_controlelogsistemaBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            vw_controlelogsistemaBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            vw_controlelogsistemaBindingSource.MoveLast();
        }
    }
}
