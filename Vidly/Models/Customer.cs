using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display( Name = "Date of Birth" )]
        public byte MembershipTypeId { get; set; }

    }
}