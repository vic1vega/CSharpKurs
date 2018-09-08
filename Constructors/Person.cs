using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string address;
        int age;
        string sex;

        //konstruktor zawierający wartości domyślne pól
        public Person()
        {
            id = 1;
            firstName = "Jan";
            lastName = "Kowalski";
            age = 54;
            sex = "TAK";
        }

        //konstruktor zawierający parametry, którymi zostaną zainicjalizowane pola klasy
        public Person(int id, string firstName, string lastName, string address, int age, string sex)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.sex = sex;  
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = "Katowice";
        }

    }
}
