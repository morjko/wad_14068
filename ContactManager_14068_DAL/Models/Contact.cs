using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager_14068_DAL.Models
{
    public class Contact
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Name of the contact is required!")]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string? Email { get; set; }

        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group? Group { get; set; }
    }
}
