using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }

        [Required]
        public virtual int NumberOfTickets { get; set; }

        [Required]
        public virtual DateTime OrderDate { get; set; }

        [Required]
        public virtual string OrderStatus { get; set; }

        [Required]
        public virtual int FkEventId { get; set; }
        [Required]
        public virtual Guid FkUserWhoPlacedOrderId { get; set; }
        public virtual Event Event { get; set; }
        public virtual User UserWhoPlacedOrder { get; set; }
    }
}