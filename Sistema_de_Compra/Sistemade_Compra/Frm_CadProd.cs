using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;

namespace Sistemade_Compra
{
    public partial class Frm_CadProd : Form
    {
        public Frm_CadProd()
        {
            InitializeComponent();
        }
        //public DirectX.Capture.Filter Camera;
        //public DirectX.Capture.Capture CaptureInfo;
        //public DirectX.Capture.Filters CamContainer;
        //Image capturaImagem;
        //public string caminhoImagemSalva = null;
        private FilterInfoCollection Disp;
        private VideoCaptureDevice Imag_disp;
    

        private void Frm_CadProd_Load(object sender, EventArgs e)
        {
            //CamContainer = new DirectX.Capture.Filters();

            //try
            //{
            //    int no_of_cam = CamContainer.VideoInputDevices.Count;
            //    for (int i = 0; i < no_of_cam; i++)
            //    {
            //        try
            //        {
            //            // obtém o dispositivo de entrada do vídeo
            //            Camera = CamContainer.VideoInputDevices[i];
            //            // inicializa a Captura usando o dispositivo
            //            CaptureInfo = new DirectX.Capture.Capture(Camera, null);
            //            // Define a janela de visualização do vídeo
            //            CaptureInfo.PreviewWindow = this.PbCam;
            //            // Capturando o tratamento de evento
            //            CaptureInfo.FrameCaptureComplete += AtualizaImagem;
            //            // Captura o frame do dispositivo
            //            CaptureInfo.CaptureFrame();
            //            // Se o dispositivo foi encontrado e inicializado então sai sem checar o resto
            //            break;
            //        }
            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, ex.Message);
            //}
            lblMeng.Text = "";
            Disp = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in Disp)
            {
                cbDisp.Items.Add(device.Name);
            }
            Imag_disp = new VideoCaptureDevice();

        }

        //private void AtualizaImagem(PictureBox Frame)
        //{
        //    try
        //    {
        //        capturaImagem = Frame.Image;
        //        this.PbCam.Image = capturaImagem;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro " + ex.Message);
        //    }
        //}

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if(cbDisp.Text==""){
                lblMeng.Text = "selecione a camera desejada!!";


            }
            else{
                lblMeng.Text = "";
                Imag_disp = new VideoCaptureDevice(Disp[cbDisp.SelectedIndex].MonikerString);

                Imag_disp.NewFrame += new NewFrameEventHandler(Imag_disp_NewFrame);
                Imag_disp.Start();
            }
        }
        private void Imag_disp_NewFrame(object sender, NewFrameEventArgs EventArgs)
        {

            Bitmap image = (Bitmap)EventArgs.Frame.Clone();
            PbCam.Image = image;


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Imag_disp.IsRunning)
            {
                Imag_disp.Stop();
                PbCam.Image = null;
                PbCam.Invalidate();
            }
           
        }

        private void Frm_CadProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Imag_disp.IsRunning)
            {
                Imag_disp.Stop();
            }
        }

        private void btnCapt_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    CaptureInfo.CaptureFrame();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro " + ex.Message);
            //}
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
//            try
//            {
//                caminhoImagemSalva = @"c:\dados\" + "ImagemWebCam" + DateTime.Now.Day.ToString() +
//DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg";
//                PbCam.Image.Save(caminhoImagemSalva, ImageFormat.Jpeg);
//                MessageBox.Show("Imagem salva com sucesso");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Erro " + ex.Message);
//            }
        }
    }
}
