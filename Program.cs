using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = Console.ReadLine();
            student.Id = Convert.ToInt32(Console.ReadLine());
            student.MyValidation();
            Console.ReadLine();

        }
    }
}
