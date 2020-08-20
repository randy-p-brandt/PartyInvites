using System.ComponentModel.DataAnnotations;


namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Please enter Email address.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please indicate whether you will attend.")]
        public bool? WillAttend { get; set; }
    }
}
