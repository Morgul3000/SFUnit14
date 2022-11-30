using System;
using System.Collections.Generic;
using System.Linq;

namespace SFUnit14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            List<Contact> sortPhoneBook = phoneBook.OrderBy(x => x.Name)
                                         .ThenBy(x => x.Surname)
                                         .ToList();

            foreach (Contact con in sortPhoneBook)
            {
                Console.WriteLine($"Имя - {con.Name}, фамилия - {con.Surname}, телефон - {con.Phone}, e-Mail - {con.EMail}");
            }

        }
    }
}
