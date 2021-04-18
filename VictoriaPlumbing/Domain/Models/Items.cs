using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VictoriaPlumbing
{
    public class Items
    {
        [Key]
        /// <summary>
        /// Gets or sets the product id of the item
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the sku code of the item
        /// </summary>
        public string SkuCode { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the item
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}
