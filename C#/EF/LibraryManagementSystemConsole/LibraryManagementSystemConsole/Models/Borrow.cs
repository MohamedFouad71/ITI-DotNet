using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemConsole.Models
{
    public class Borrow
    {
        [Key]
        public int BorrowId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int MemberId { get; set; }

        public Book Book { get; set; } 

        public Member Member { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }


        public override string ToString()
        {
            string returnDateString = ReturnDate.HasValue ? ReturnDate.Value.ToShortDateString() : "Not Returned";
            return $"Borrow(BorrowID={BorrowId}, BookID={BookId}, MemberID={MemberId}, BorrowDate={BorrowDate.ToShortDateString()}, ReturnDate={returnDateString})";
        }


    }


}

/*
 * - int BorrowId
- int BookId (Foreign Key)
- int MemberId (Foreign Key)
- DateTime BorrowDate
- DateTime? ReturnDate
*/