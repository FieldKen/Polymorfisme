using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenten
{
    class Student : Mens
    {
        public override bool Equals(object obj)
        {
            Student temp = obj as Student;
            if (temp != null)
            {
                return (Leeftijd == temp.Leeftijd && Naam == temp.Naam);
            }

            return base.Equals(obj);




            /*if (obj is Student)
            {
                Student temp = (Student)obj;
                return (Leeftijd == temp.Leeftijd && Naam == temp.Naam);
            }
            return false;*/
        }
    }
}
