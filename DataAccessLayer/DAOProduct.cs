using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Entities;

namespace DataAccessLayer
{
   public class DAOProduct
    {
       // SE PUEDE PONER AQUI PERO SE TENDRIA QUE PONER EN CADA CLASE MEJOR SE HIZO UNA CLASE LLAMADA UTILIDAD
        //private string _connString;

        //public string ConnString
        //{
        //    get
        //    {
        //        if (_connString==null)
        //        {
        //            _connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        //        }
        //        return _connString; 
        //    }
        //    set { _connString = value; }
        //}



        string connString = DALUtility.GetSQLConnection("conn");
        // como lo hace en el video
        public String Create(EProduct Product)  // como viene el libro // Ejemplo del libro beging C# Object Oriented Programming 2nd Edition
        // pag 164
        {
            using (SqlConnection totoConnection = new SqlConnection(connString)) // del libro
            {
                using (SqlCommand totoCommand = totoConnection.CreateCommand()) //Delvideo 
                    //tambien lo vi en el mismo libro pero aqui si estan cerrando connection tambien lo con new SqlConnection(connString)
                {
                    try
                    {
                        totoCommand.CommandText = "pa_add_product";
                        totoCommand.CommandType = CommandType.StoredProcedure;

                        totoCommand.Parameters.Add(new SqlParameter("@IdProduct", Product.IdProduct)); // como lo enseñaron en la escuela

                        totoCommand.Parameters.AddWithValue("@Name", Product.Name); // como lo vi en el video
                       
                        SqlParameter inputParameter =
                            totoCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 50);
                        inputParameter.Value = Product.Description;
                        inputParameter.Direction = ParameterDirection.Input; // esto ya es otra cosa me encontre quiero imaginar que es para indicar solomente que es de entrada o salida
                        // como viene el libro // Ejemplo del libro beging C# Object Oriented Programming 2nd Edition
                        // pag 164
                       
 
                        // libro de beginig C# object-Oriented Programming 2nd Edition pag 303
                        SqlParameter inParameter = new SqlParameter();
                        inParameter.ParameterName = "@Demand";
                        inParameter.Value = Product.Demand;
                        inParameter.DbType = DbType.Boolean;
                        inParameter.Direction = ParameterDirection.Input;
                        totoCommand.Parameters.Add(inParameter);

                        totoCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = Product.Price; //Como lo vi en MSDN

                        //OJO me atore aqui por que escribi Return parameter pero se uiliza cuando se utiliza alguna funcion el store procedure "nada confirmado"
                        //Ya entendi creamos un parametro tipo OUTPUT que es el mismo tipo que el de la base de datos que tambien es OUTPUT 
                        //SqlParameter ReturnParameter = new SqlParameter();
                        //ReturnParameter.ParameterName = "@ID"; // Ponemos el mismo nombre del OUTPUT utilizado en stored procedure
                        //ReturnParameter.Direction = ParameterDirection.ReturnValue;
                        //totoCommand.Parameters.Add(ReturnParameter);


                        SqlParameter outputParameter = totoCommand.Parameters.Add
                            ("@ID", SqlDbType.NVarChar, 50);
                        outputParameter.Direction = ParameterDirection.Output;


                        //string guidIdProduct;

                        totoConnection.Open(); // en el video y en el libro beging c# oop tambien abren conexion al final
                        totoCommand.ExecuteNonQuery();
                        //guidIdProduct = (string)totoCommand.Parameters["@ID"].Value;
                        return (string)outputParameter.Value;
                    }
                    catch (SqlException ex) // el bloque try en el vido no lo pone (video jesus mt)
                    {
                        throw ex;
                    }

                    //finally NO SE UTILIZA POR QUE ESTA UTILIZANDO "USING SQLCONNECTION Y ESTA LA CIERRA" pero si estan utilizando la linea 50 using (SqlCommand totoCommand = totoConnection.CreateCommand()) se tiene que cerrar esto ay que provarlo
                    //{
                    //    totoConnection.Dispose();
                    //}
                }
            }
        }


        // Ejemplo del libro beging C# Object Oriented Programming 2nd Edition
        // pag 164
        public int CountAllProducts()
        {
            using (SqlConnection totoConnection = new SqlConnection(connString))
            {
                using (SqlCommand totoCommand = new SqlCommand())
                {
                    try
                    {
                        totoConnection.Open();
                        totoCommand.Connection = totoConnection;
                        totoCommand.CommandText = "Select count(IdProduct) from products";
                        return (int)totoCommand.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }
            }
        }


        public DataTable GetAllProducts()
        {
            using (SqlConnection totoConnection = new SqlConnection(connString))
            {
                using (SqlCommand totoCommand = totoConnection.CreateCommand())
                {
                    totoCommand.CommandText = "Select * from Products";
                    totoCommand.CommandType = CommandType.Text;
                    using (SqlDataAdapter productAdapter = new SqlDataAdapter())
                    {
                        productAdapter.SelectCommand = totoCommand;
                        DataTable productDataTable = new DataTable();
                        productAdapter.Fill(productDataTable);
                        return productDataTable;
                    }

                }
            }
        }

        //if you are retrieving data from a single table or result set, you can populate and work with a DataTable directly without
        //creating a DataSet object. The Load method of the DataTable fills the table with the contents of a DataReader object.
        //The following code fills a DataTable with data from the publishers table of the Pubs database:
        public DataTable ReadAllProducts()
        {
            DataTable productDataTable = new DataTable();
            using (SqlConnection totoConnection = new SqlConnection(connString))
            {
                using (SqlCommand totoCommand = totoConnection.CreateCommand())
                {
                    totoConnection.Open();
                    totoCommand.CommandText = "Select * from Products";
                    totoCommand.CommandType = CommandType.Text;
                    using (SqlDataReader productDataReader = totoCommand.ExecuteReader())
                    {
                        productDataTable.Load(productDataReader);
                        return productDataTable;
                    }

                }
            }

        }


    }
}
