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
    public partial class frmCaixa : Form
    {


        public frmCaixa()
        {
            InitializeComponent();
        }

        //public void Soma()
        //{
        //        try{

        //  lblTotal.Text=(Convert.ToDecimal(txtVUni.Text)+(Convert.ToDecimal(lblTotal.Text)).ToString();
        //    }
        //    catch(Exception ex){
        //        MessageBox.Show("ERRO:"+ex);
        //    }
        //}

        Double vl1;
        Double vl2;


     
        private void frmCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu fl1 = new frmMenu();
            fl1.Show();
            this.Hide();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtTotal.Text == "")
            //{
            //    txtTotal.Text = "0";
            //}
            //if (txtQtd.Text == "")
            //{
            //    txtQtd.Text = "1";
            //}
            ////CALCULA OS VALORES

            //vl1 = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtVUni.Text);
            //vl2 = Convert.ToDouble(txtTotal.Text) + vl1;
            //txtTotal.Text = Convert.ToString(vl2);
        }

        private void frmCaixa_MouseClick(object sender, MouseEventArgs e)
        {
            frmMenu fl1 = new frmMenu();
            fl1.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                txtTotal.Text = "0";
            }
            if (txtQtd.Text == "")
            {
                txtQtd.Text = "1";
            }
            //CALCULA OS VALORES

            vl1 = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtVUni.Text);
            vl2 = Convert.ToDouble(txtTotal.Text) + vl1;
            txtTotal.Text = Convert.ToString(vl2);
        }

        private void txtProdPesq_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTotal.Text == "")
            {
                txtTotal.Text = "0";
            }
            if (txtQtd.Text == "")
            {
                txtQtd.Text = "1";
            }
            //CALCULA OS VALORES

            vl1 = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtVUni.Text);
            vl2 = Convert.ToDouble(txtTotal.Text) + vl1;
            txtTotal.Text = Convert.ToString(vl2);
        }

        private void txtProdPesq_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
