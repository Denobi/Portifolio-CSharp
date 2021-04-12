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

//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS

using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace WindowsFormsApplication1
{
    public partial class frm_Report : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        string add;
        public frm_Report()
        {
            InitializeComponent();
        }
        string mysql = "Server=localhost;Database=db_lotof;Uid=root;pwd=1212"; // variavel para conexao
        string carg = "";
        int id = 1;
        string V1 = "";
        string sub = "";
        int conv;
        int exe1 = 0;
        string valum1 = " ";
        string valum2 = " ";
        string valum3 = " ";
        string valum4 = " ";
        string valum5 = " ";
        string valum6 = " ";
        string valum7 = " ";
        string valum8 = " ";
        string valum9 = " ";
        string valum10 = " ";
        string valum11 = " ";
        string valum12 = " ";
        string valum13 = " ";
        string valum14 = " ";
        string valum15 = " ";
        string valum16 = " ";
        string valum17 = " ";
        string valum18 = " ";
        string valum19 = " ";
        string valum20 = " ";
        string valum21 = " ";
        string valum22 = " ";
        string valum23 = " ";
        string valum24 = " ";
        string valum25 = " ";
        //int lId=10;
        int vulgo;

        public void DGVCONF()
        {
            //DataGridTableStyle ts1 = new DataGridTableStyle();
            //ts1.MappingName = "NUMEROS";
            //DEFINE COMO E OQUE PUXAR DA TABELA
            string TAB = "SELECT * FROM numeros ";//= @id ,@num";//select CodBarra, NomeProd ,QtdProd, ValorProd,idProd FROM tb_Prod WHERE CodBarra=@CodBarra", conexao
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
                dtgDados.DataSource = DTLIST;
                foreach (DataGridViewColumn column in dtgDados.Columns)
                {
                    if (column.DataPropertyName == "num")
                        column.Width = 60; //tamanho fixo da primeira coluna

                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        static void main(string[] args)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.rpv_relatorios.RefreshReport();
            DGVCONF();
            conexao = new MySqlConnection("Server=localhost;Database=db_lotof;Uid=root;pwd=1212");
            MySqlCommand comando = new MySqlCommand("SELECT MAX(id) FROM numeros", conexao);

            conexao.Open();
            vulgo = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();

            txb_Dataname.Text = DateTime.Now.ToShortDateString();
            txb_Dataname.Text = Convert.ToString(txb_Dataname.Text);
        }
        private void rpv_relatorios_Load(object sender, EventArgs e)
        {

        }

        private void dtgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int Total = 0;
            var Row = dtgDados.CurrentRow;

            carg = Row.Cells[0].Value.ToString();

            MessageBox.Show(carg);
        }

        private void dtgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_gerador_Click(object sender, EventArgs e)
        {



            if (id >= vulgo)
            {
                MessageBox.Show("Processamento concluido");
                string net = txb_Dataname.Text.Replace("/", "");
                var doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Projeto LOTO\WindowsFormsApplication1\RELATÓRIOS\" + net + ".pdf", FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph(" Relatórios"));
                doc.Add(new Paragraph("Quantidade de 01 : " + valum1.Length));
                doc.Add(new Paragraph("Quantidade de 02 : " + valum2.Length));
                doc.Add(new Paragraph("Quantidade de 03 : " + valum3.Length));
                doc.Add(new Paragraph("Quantidade de 04 : " + valum4.Length));
                doc.Add(new Paragraph("Quantidade de 05 : " + valum5.Length));
                doc.Add(new Paragraph("Quantidade de 06 : " + valum6.Length));
                doc.Add(new Paragraph("Quantidade de 07 : " + valum7.Length));
                doc.Add(new Paragraph("Quantidade de 08 : " + valum8.Length));
                doc.Add(new Paragraph("Quantidade de 09 : " + valum9.Length));
                doc.Add(new Paragraph("Quantidade de 10 : " + valum10.Length));
                doc.Add(new Paragraph("Quantidade de 11 : " + valum11.Length));
                doc.Add(new Paragraph("Quantidade de 12 : " + valum12.Length));
                doc.Add(new Paragraph("Quantidade de 13 : " + valum13.Length));
                doc.Add(new Paragraph("Quantidade de 14 : " + valum14.Length));
                doc.Add(new Paragraph("Quantidade de 15 : " + valum15.Length));
                doc.Add(new Paragraph("Quantidade de 16 : " + valum16.Length));
                doc.Add(new Paragraph("Quantidade de 17 : " + valum17.Length));
                doc.Add(new Paragraph("Quantidade de 18 : " + valum18.Length));
                doc.Add(new Paragraph("Quantidade de 19 : " + valum19.Length));
                doc.Add(new Paragraph("Quantidade de 20 : " + valum20.Length));
                doc.Add(new Paragraph("Quantidade de 21 : " + valum21.Length));
                doc.Add(new Paragraph("Quantidade de 22 : " + valum22.Length));
                doc.Add(new Paragraph("Quantidade de 23 : " + valum23.Length));
                doc.Add(new Paragraph("Quantidade de 24 : " + valum24.Length));
                doc.Add(new Paragraph("Quantidade de 25 : " + valum25.Length));

                doc.Close();

            }
            ////rpv_relatorios.Text = dtgDados.Rows.Cast<DataGridViewRow>().Sum(i => (i.Cells[num.Name].Value ?? 0)).ToString("##.00");
            //foreach (DataGridViewRow item in dtgDados.Rows)
            //{

            //}
            //var nomearq = txb_Dataname;
            //var Doc = new Document();
            //PdfWriter.GetInstance(Doc, new FileStream(@"C:\Projeto LOTO\WindowsFormsApplication1\RELATÓRIOS"+ txb_Dataname,FileMode.Create));
            //Doc.Open();

            //Doc.Add(new Paragraph(carg));

            //Doc.Close();
            if (V1 == "")
            {
                try
                {

                    conexao = new MySqlConnection("Server=localhost;Database=db_lotof;Uid=root;pwd=1212");
                    MySqlCommand comando = new MySqlCommand("select id, num FROM numeros WHERE id=@ID", conexao);
                    comando.Parameters.AddWithValue("ID", id);
                    comando.Parameters.AddWithValue("@NUM", carg);

                    conexao.Open();
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        carg = dr.GetString(0);
                        V1 = dr.GetString(1);
                        // lId = Convert.ToInt32(comando.ExecuteScalar());
                        // V1 = Convert.ToString(dr["num"]);
                        V1 = V1.Replace(" ", "");
                        sub = V1.Substring(0, 2);
                        conv = Convert.ToInt32(sub);
                        id = id + 1;
                        conexao.Close();
                        exe1 = exe1 + 1;
                        btn_gerador.PerformClick();

                        // lblResult.Text=Convert.ToString(dr["num"]);
                    };

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            if (exe1 == 500)
            {

                txb_te.Text = "500";
               
            }
            else if (V1 != "")
            {

                if (exe1 > 1)
                {
                    string g1 = Convert.ToString(V1);
                    //sub2 = g2;
                    sub = V1.Substring(0, 2);
                    conv = Convert.ToInt32(sub);
                }



                //sepCar = Convert .ToString(V1);
                //var F =V1.Remov;
                if (conv <= 05)
                {

                    if (conv == 01)
                    {
                        if (sub != " ")
                        {
                            valum1 = valum1 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 02)
                    {
                        if (sub != "")
                        {
                            valum2 = valum2 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 03)
                    {
                        if (sub != "")
                        {
                            valum3 = valum3 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 04)
                    {
                        if (sub != "")
                        {
                            valum4 = valum4 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 05)
                    {
                        if (sub != "")
                        {
                            valum5 = valum5 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                }
                if (conv <= 10)
                {
                    if (conv == 06)
                    {
                        if (sub != "")
                        {
                            valum6 = valum6 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }

                    if (conv == 07)
                    {
                        if (sub != "")
                        {
                            valum7 = valum7 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 08)
                    {
                        if (sub != "")
                        {
                            valum8 = valum8 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 09)
                    {
                        if (sub != "")
                        {
                            valum9 = valum9 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 10)
                    {
                        if (sub != "")
                        {
                            valum10 = valum10 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                }
                if (conv <= 15)
                {

                    if (conv == 11)
                    {
                        if (sub != "")
                        {
                            valum11 = valum11 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 12)
                    {
                        if (sub != "")
                        {
                            valum12 = valum12 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 13)
                    {
                        if (sub != "")
                        {
                            valum13 = valum13 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 14)
                    {
                        if (sub != "")
                        {
                            valum14 = valum14 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    if (conv == 15)
                    {
                        if (sub != "")
                        {
                            valum15 = valum15 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                }
                if (conv <= 20)
                {
                    if (conv == 16)
                    {
                        if (sub != "")
                        {
                            valum16 = valum16 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    else if (conv == 17)
                    {
                        if (sub != "")
                        {
                            valum17 = valum17 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    else if (conv == 18)
                    {
                        if (sub != "")
                        {
                            valum18 = valum18 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    else if (conv == 19)
                    {
                        if (sub != "")
                        {
                            valum19 = valum19 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }
                    else if (conv == 20)
                    {
                        if (sub != "")
                        {
                            valum20 = valum20 + ' ' + sub;
                            if (V1.Length > 2)
                            {
                                V1 = V1.Remove(0, 2);
                                exe1 = exe1 + 1;
                                btn_gerador.PerformClick();
                            }
                            else
                            {
                                exe1 = exe1 + 1;
                                V1 = "";
                                btn_gerador.PerformClick();
                            }
                        }
                    }

                }

            }
            if (conv <= 25)
            {
                if (conv == 21)
                {
                    if (sub != "")
                    {
                        valum21 = valum21 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btn_gerador.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btn_gerador.PerformClick();
                        }
                    }
                }
                else if (conv == 22)
                {
                    if (sub != "")
                    {
                        valum22 = valum22 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btn_gerador.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btn_gerador.PerformClick();
                        }
                    }
                }
                else if (conv == 23)
                {
                    if (sub != "")
                    {
                        valum23 = valum23 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btn_gerador.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btn_gerador.PerformClick();
                        }
                    }
                }
                else if (conv == 24)
                {
                    if (sub != "")
                    {
                        valum24 = valum24 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btn_gerador.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btn_gerador.PerformClick();
                        }
                    }
                }
                else if (conv == 25)
                {
                    if (sub != "")
                    {
                        valum25 = valum25 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btn_gerador.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btn_gerador.PerformClick();
                        }
                    }
                }
            }
        }
    }
}

//        else
//        {
//            var Doc = new Document();
//            PdfWriter.GetInstance(Doc, new FileStream(@"C:\Projeto LOTO\WindowsFormsApplication1\RELATÓRIOS" + txb_Dataname, FileMode.Create));
//            Doc.Open();

//            Doc.Add(new Paragraph(carg));

//            Doc.Close();
//        }
//    }
//}


//Read more: http://www.linhadecodigo.com.br/artigo/2582/gerando-arquivos-pdf-em-csharp.aspx#ixzz6oSrCccGe

