using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BussinesLogicLayer;

namespace TotoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EProduct product = new EProduct();
            BOProduct Product = new BOProduct();
            product.Demand = true;
            product.Description = "Aqui la description";
            product.Name = "Producto 1";
            product.Price = 122;

            string result = Product.Create(product);
            Console.WriteLine (result);
            Console.ReadLine();

        }
    }
}
