using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers.Demo;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            #region Public - class, all class members
            //Car car = new Car("BMW", "E60", 20000);
            //car.Test();
            //car.Model = "X6";
            #endregion
            #region Private - all class members(field,property,method)
            //Car car = new Car("BMW", "E60", 20000);
            //car.SetSpeed(300);
            //Console.WriteLine(car.GetSpeed());
            //car.Speed = -50;
            //Console.WriteLine(car.Speed);
            #endregion
            #region protected - all class members
            //Car car = new Car("BMW", "E60", 20000);
            //car.horsePower = 10;
            #endregion

            #region Private readonly - field
            //Car car = new Car("BMW", "E60", 20000,"black");
            //car._color = "";
            #endregion
            #region Public readonly - field
            //Car car = new Car("BMW", "E60", 20000, "black");
            //Console.WriteLine(car.Engine);
            #endregion

            #endregion

            #region Namespace
            //AccessModifiers.Demo.Car car1 = new AccessModifiers.Demo.Car();
            //Car car = new Car();
            #endregion
        }
    }
}
