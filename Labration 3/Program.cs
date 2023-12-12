
using System;
using System.Runtime.CompilerServices;

namespace Labration_3;


class Program
{
    static public List<Person> Personer = new List<Person>();


    static void Main()
    {

        Hair hair = new Hair { Längd = "10 cm", Färg = "Svart" };
        Gender gender = Gender.Man;
        string eyecolor = new string("Brun");
        DateTime birthday = new DateTime(1922, 12, 03);

        Person person = new Person(birthday, eyecolor, gender, hair);
        
        Console.WriteLine(person.ToString());



    }
}















