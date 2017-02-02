using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Teacher : Person
    {
        //properties
        public string Room { get; set; }

        //constructors
        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, string room)
            : base (firstName,lastName)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            //base tässä tapauksessa person luokka
            // eli kutsutaan Person luokan ToString() metodia
            // return FirstName + " " +...+ Room;
            return base.ToString() + " " + Room;
        }
    }
}
