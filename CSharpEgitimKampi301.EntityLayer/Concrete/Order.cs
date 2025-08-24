using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        // Siparişin ürünle ilişkisi burda isim olarak değiş quantity oalrak çoğul oalcağı için 1-n ilişkisi
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        //
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        // Customer ile ilişkisi 1-n
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
