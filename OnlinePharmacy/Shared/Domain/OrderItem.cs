using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class OrderItem
    {
        [Required(ErrorMessage = "Order Item ID is required")]
        [Display(Name = "Order Item ID")]
        public int OrderItemID { get; set; }

        [Required(ErrorMessage = "Order Item Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Order Item Quantity must be greater than 0")]
        [Display(Name = "Order Item Quantity")]
        public int OrderItemQty { get; set; }

        [Required(ErrorMessage = "Order Item Subtotal is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Order Item Subtotal must be greater than 0")]
        [DataType(DataType.Currency)]
        [Display(Name = "Order Item Subtotal")]
        public decimal? OrderItemSubTotal { get; set; }

        [Required(ErrorMessage = "Order ID is required")]
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        public virtual Order Order { get; set; }

        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        public virtual Product? Product { get; set; }
    }
}