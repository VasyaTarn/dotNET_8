using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_8
{
    class Address
    {
        private string street;
        private int house;
        private int apartment;
        private string city;

        public Address()
            : this("", 0, 0, "")
        {}


        public Address(string street, int house, int apartment, string city)
        {
            this.street = street;
            this.house = house;
            this.apartment = apartment;
            this.city = city;
        }

        public void printAddressInfo()
        {
            Console.WriteLine($"Street:{street}");
            Console.WriteLine($"House:{house}");
            Console.WriteLine($"Apartment:{apartment}");
            Console.WriteLine($"City:{city}");
        }
    }

    class Student
    {
        private string lastName;
        private string name;
        private string surname;
        private Address address;
        private string phoneN;

        private DateTime dateOfBirth;

        public Student()
        {
            setLName("RandomLastName");
            setName("RandomName");
            setSurname("RandomSurname");
            dateOfBirth = new DateTime(2000, 1, 1);
            address = new Address("RandStreet", 1, 1, "RandCity");
            phoneN = "+380777777777";
        }

        public Student(string lName, string name, string surname, string steet, int house, int apart, string city, string phone)
        {
            setLName("RandomLastName");
            setName("RandomName");
            setSurname("RandomSurname");
            dateOfBirth = new DateTime(2000, 1, 1);
            address = new Address("RandStreet", 1, 1, "RandCity");
            phoneN = "+380777777777";
        }

        public void setLName(string lName)
        {
            this.lastName = lName;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setDateOfBirth(int day, int month, int year)
        {
            dateOfBirth = new DateTime(year, month, day);
        }

        public void setAddress(string steet, int house, int apart, string city)
        {
            address = new Address(steet, house, apart, city);
        }

        public void serPhoneNumber(string phoneN)
        {
            this.phoneN = phoneN;
        }

        public string getLName()
        {
            return lastName;
        }

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getDateOfBirth()
        {
            return dateOfBirth.ToShortDateString();
        }

        public void getAddress()
        {
            address.printAddressInfo();
        }

        public string getPhoneN()
        {
            return phoneN;
        }

        public void printStudentInfo()
        {
            Console.WriteLine($"Last name:{getLName()}");
            Console.WriteLine($"Name:{getName()}");
            Console.WriteLine($"Surname:{getSurname()}");
            Console.WriteLine($"Last name:{getLName()}");
            Console.WriteLine($"Date of birth:{getDateOfBirth()}");
            getAddress();
            Console.WriteLine($"Phone number:{getPhoneN()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();

            stud.printStudentInfo();

            stud.setName("Bob");
            stud.setDateOfBirth(4, 5, 2020);

            Console.WriteLine();

            stud.printStudentInfo();
        }
    }
}
