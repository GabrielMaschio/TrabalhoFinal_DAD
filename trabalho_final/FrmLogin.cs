using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace trabalho_final
{
    public partial class FrmLogin : Form
    {
        Thread tLogin;

        public FrmLogin()
        {
            InitializeComponent();
        }

        DataTable dtLogins = null;



        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //DataTable recebe a consulta de um TableAdapter
            dtLogins = logarTableAdapter.GetDataByUsuarioSenha(TxtUsuario.Text, TxtSenha.Text);

            if (dtLogins.Rows.Count > 0)
            {
                this.Close();
                tLogin = new Thread(openWindow);
                tLogin.SetApartmentState(ApartmentState.STA);
                tLogin.Start();
            }
            else
            {   
                LblAlert.Visible = true;
            }
        }

        private void openWindow(object obj)
        {
            DataTableReader dtr = dtLogins.CreateDataReader();
            dtr.Read();

            Application.Run(new FrmPrincipal(dtr["codlogin"].ToString(), dtr["usuario"].ToString()));
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.logar'. Você pode movê-la ou removê-la conforme necessário.
            this.logarTableAdapter.Fill(this.sistema_unifunecDataSet.logar);

        }
    }
}
