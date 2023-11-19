

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleDay2
{
    /*
     * multi line comment
     we can wrie more than one line comment

    for create comment ctrl+k+c
    for uncomment ctrl+k+u

    we use \n for make enter and start another line
    we use \t for make space 

     */
    class Program
    {
        static void Main()
        {
            /* Console.WriteLine("my name is sara alzadjali \n" +
                 "\t i am a trainee at code academy in full stack development");

             string FirstName = "sara alzadjali", courseName = "full stack development";


             //value Datatypes
             int age; // variable decleration just once not more so we can not write again int age = 25


             age = 23; // assign to the variable , i can re-assign to the variable more than once
             Console.WriteLine("FirstName : " + FirstName + "\n my age is : " + age);
             Console.WriteLine(age);
             age = 24;
             Console.WriteLine(age);


             long ssn = 12234465676788789;
             //decimal 

             double payment = 55.3;
             float money = 3.45f;
             decimal salary = 4.5m;

             Console.WriteLine(ssn);*/







            int x = int.MaxValue;
            int y = int.MaxValue;

            int z1 = x + y;  // throws OverflowException in checked context
            int z2 = unchecked(x + y);  // does not throw an exception








        }
    }
}