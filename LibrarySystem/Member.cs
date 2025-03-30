using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public Member(int memberId, string memberName)
        {
            MemberId = memberId;
            MemberName = memberName;
        }
    }
}
