using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteContact
{
    class AddBook
    {
        static void Main(string[] args)
        {
            DeleteContact.AddrBook.GetCustomer();
            DeleteContact.AddrBook.Modify();
            DeleteContact.AddrBook.ListingPeople();
            DeleteContact.AddrBook.RemovePeople();

        }
    }
}