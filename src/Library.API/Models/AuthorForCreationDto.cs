using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Models
{
    /// <summary>
    /// An author First Name, Last Name, Date of birth, Genre, Books fields
    /// </summary>
    public class AuthorForCreationDto
    {
        /// <summary>
        /// The first name for the author
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name for the author
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        /// <summary>
        /// The date of birth for the author
        /// </summary>
        public DateTimeOffset DateOfBirth { get; set; }

        /// <summary>
        /// The genre for the author
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// The list of books for the author
        /// </summary>
        public ICollection<BookForCreationDto> Books { get; set; } = new List<BookForCreationDto>();
    }
}
