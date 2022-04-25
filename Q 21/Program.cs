using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckNumber a = new CheckNumber();

            a.ev_Number += new CheckNumber.dg_Number(EventMessage);
            a.Add();
            Console.Read();
        }
        static void EventMessage()
        {
            Console.WriteLine("******** Its more than 10 **********");
        }
    }

    class CheckNumber
    {
        public delegate void dg_Number();
        
        public event dg_Number ev_Number; 

        public void Add()
        {
            int theNumber = 15;
            Console.WriteLine(theNumber.ToString());

            //Check if seconed Number is >= number then raise event
            if ((theNumber >= 10) && (ev_Number != null))
            {
                ev_Number(); 
            }
        }
    }
}