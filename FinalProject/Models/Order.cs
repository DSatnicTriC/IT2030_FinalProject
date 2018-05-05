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
        public Guid Id { get; set; }

        [Required]
        public int NumberOfTickets { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        [Required]
        public int FkEventId { get; set; }
        [Required]
        public Guid FkUserWhoPlacedOrderId { get; set; }
        public Event Event { get; set; }
        public User UserWhoPlacedOrder { get; set; }
    }
}