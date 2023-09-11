using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Pro_10
{
    abstract class Document
    {
        public void Print()
        {
            Console.WriteLine("Opening");
            DoPrint();
            Console.WriteLine("Closing");
        }

        protected abstract void DoPrint();
    }
}
