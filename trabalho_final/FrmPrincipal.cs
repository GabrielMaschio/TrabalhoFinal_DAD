using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabalho_final
{
    public partial class FrmPrincipal : Form
    {
        Thread tPrincipal;
        String codLogin;

        public FrmPrincipal(string codlogin, string usuario)
        {
            InitializeComponent();
            codLogin = codlogin;
            LblUsuario.Text = "Usuário: " + usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.itensacessologin'. Você pode movê-la ou removê-la conforme necessário.
            this.itensacessologinTableAdapter.Fill(this.sistema_unifunecDataSet.itensacessologin);
            // TODO: esta linha de código carrega dados na tabela 'sistema_unifunecDataSet.logar'. Você pode movê-la ou removê-la conforme necessário.
            this.logarTableAdapter.Fill(this.sistema_unifunecDataSet.logar);

            DataTable dtAcessos = null;

            if(codLogin != null)
            {
                //DataTable recebe a consulta de um TableAdapter
                dtAcessos = itensacessologinTableAdapter.GetDataByCodLogin(int.Parse(codLogin));

                if (dtAcessos.Rows.Count > 0)
                {
                    DataTableReader dtr = dtAcessos.CreateDataReader();

                    while (dtr.Read())
                    {
                        switch (dtr["codacesso_fk"])
                        {
                            case 1:
                                MnuEndereco.Visible = true;
                                MnuTelefone.Visible = true;
                                MnuCliente.Visible = true;
                                MnuFuncionario.Visible = true;
                                MnuFornecedor.Visible = true;
                                MnuProduto.Visible = true;
                                MnuCompra.Visible = true;
                                MnuVenda.Visible = true;
                                MnuFinanceiro.Visible = true;
                                MnuLoja.Visible = true;
                                MnuCadastroLogin.Visible = true;
                                MnuCadastroAcesso.Visible = true;
                                break;
                            case 2:
                                MnuFornecedor.Visible = true;
                                break;
                            case 3:
                                MnuProduto.Visible = true;
                                break;
                            case 4:
                                MnuCompra.Visible = true;
                                break;
                            case 5:
                                MnuVenda.Visible = true;
                                break;
                            case 6:
                                MnuFuncionario.Visible = true;
                                break;
                            case 7:
                                MnuCliente.Visible = true;
                                break;
                            case 8:
                                MnuEndereco.Visible = true;
                                break;
                            case 9:
                                MnuLoja.Visible = true;
                                break;
                            case 10:
                                MnuFinanceiro.Visible = true;
                                break;
                            case 11:
                                MnuCadastroLogin.Visible = true;
                                MnuCadastroAcesso.Visible = true;
                                break;
                            case 12:
                                MnuTelefone.Visible = true;
                                break;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Não foi possivel pegar o código de login!");
            }
        }

        private void ruaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRua frmRua = new FrmRua();   
            frmRua.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            tPrincipal = new Thread(openWindow);
            tPrincipal.SetApartmentState(ApartmentState.STA);
            tPrincipal.Start();
        }

        private void openWindow(object obj)
        {
            Application.Run(new FrmLogin());
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCEP frmCEP = new FrmCEP();
            frmCEP.ShowDialog();
        }

        private void cadastroOperadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperadora frmOperadora = new FrmOperadora();
            frmOperadora.ShowDialog();
        }

        private void cadastroTelefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.ShowDialog();
        }

        private void cadastroTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabalho frmTrabalho = new FrmTrabalho();
            frmTrabalho.ShowDialog();
        }

        private void cadastroTelefoneTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelefoneTrabalho frmTelefoneTrabalho = new FrmTelefoneTrabalho();
            frmTelefoneTrabalho.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
