using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> fun with Exception examples");
            //creat a car and stepping on it
            Console.WriteLine("creat a car and stepping on it");
            Car myCar = new Car("Bitto", 20);
            myCar.CrankTunes(true);
            try { 
            for(int i=0;i<10;i++)
            {
                myCar.Accelerate(10);

            }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n ***Error! **");
                Console.WriteLine("member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("member type: {0}", e.TargetSite.MemberType);


                Console.WriteLine("Method: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}",e.StackTrace);
                Console.WriteLine("HelpLink {0}",e.HelpLink);

                //custom data
                Console.WriteLine("Custom data");
                foreach(DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("{0} : {1}",de.Key,de.Value);
                }
            }//true! NullReferenceException is a SystemExcepion
            NullReferenceException nullRef = new NullReferenceException();
            Console.WriteLine("NullReferenceException is-a SystemExcepion?: {0}",
                nullRef is SystemException);

            //the error has been handed, processing contitnues with
            //the next statement
            Console.WriteLine("\n *** Out of exception Logic ***");

            Console.ReadLine();

        }
    }
}
