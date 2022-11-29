using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperatorPOC
{
    class NullConditionalOperator
    {
     static void Main(String[] args)
       {
            Employee obj = null;
            obj = new Employee() {FirstName = "Ragini",LastName = "Singh"};
            GetEmpDetails(obj);
     }
        public static void GetEmpDetails(Employee emp)
        {
            Console.WriteLine("Employee Details are:");
            Console.WriteLine(emp?.FirstName); 
            Console.WriteLine(emp?.LastName); 
        }
    }

}
    