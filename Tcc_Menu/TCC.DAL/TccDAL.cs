using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.DTO;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TCC.DAL
{
    public class TccDAL
    {

        public List<TccDTO> Cargaprod()
        {
            try
            {
                MySqlConnection db_Tcc = new MySqlConnection();//CRIA UM OBJETO DO TIPO CONNECTION
                db_Tcc.ConnectionString = Properties.Settings.Default.db_Tcc;//ATRIBUINDO A STRING
                MySqlCommand comando = new MySqlCommand();//CRIANDO OBJETO COMMAND
                comando.CommandType = System.Data.CommandType.Text;//DEFININDO O TIPO DE COMANDO
                comando.CommandText = "SELECT * FROM PRODUTO ";//ATRIBUINDO O COMANDO MYSQL
                comando.Connection = db_Tcc;//DEFININDO A CONEXÃO COM O BANCO

                MySqlDataReader ER;//Le o role inteiro
                List<TccDTO> listaProdDTO = new List<TccDTO>();//lista o tipo da tabela
                db_Tcc.Open();//abre o role todo
                ER = comando.ExecuteReader();//Realizar a conexão
                if (ER.HasRows)//Se tiver linha retorna
                {
                    while (ER.Read())//Até o fim do leitor
                    {
                        TccDTO PROD = new TccDTO();//CRIA OBJETO *PROD* DA CLASSE TccDTO
                        PROD.CodBarra = Convert.ToString(ER["CodBarra"]);
                        PROD.Nomeprod = Convert.ToString(ER["NomeProd"]);
                        PROD.QtdProd = Convert.ToInt16(ER["QtdProd"]);
                        PROD.ValorProd = Convert.ToDecimal(ER["ValorProd"]);
                        listaProdDTO.Add(PROD);//ATRIBUINDO REGISTRO A LISTAPRODDTO

                    }
                }
                return listaProdDTO;//Retorna a lista p/ quem chamou

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
