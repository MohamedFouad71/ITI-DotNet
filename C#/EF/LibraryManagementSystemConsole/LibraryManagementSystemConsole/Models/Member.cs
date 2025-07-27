using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemConsole.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [StringLength(20)]
        public string? MemberName { get; set; }

        public DateTime MembershipDate { get; set; }

        /// <summary>
        /// A list of the books owned by the member
        /// </summary>
        public List<Book> Books { get; set; } = new();




        public override string ToString()
        {
            return $"Member(MemberId={MemberId}, Name='{MemberName}', MembershipDate={MembershipDate.ToShortDateString()})";
        }
    }
}
