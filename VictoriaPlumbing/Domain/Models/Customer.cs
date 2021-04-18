using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VictoriaPlumbing
{
    public class Customer
    {
        public Customer()
        {
            this.Order = new HashSet<Order>();
        }

        [Key]
        /// <summary>
        /// Gets or sets the order email of the customer
        /// </summary>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order object
        /// </summary>

        public virtual ICollection<Order> Order {get; set;}
    }
}
