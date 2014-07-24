using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

// la clase DALUtility la saque del libro beging c# oriented programming 2nd. edition pag300
namespace DataAccessLayer
{
    class DALUtility
    {
        public static string GetSQLConnection(string name)
        {
            //Assume failure.
            string returnValue = null;
            ConnectionStringSettings settings
                = ConfigurationManager.ConnectionStrings[name];
            
            // If found, return the connection string.
            if (settings != null)
            {
                returnValue = settings.ConnectionString; 
            }
            return returnValue;

        }

        // ESTE CODIGO LO HIZE PARA PROBRAR LA CONNECTION LO IVA SACAR DEL LIBRO
        //public Boolean EstablishingConnection()
        //{
        //    SqlConnection pubConnection = new SqlConnection(ConnString);
        //    try
        //    {
        //        pubConnection.Open();
        //        //work with data
        //    }
        //    finally
        //    {

        //    }
        //    return true;
        //}
    }
}
