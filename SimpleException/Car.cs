using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        //field variable
        public const int MaxSpeed = 50;
        private bool CarIsDead;//is the car dead
        // properties
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        //constructors
        public Car()
        {

        }
        public Car(string name,int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        // this Car has a Radio(containment/delegation-inheritance)
      private  Radio carRadio = new Radio();

       //methods
       public void CrankTunes(bool state)
        {
            //delegate request to  inner object
            carRadio.RadioOn(state);
        }
        //see if the car is overheated
        public void Accelerate(int delta)
        {
            if (CarIsDead)
            {
                Console.WriteLine("{0} is out of order..", PetName);

            }
            else
            {
                CurrSpeed += delta;
                if(CurrSpeed>=MaxSpeed)
                {
                    CurrSpeed = 0;
                    CarIsDead = true;

                    // we need to call the help link property, thus
                    //we need to create local variable before trowin
                    //the exception
                    Exception ex=
                     new Exception($"{PetName} has overheated");
                    ex.HelpLink = "http://www.CarRUs.com";

                    //stuff in custom data regarding the error
                    ex.Data.Add("Time Stamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You had a lead foot");

                    throw ex;

                }
                else
                {
                    Console.WriteLine("=> current speed is:{0}", CurrSpeed);

                }
            }
        }
    }
}
