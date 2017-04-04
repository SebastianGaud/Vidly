using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.DTOS
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength( 255 )]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? BirthDate { get; set; }

        //        [Min18ForMembership]
        public byte MembershipTypeId { get; set; }
    }
}