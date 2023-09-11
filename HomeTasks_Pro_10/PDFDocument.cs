using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Pro_10
{
    internal class PDFDocument : Document
    {
        protected override void DoPrint()
        {
            Console.WriteLine("Printing PDF");
        }
    }
}
