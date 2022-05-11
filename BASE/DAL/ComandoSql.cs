using System.Collections.Generic;
using System.Data.SqlClient;


namespace DAL
{
    public class ComandoSql
    {

        private SqlCommand comando;
        private List<ParametosSql> parametros;

        public List<ParametosSql> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }


    }//comandoSQL

}//dal