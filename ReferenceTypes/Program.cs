using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int, decimal, float, enum, boolean value types, sadece stackde işlem döner.
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("sayi1 = " + sayi1); // cevap 20 oluyor, değer tip

            //// arrays, classes, interface are refence type, stack ve heap de adres oluşur.

            //int[] sayilar1 = new int[]{ 1, 2, 3};
            //int[] sayilar2 = new int[]{ 10, 20, 30};

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("sayilar1[0] = " + sayilar1[0]); // cevap 1000 oluyor, referans tip

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";

            Employe employe = new Employe();
            employe.FirstName = "Veli";


            Person person3 = customer;
            customer.FirstName = "Ahmet";
            customer.CreditNumber = "21584681";

            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditNumber); //boxing

            PersonManager personManager = new PersonManager();
            personManager.Add(employe); // customer, employee, person3 yazılabilir. Person customerin ve employenin adresini tutabiliyor.



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //base class : Person- 
    class Customer : Person
    {
        public string CreditNumber { get; set; }

    }

    class Employe : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

