using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [Required]
        public virtual string Title { get; set; }

        [Required]
        public virtual string Description { get; set; }

        [Required]
        public virtual DateTime StartDateTime { get; set; }

        [Required]
        public virtual DateTime EndDateTime { get; set; }

        [Required]
        public virtual string Location { get; set; }

        [Required]
        [Display(Name = "Organizer")]
        public virtual Guid FkOrganizerId { get; set; }
        [Required]
        [Display(Name = "Event Type")]
        public virtual int FkEventTypeId { get; set; }
        public virtual User Organizer { get; set; }
        public virtual EventType EventType { get; set; }
    }
}