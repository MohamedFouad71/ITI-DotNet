using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }

        public DateTime MembershipDate { get; set; }



        public Member()
        {
            //
        }

        public Member(int memberId, string name, DateTime membershipDate)
        {
            MemberId = memberId;
            Name = name;
            MembershipDate = membershipDate;
        }



        public override string ToString()
        {
            return $"Member(MemberId={MemberId}, Name='{Name}', MembershipDate={MembershipDate.ToShortDateString()})";
        }
    }
}
