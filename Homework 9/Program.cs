using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Homework_9
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        int _age;

        public Human(string firstName, string lastName, int Age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = Age;
        }

        public abstract void Think();

        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\n{_age} лет";
        }

    }

    abstract class All : Human
    {
        string _faculty;

        public All(string firstName, string lastName, int Age, string Faculty) : base(firstName, lastName, Age)
        {
            _faculty = Faculty;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nФакультет: {_faculty}\n";
        }

    }

    class Learner : All
    {
        string _qualification;

        public Learner(string firstName, string lastName, int Age, string Faculty, string Qualification) : base(firstName, lastName, Age, Faculty)
        {
            _qualification = Qualification;
        }

  

        public override void Think()
        {
            WriteLine($"Я преподаватель и реподаю свой предмет\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"Преподаю {_qualification}";
        }
    }

    class Student : All
    {
        string _nameGroup;

        public Student(string firstName, string lastName, int Age, string Faculty, string NameGroup) : base(firstName, lastName, Age, Faculty)
        {
            _nameGroup = NameGroup;
        }


        public override void Think()
        {
            WriteLine("Учусь в Хогвардсе\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"Я учусь в группе {_nameGroup}";
        }
    }

    class Evil : Human
    {
        string _rank;

        public Evil(string firstName, string lastName, int Age, string Rank) : base(firstName, lastName, Age)
        {
            _rank = Rank;
        }

        public override void Think()
        {
            WriteLine("Я бывший ученик хогвардса, жаждущий власти\n");
        }

        public override string ToString()
        {
            return base.ToString() + "\nЯ собираюсь захватить школу Хоггвардс";
        }

        
    }

    class Beasts
    {
        string _name;
        string _class;

        public Beasts(string Name, string Class)
        {
            _name = Name;
            _class = Class;
        }

        public void Think()
        {
            WriteLine("Это существо");
        }

        public override string ToString()
        {
            return $"Это {_name} раса {_class}";
        }
    }
    internal class Poly
    {
        static void Main(string[] args)
        {
            Human[] humans =
            {
                new Student("Harry", "Potter", 14, "Griffendor", "25"),

                new Learner("Severus", "Snape", 35,"Sliserin", "Potions and Defense Against the Dark Arts Instructor"),

                new Evil("Tom", "Reddle", 70, "Leader"),

                

            };

            Beasts[] Beast =
            {
               new Beasts("Wengrian Ostoroga", "Dragon")

            };

            foreach (Human item in humans)
            {
                WriteLine(item);
                item.Think();
                item.ToString();
            }

            foreach (Beasts item in Beast)
            {
                WriteLine(item);
                item.Think();
                item.ToString();
            }
        }
    }
}
