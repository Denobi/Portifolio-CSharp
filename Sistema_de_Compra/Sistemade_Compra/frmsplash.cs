using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Sistemade_Compra
{
    public partial class frmsplash : Form
    {
        double Opacidade = 4.8;
        SoundPlayer music = new SoundPlayer(Properties.Settings.Default.caminho_music);

        public frmsplash()
        {
            InitializeComponent();
            music.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tmSplash_Tick(object sender, EventArgs e)
        {
            this.Opacity = Opacidade;
            Opacidade = Opacidade - 0.2;
            if (Opacidade <= 0)
            {
                tmSplash.Enabled = false;
                music.Stop();
                Frm_login frm1 = new Frm_login();
                frm1.Show();

                this.Hide();
            }
        }
    }
}
