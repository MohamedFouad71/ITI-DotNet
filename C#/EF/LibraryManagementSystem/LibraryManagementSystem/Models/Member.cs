using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        public string Name { get; set; } = "Unspecified";

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
