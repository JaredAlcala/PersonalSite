using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    [Keyless]
    public class ContactViewModel
    {
        //We can use Data Annotations to add validation to our model.
        //This is useful when we have required info, or need certain types of info.
        [Required(ErrorMessage = "* Name is Required")] //* Field is required
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "* Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required(ErrorMessage = "* Message is Required")]
        [DataType(DataType.MultilineText)] // makes a "textarea" for this field.
        public string Message { get; set; } = null!;
    }
}
