using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VictoriaPlumbing.Domain.Models
{
    public class CustomerItems
    {

        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the order number of the order.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the product id of the item
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the item
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// gets or sets the order object
        /// </summary>
        public virtual Order Order { get; set; }
    }
}
