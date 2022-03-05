using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditContact
{
    class AddBook
    {
        static void Main(string[] args)
        {
            EditContact.AddrBook.GetCustomer();
            EditContact.AddrBook.Modify();
            EditContact.AddrBook.ListingPeople();
            // Sample.AddrBook.RemovePeople();

        }
    }
}