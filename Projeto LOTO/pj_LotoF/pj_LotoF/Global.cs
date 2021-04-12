using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace pj_LotoF
{
    class Global
    {
        //CONEXAO COM O BANCO
        public static MySqlConnection Conexao;
        //INSTRUÇÔES A SEREM EXECUTAS
        public static MySqlCommand Comando;
        //INSERIR dados em uma dataTable.
        public static MySqlDataAdapter Adaptador;
        //liga o banco em controles com propriedades DataSource
        public static DataTable datTabela;


        //---
        public static void conectar()
        {
            //CRIA OS PARAMETROS DE CONEXAO
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=1212");
            //ABRE A CONEXAO 
            Conexao.Open();
            //Verifica se existe o BD
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_lotoF; use bd_lotoF", Conexao);
            //Executa a Query no MySql
            Comando.ExecuteNonQuery();
            //
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS numeros" +
                                        "(id integer auto_increment primary key)", Conexao);
            //faz o comando acima ser executado.
            Comando.ExecuteNonQuery();
            //fecha a conexao com o banco de dados
            Conexao.Close();
        }
    }
}
