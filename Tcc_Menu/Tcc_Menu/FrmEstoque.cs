using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;

using System.Drawing.Imaging;

namespace Tcc_Menu
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }
        string mysql = "Server=localhost;Database=db_tcc;User=root;password=1212"; // variavel para conexao

        //DEFINI O CAMINHO PARA AS IMAGENS DO CODIGO DE BARRAS 
        String BARRA = @"D:\Tcc_Menu\COD_BARRAS";

        //PARA GERAR O CODIGO DE BARRA
        BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();

        //TODAS STRINGS E VARIAVEIS SÃO EM LETRA MAIUSCULA
        string PROC = "";
        string PRECO;

        //CONVERSÃO DE VALORES
        private string converterParaOFormatoIngles(string numero)
        {
            System.Globalization.CultureInfo myInfo = System.Globalization.CultureInfo.CurrentUICulture;
            Decimal d = Decimal.Parse(numero, myInfo); //123.45
            return d.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat);//123,45
        }
        //====DATAGREAD CONFIGUREICHON=====\\
        public void DGVCONF()
        {
            //DEFINE COMO E OQUE PUXAR DA TABELA
            string TAB = "SELECT * FROM Tb_Prod";
            //INICIA AS CONFIGURAÇÕES
            MySqlConnection OBJCON = new MySqlConnection(mysql);
            MySqlCommand OBJCOM = new MySqlCommand(TAB, OBJCON);
            try
            {
                //DEFININDO AS TABELAS
                MySqlDataAdapter MDA = new MySqlDataAdapter(OBJCOM);
                //DEFINE A TABELA ESPECIFICAMENTE
                DataTable DTLIST = new DataTable();
                //PARA PREENCHER A TABELA DEFINI 
                MDA.Fill(DTLIST);
                //DEFINI O CAMINHO PARA PREENCHER O DATAGRAED
                dgvEstoque.DataSource = DTLIST;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //public void desabilitaBotoes()
        //{
        //    btnNovo.Enabled = false;
        //    btnApagar.Enabled = false;
        //    btnAlterar.Enabled = false;
        //    btnCancelar.Enabled = true;
        //    btnGravar.Enabled = true;
        //    gbProduto.Enabled = true;
        //}

        //public void habilitaBotoes()
        //{
        //    btnNovo.Enabled = true;
        //    btnApagar.Enabled = true;
        //    btnAlterar.Enabled = true;
        //    btnCancelar.Enabled = false;
        //    btnGravar.Enabled = false;
        //    gbProduto.Enabled = false;
        //}
        public void Limpar()
        {
            txtCodBarra.Clear();
            txtNomeProd.Clear();
            txtQtd.Clear();
            txtValUni.Clear();
        }
        private void FrmEstoque_MouseClick(object sender, MouseEventArgs e)
        {
            //frmMenu fl1 = new frmMenu();
            //fl1.Show();
            //this.Hide();
        }

        private void FrmEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu fl1 = new frmMenu();
            fl1.Show();
            this.Hide();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_tccDataSet.tb_prod' table. You can move, or remove it, as needed.
            DGVCONF();

        }


        private void btnCad_Click(object sender, EventArgs e)
        {

            //DEFININDO AQUI AS STRINGS
            string CodBarra = txtCodBarra.Text;
            string NomeProd = txtNomeProd.Text;
            string Qtd = txtQtd.Text;
            string ValorUnit = txtValUni.Text;
            //CHECAGEM DOS TEXTOS
            PRECO = txtValUni.Text.Replace(".", ",");
            try
            {
                PRECO = converterParaOFormatoIngles(txtValUni.Text);
            }
            catch
            {
                lblMensag.Text = "Preço Inválido";
            }

            //COISAS DO BANCO DE DADOS
            MySqlConnection conexao = new MySqlConnection(mysql);
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = conexao;
            conexao.Open();
            Query.CommandText = "INSERT INTO tb_prod(CodBarra,NomeProd,QtdProd,ValorProd) VALUES(@CodBarra,@NomeProd,@QtdProd,@ValorProd)";
            Query.Parameters.AddWithValue("@CodBarra", CodBarra);
            Query.Parameters.AddWithValue("@NomeProd", NomeProd);
            Query.Parameters.AddWithValue("@QtdProd", Qtd);
            Query.Parameters.AddWithValue("@ValorProd", ValorUnit);
            Query.ExecuteNonQuery();
            conexao.Close();
            //PARAMETROS CRIADOS NO FORM
            DGVCONF();


        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //txtPesq.Text = Convert.ToString(txtPesq.Text);
            ////PUXANDO DO BANCO
            //string func = "SELECT * FROM tb_Prod where CodBarra = @CodBarra";
            ////CONFIGURANDO O ROLE INTEIRO
            //MySqlConnection CONEXAO = new MySqlConnection(mysql);
            //MySqlCommand COMANDO = new MySqlCommand(func, CONEXAO);
            ////DEFININDO O BAGULHO INTEIRO
            //COMANDO.Parameters.Add("@CodBarra", MySqlDbType.Int32).Value = txtCodBarra.Text;

            //try
            //{
            //    if (txtCodBarra.Text == "")
            //    {
            //        lblMensag.Text = "Produto não encontrado ou não Cadastrado ";
            //        lblMensag.BackColor = Color.Red;
            //        txtPesq.Focus();
            //    }
            //    CONEXAO.Open();
            //    MySqlDataReader READER = COMANDO.ExecuteReader();

            //    //if (READER.HasRows == false)
            //    //{

            //    //}

            //    READER.Read();
            //    txtCodBarra.Text = Convert.ToString(READER["CodBarra"]);
            //    txtNomeProd.Text = Convert.ToString(READER["NomeProd"]);
            //    txtQtd.Text = Convert.ToString(READER["QtdProd"]);
            //    txtValUni.Text = Convert.ToString(READER["ValorProd"]);

            //}
            //catch (Exception ex)
            //{
            //    lblMensag.Text = ex.Message + "";
            //}
            //finally
            //{
            //    CONEXAO.Close();
            //}

            //txtCodBarra.Text = Convert.ToString(txtCodBarra.Text);
            txtQtd.Text = Convert.ToString(txtQtd.Text);
            txtValUni.Text = Convert.ToString(txtValUni.Text);
            MySqlConnection Conex = new MySqlConnection(mysql);
            if (txtPesq.Text == "")
            {
                MessageBox.Show("Informe o código do produto que deseja pesquisar", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesq.Focus();
                Limpar();
                return;
            }
            try
            {

                MySqlCommand Comand = new MySqlCommand("SELECT NomeProd,QtdProd,ValorProd FROM tb_Prod WHERE CodBarra = "+txtCodBarra.Text , Conex);
                Conex.Open();
                Comand.Parameters.AddWithValue("@CodBarra", txtCodBarra.Text);
                Comand.CommandType = CommandType.Text;
                MySqlDataReader dr = Comand.ExecuteReader();
                dr.Read();
                txtNomeProd.Text = dr.GetString(0);
                txtQtd.Text = dr.GetString(1);
                txtValUni.Text = dr.GetString(2);
                /* if(dr.Read()){
                 txtNomeProd.Text = dr.GetString(0);
                 txtQtd.Text = dr.GetString(1);
                 txtValUni.Text = dr.GetString(2);
                 }*/


                Conex.Close();

                //txtNomeProd.Text = Convert.ToString(sdr["NomeProd"]);
                //txtQtd.Text = Convert.ToString(sdr["QtdProd"]);
                //txtValUni.Text = Convert.ToString(sdr["ValorProd"]);
                //txtCodBarra.Text = Convert.ToString(sdr["CodBarra"]);
                //MySqlDataReader sdr = Comand.ExecuteReader();
                // sdr.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Produto não registrado", "erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesq.Clear();
                txtPesq.Focus();
                Limpar();
                return;
            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (txtNomeProd.Text == "")
            {
                MessageBox.Show("Selecione um Produto!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesq.Focus();
            }
            else
            {
                //desabilitaBotoes();
                txtNomeProd.Focus();
                PROC = "UPDATE";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPesq.Enabled = false;
            //txtNmprod.Enabled = false;
            btnPesquisa.Enabled = false;
            //  btnConscod.Enabled = false;
            PROC = "INSERT";
        }

        private void btnExclud_Click(object sender, EventArgs e)
        {
            if (txtNomeProd.Text == "")
            {
                MessageBox.Show("Selecione um Produto a ser excluido!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeProd.Focus();
                Limpar();
            }
            else
            {
                // desabilitaBotoes();
                PROC = "DELETE";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPesq.Clear();
            Limpar();
            PROC = "";
        }

        private void tbprodBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Codigo.IncludeLabel = true;
                pnBarras.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtNomeProd.Text, Color.Black, Color.White, 300, 100);
                Image imgCod = (Image)pnBarras.BackgroundImage.Clone();
                imgCod.Save(BARRA + "\\" + txtNomeProd.Text +txtCodBarra.Text+ ".png", ImageFormat.Png);
    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}