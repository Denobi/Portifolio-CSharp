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

namespace WindowsFormsApplication1
{
    public partial class FrmPesq : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        string add="";
        string V1 = "";
        string V2 = "";
        string sepnum1 = "";
        string sepnum2 = "";
        string sepnum3 = "";
        string sepnum4 = "";
        string sepnum5 = "";
        string sub = "";
        int conv = 0;
        string sub2 = "";
        int conv2 = 0;
        int exe1 = 0;
        int exe2 = 0;
        public FrmPesq()
        {
            InitializeComponent();
        }

        //    public void pesq()
        //    {

        //        btnPesq.PerformClick();
        //        //conexao = new MySqlConnection("Server=localhost;Database=db_lotof;Uid=root;pwd=1212");
        //        //    strSQL = "SELECT * FROM numeros WHERE num = @NUM";
        //        //    comando = new MySqlCommand(strSQL, conexao);
        //        //    comando.Parameters.AddWithValue("@NUM", txbPesq.Text);

        //        //    conexao.Open();
        //    
        //}//    dr = comando.ExecuteReader();

        private void FrmPesq_Load(object sender, EventArgs e)
        {
            /*  Global.conectar();*/
            lblResult.Visible = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbPesq.Text == "")
            {
                lblResult.Visible = true;
                lblResult.Text = "DIGITE ALGO ANTES";
                return;
            }
            //var pp = "";
            add = "S";
            if (add == "S")
            {
                conexao = new MySqlConnection("Server=localhost;Database=db_lotof;Uid=root;pwd=1212");
                strSQL = "SELECT * FROM numeros WHERE num = @NUM";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NUM", txbPesq.Text);

                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    lblResult.Visible = true;
                    lblResult.Text = "JÁ EXISTENTE";
                    txbPesq.Clear();
                    txbPesq.Focus();
                    return;
                    // lblResult.Text=Convert.ToString(dr["num"]);
                    
                };
                add = "N";
            }
            if (add == "N")
            {
                try
                {


                    conexao = new MySqlConnection("Server=localhost;Database=db_lotof;Uid=root;pwd=1212");
                    strSQL = "INSERT INTO numeros (NUM) VALUES (@NUM)";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NUM", txbPesq.Text);


                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    lblResult.Visible = true;
                    lblResult.Text = "ADICIONADO";
                    conexao.Close();
                }
            }
        }
        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (txbPesq.Text == "")
            {
                lblResult.Visible = true;
                lblResult.Text = "DIGITE ALGO ANTES";
                return;
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=db_lotof;Uid=root;pwd=1212");
                    strSQL = "SELECT * FROM numeros WHERE num = @NUM";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NUM", txbPesq.Text);

                    conexao.Open();
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        lblResult.Visible = true;
                        lblResult.Text = "JÁ EXISTENTE";

                        // lblResult.Text=Convert.ToString(dr["num"]);
                    };

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void txbPesq_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbPesq.Text == "")
            {
                txbPesq.Text = "";
                lblResult.Text = "";

            }
            else
            {
                txbPesq.Text = "";
                lblResult.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            if (exe1 == 0)
            {
                if (V1 == "")
                {
                    V1 = txbPesq.Text;
                    txbPesq.Clear();
                    lblResult.Visible = true;
                    lblResult.Text = "Digite o proximo numero";
                    V1 = V1.Replace(" ", "");
                    sub = V1.Substring(0, 2);
                    conv = Convert.ToInt32(sub);
                    //sepCar=
                    return;

                }

                if (V2 == "")
                {
                    V2 = txbPesq.Text;
                    txbPesq.Clear();
                    V2 = V2.Replace(" ", "");
                    sub2 = V2.Substring(0, 2);
                    conv2 = Convert.ToInt32(sub2);
                    exe1 = 1;
                    exe2 = 1;
                    btnComp.PerformClick();

                }
            }

            else if (V1 != "")
            {
                if (exe1 < 15)
                {
                    if (exe1 > 1)
                    {
                        string g1 = Convert.ToString(V1);
                        //sub2 = g2;
                        sub = V1.Substring(0, 2);
                        conv = Convert.ToInt32(sub);
                    }
                }


                //sepCar = Convert .ToString(V1);
                //var F =V1.Remov;
                if (conv <= 05)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;
                    if (sub != "")
                    {
                        sepnum1 = sepnum1 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btnComp.PerformClick();
                        }

                    }

                }
                if (conv <= 10)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;
                    if (sub != "")
                    {
                        sepnum2 = sepnum2 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btnComp.PerformClick();
                        }

                    }

                }
                if (conv <= 15)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;
                    if (sub != "")
                    {
                        sepnum3 = sepnum3 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btnComp.PerformClick();
                        }

                    }

                }
                if (conv <= 20)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;
                    if (sub != "")
                    {
                        sepnum4 = sepnum4 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btnComp.PerformClick();
                        }

                    }

                }
                if (conv <= 25)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;
                    if (sub != "")
                    {
                        sepnum5 = sepnum5 + ' ' + sub;
                        if (V1.Length > 2)
                        {
                            V1 = V1.Remove(0, 2);
                            exe1 = exe1 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe1 = exe1 + 1;
                            V1 = "";
                            btnComp.PerformClick();
                        }

                    }
                }
            }
            else if (V2 != "")
            {
                if (exe2 < 15)
                {
                    if (exe2 > 1 || exe2 < 14)
                    {
                        string g2 = Convert.ToString(V2);
                        //sub2 = g2;
                        sub2 = V2.Substring(0, 2);
                        conv2 = Convert.ToInt32(sub2);
                    }
                }
                if (conv2 <= 05)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;

                    if (sub2 != "")
                    {
                        sepnum1 = sepnum1 + ' ' + sub2;
                        if (V2.Length > 2)
                        {
                            V2 = V2.Remove(0, 2);
                            exe2 = exe2 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe2 = exe2 + 1;
                            V2 = "";
                            btnComp.PerformClick();
                        }

                    }
                }
                if (conv2 <= 10)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;

                    if (sub2 != "")
                    {
                        sepnum2 = sepnum2 + ' ' + sub2;
                        if (V2.Length > 2)
                        {
                            V2 = V2.Remove(0, 2);
                            exe2 = exe2 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe2 = exe2 + 1;
                            V2 = "";
                            btnComp.PerformClick();
                        }

                    }
                }
                if (conv2 <= 15)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;

                    if (sub2 != "")
                    {
                        sepnum3 = sepnum3 + ' ' + sub2;
                        if (V2.Length > 2)
                        {
                            V2 = V2.Remove(0, 2);
                            exe2 = exe2 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe2 = exe2 + 1;
                            V2 = "";
                            btnComp.PerformClick();
                        }

                    }
                }
                if (conv2 <= 20)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub;

                    if (sub2 != "")
                    {
                        sepnum4 = sepnum4 + ' ' + sub2;
                        if (V2.Length > 2)
                        {
                            V2 = V2.Remove(0, 2);
                            exe2 = exe2 + 1;
                            btnComp.PerformClick();
                        }
                        else
                        {
                            exe2 = exe2 + 1;
                            V2 = "";
                            btnComp.PerformClick();
                        }
                    }
                }
                if (conv2 <= 25)
                {
                    lblResult.Visible = true;
                    lblResult.Text = sub2;
                    if (sub != "")
                    {
                        sepnum5 = sepnum5 + ' ' + sub;

                        if (sub2 != "")
                        {
                            sepnum5 = sepnum5 + ' ' + sub2;
                            if (V2.Length > 2)
                            {
                                V2 = V2.Remove(0, 2);
                                exe2 = exe2 + 1;
                                btnComp.PerformClick();
                            }
                            else
                            {
                                exe2 = exe2 + 1;
                                V2 = "";
                                btnComp.PerformClick();
                            }
                        }

                    }
                }
            }
            else
            {
               
               
                //sepnum1.Length + ", " + sepnum2.Length + ", " + sepnum3.Length + ", " + sepnum4.Length + ", " + sepnum5.Length + ".";
                    MessageBox.Show("Os valores repetidos:" + "\n" 
                    + " De 00 a 05 : " + sepnum1 + "\n"
                    + " De 06 a 10 : " + sepnum2 + "\n"
                    + " De 11 a 15 : " + sepnum3 + "\n"
                    + " De 16 a 20 : " + sepnum4 + "\n"
                    + " De 21 a 25 : " + sepnum5 + ".");
                    

            }
        }
    }
}

               
                       