using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using Entities;

namespace BussinesLogicLayer
{
    public class BOProduct
    {
        DAOProduct product = new DAOProduct();
        public string Create(EProduct Product)
        {
            if (Product.IdProduct == Guid.Empty)
            {
                Product.IdProduct = Guid.NewGuid(); 
            }
            
            if (string.IsNullOrWhiteSpace(Product.Name))
            {
                throw new ArgumentNullException("Name Bussines Object Messeage"); 
            }

            if (string.IsNullOrWhiteSpace(Product.Description))
            {
                //Product.Description = Product.Description ?? "hola ";
                throw new ArgumentNullException("Description"); 
            }

            //if (Product.Demand)  este no se pone por que siempre va tener un valor ya que es boleano
            //{
            //    throw new ArgumentNullException("Producto sobre demanda");
            //}

            if (Product.Price <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Price",
                    string.Format("El valor: '{0}' esta fuera del rango verfica", Product.Price)); 
            }

            return product.Create(Product);

        }


        public DataTable GetAllProducts()
        {
            return product.GetAllProducts(); 
        }

        public DataTable ReadAllProducts()
        {
            return product.ReadAllProducts();
        }

        public int CountAllProducts()
        {
            return product.CountAllProducts();
        }


    }
}
