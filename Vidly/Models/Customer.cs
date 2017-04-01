using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidly.Models.CustomValidation;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength( 255 )]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? BirthDate { get; set; }

        [Display( Name = "Membership Type" )]
        [ForeignKey( "MembershipTypeId" )]
        public MembershipType MembershipType { get; set; }

        [Display( Name = "Membership Type" )]
        [Min18ForMembership]
        public byte MembershipTypeId { get; set; }

    }
}