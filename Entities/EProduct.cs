using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EProduct
    {
        // =============== symbolic constants ==================
        #region Properties
            public Guid IdProduct { get; set; } // Lo vi en el video y en el libro pero no se que es
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public bool Demand { get; set; }
        #endregion

        // =============== constructors ==================
        #region Constructors
            public EProduct()
            {
            }
            public EProduct(Guid IdProduct, String Name, String Description, Decimal Money, Boolean Demand) : this()
            {
                this.IdProduct = IdProduct;
                this.Name = Name;
                this.Description = Description;
                this.Price = Price;
                this.Demand = Demand;
            }
        
        #endregion

    }
}
