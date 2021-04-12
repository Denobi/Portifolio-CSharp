using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistemade_Compra
{
    public partial class frm_Etecword : Form
    {
        public frm_Etecword()
        {
            InitializeComponent();
        }

        private void frm_Etecword_Load(object sender, EventArgs e)
        {

        }

        private void btnLer_Click(object sender, EventArgs e)
        {

            openFD.ShowDialog();
            txtNomeArq.Text = openFD.FileName;
            if (txtNomeArq.Text != "")
            {
                System.IO.StreamReader vleitor = new System.IO.StreamReader(txtNomeArq.Text);
                rtbetecWord.Clear();
                txtER.Text = vleitor.ReadLine();
                vleitor.ReadLine();
                rtbetecWord.Text = vleitor.ReadToEnd();
                vleitor.Close();
            }

        }

        private void btnGrav_Click(object sender, EventArgs e)
        {
            saveFD.FileName = txtNomeArq.Text;
            if (txtNomeArq.Text != "")
            {
                gravacao();
            }
            else
            {
                saveFD.ShowDialog();
                txtNomeArq.Text = saveFD.FileName;
                gravacao();
            }
        }
        private void gravacao()
        {
            //System.IO.StreamWriter vGravador = new System.IO.StreamWriter(txtNomeArq.Text);
            //vGravador.Write(rtbetecWord.Text);
            //vGravador.Close();
            //MessageBox.Show("Arquivo gravado com sucesso!");
            System.IO.StreamWriter vGravador = new System.IO.StreamWriter(txtNomeArq.Text);
            vGravador.WriteLine("Fulano de tal");
            vGravador.WriteLine(System.DateTime.Now.Date);
            vGravador.Write(rtbetecWord.Text);
            vGravador.Close();
            MessageBox.Show("Arquivo gravado com sucesso!");
        }
    }
}
