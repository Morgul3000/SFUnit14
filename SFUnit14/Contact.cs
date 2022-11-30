using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUnit14
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long Phone { get; set; }
        public string EMail { get; set; }
        public Contact(string name, string surname, long phone, string eMail)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            EMail = eMail;
        }

    }
}
