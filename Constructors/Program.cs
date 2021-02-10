using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Diyarbakır"};

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
        }
    }

    class Customer
    {
        //Dafault constructor- parametresi olmayan constructorlara denir. () gibi,Özellik barındırran class türü bu, diğeri ekleme silme yapan class
        public Customer() // customer1 de bu çalıştı
        {
                
        }
        public Customer(int id, string firstName, string lastName, string city) // customer2 de bu çalıştı
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Id = id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
