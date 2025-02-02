using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int PublishedYear { get; set; }
            public bool IsAvailable { get; set; } = true;
        }

        public class Member
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime MembershipDate { get; set; } = DateTime.Now;
        }

        public class Lease
        {
            public int Id { get; set; }
            public int BookId { get; set; }
            public int MemberId { get; set; }
            public DateTime LeaseDate { get; set; } = DateTime.Now;
            public DateTime? ReturnDate { get; set; }
        }


        static void Main(string[] args)
        {
        }
    }
}
