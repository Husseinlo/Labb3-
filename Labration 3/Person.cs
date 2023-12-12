 using System;
 
namespace Labration_3
{
    public class Person
    {

       
        
        public  Gender gender { get; set; }

        public Hair hår { get; set; }
         
        public string Eyecolor { get; set; }
        
        public DateTime Birthday { get; set; } 
        
        public Person (DateTime birthday, string eyecolor, Gender genDer, Hair hair)
        {             
            gender = genDer;
            Eyecolor = eyecolor;
            Birthday = birthday;
            hår = hair;

        }
        public override string ToString()
            {
                return $"Kön:{gender}\n" + 
                $"ÖgonFärg: {Eyecolor} \n" + 
                $"Hår: {hår.Färg} + {hår.Längd} \n" +
                $"Födelsedag: {Birthday:yyyy/MM/dd}";
            }
        




    }
}
