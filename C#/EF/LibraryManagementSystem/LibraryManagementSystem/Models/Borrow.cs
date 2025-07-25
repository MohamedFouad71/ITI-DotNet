using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Borrow
    {
        [Key]
        public int BorrowID { get; set; }

        [ForeignKey(nameof(Book))]
        public int BookID { get; set; }

        [ForeignKey(nameof(Member))]
        public int MemberID { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }


        public override string ToString()
        {
            string returnDateString = ReturnDate.HasValue ? ReturnDate.Value.ToShortDateString() : "Not Returned";
            return $"Borrow(BorrowID={BorrowID}, BookID={BookID}, MemberID={MemberID}, BorrowDate={BorrowDate.ToShortDateString()}, ReturnDate={returnDateString})";
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