using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcc_Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCaixa fr1 = new frmCaixa();
            fr1.Show();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbEstoque_click(object sender, EventArgs e)
        {
            FrmEstoque fr2 = new FrmEstoque();
            fr2.Show();
            this.Hide();
        }

        private void pbContas(object sender, EventArgs e)
        {
            Frm_Contas fr5 = new Frm_Contas();
            fr5.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
          //  txtFunc.Text = "Não existe um funcionario logado!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque fl1 = new FrmEstoque();
            fl1.Show();
            this.Hide();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa fl2 = new frmCaixa();
            fl2.Show();
            this.Hide();
        }

        private void btnEstoque_Click_1(object sender, EventArgs e)
        {
            FrmEstoque fl3 = new FrmEstoque();
            fl3.Show();
            this.Hide();
        }

     }
}
