using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VictoriaPlumbing.Domain.Models;

namespace VictoriaPlumbing
{
    public class Order
    {

        public Order()
        {
            this.CustomerItems = new HashSet<CustomerItems>();
        }

        [Key]
        /// <summary>
        /// Gets or sets the order number of the order.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the backet code of the order.
        /// </summary>
        public string BasketCode { get; set; }

        /// <summary>
        /// Gets or sets the created date of the order.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the customer email
        /// </summary>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the customer items in the order
        /// </summary>
        public virtual ICollection<CustomerItems> CustomerItems { get; set; }

    }
}
