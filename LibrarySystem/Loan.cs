using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Loan
    {
        public const int LoanPeriodDays = 14;
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Loan(Book book, Member user)
        {
            Book = book;
            Member = user;
            LoanDate = DateTime.Now;
        }
    }
}
