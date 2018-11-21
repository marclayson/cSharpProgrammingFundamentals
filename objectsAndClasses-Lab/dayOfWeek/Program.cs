using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string DateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(DateAsText,
                "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
