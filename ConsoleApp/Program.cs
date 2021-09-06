using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Group0202 s1 = new Group0202() 
            { 
                FirstName = "Ibrohim", 
                LastName = "Mallaev", 
                MiddleName = "Mirzoevich", 
                YearOfBirth = 2000, 
                CityOfBirth = "Farkhor" 
            };
            Group0202 s2 = new Group0202()
            {
                FirstName = "Olim",
                LastName = "Ashuraliev",
                MiddleName = "Mahmadovich",
                YearOfBirth = 2000,
                CityOfBirth = "Regar"
            };
            Group0202 s3 = new Group0202()
            {
                FirstName = "A'zam",
                LastName = "Ashurov",
                MiddleName = "Ne'matovich",
                YearOfBirth = 1999,
                CityOfBirth = "Dushanbe"
            };
            Group0202 s4 = new Group0202()
            {
                FirstName = "Said",
                LastName = "Musofirov",
                MiddleName = "Saidvalievich",
                YearOfBirth = 2000,
                CityOfBirth = "Darvoz"
            };
            Group0202 s5 = new Group0202()
            {
                FirstName = "Azizjon",
                LastName = "Hojimurodov",
                MiddleName = "Begmurodovich",
                YearOfBirth = 2001,
                CityOfBirth = "Zafarobod"
            };
            Group0202 s6 = new Group0202()
            {
                FirstName = "Khudobakhsh",
                LastName = "Sheykhov",
                MiddleName = "Shekhovich",
                YearOfBirth = 2000,
                CityOfBirth = "Darvoz"
            };

            s1.GetInfo();
            s2.GetInfo();
            s3.GetInfo();
            s4.GetInfo();
            s5.GetInfo();
            s6.GetInfo();
        }
    }


    class Group0202
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int YearOfBirth { get; set; }
        public string CityOfBirth { get; set; }
        public Group0202() { }

        public void GetInfo()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nMiddle name: {MiddleName}\nYear of birth: {YearOfBirth}\nCity of birth: {CityOfBirth}");
            Console.WriteLine();
        }

    }
}
