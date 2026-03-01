using System.Numerics;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //    Static Binding(Early Binding)

            //    Happens at compile time.

            //    The method call is resolved before the program runs.

            //    Faster performance.

            //    Used with:

            //    Method Overloading

            //    Static methods

            //    Non -virtual methods
            //    class Test
            //{
            //    public void Show()
            //    {
            //        Console.WriteLine("Static Binding");
            //    }
            //}


            //    Dynamic Binding(Late Binding)

            //    Happens at run time.

            //    The method call is resolved based on the actual object type.

            //    Used in polymorphism.

            //    Requires:

            //    virtual

            //    override

            //    class Animal
            //{
            //    public virtual void Speak()
            //    {
            //        Console.WriteLine("Animal speaks");
            //    }
            //}

            //class Dog : Animal
            //{
            //    public override void Speak()
            //    {
            //        Console.WriteLine("Dog barks");
            //    }
            //}
            #endregion

            #region Q2
            //Method Overloading

            //Same method name

            //Different parameters

            //Same class

            //Compile time polymorphism
            //public void SetPrice(decimal price)
            // {
            //    }

            // public void SetPrice(decimal basePrice, decimal multiplier)
            // {
            // }
            // Method Overriding

            // Same method name

            // Same parameters

            // Different class (child class)

            // Run time polymorphism
            //     public virtual void PrintTicket()
            // {
            // }

            // public override void PrintTicket()
            // {
            // }
            #endregion

            #region Q3
            //virtual

            //Used in base class to allow overriding
            
            //public virtual void PrintTicket()
            //        {
            //        }
            //override
            
            //        Used in child class to override base method
            
            //public override void PrintTicket()
            //        {
            //        }
            //base
            
            //Used to access base class method
            
            //base.PrintTicket();
            //abstract (optional)
            
            //        Forces child classes to override
            
            //        public abstract void PrintTicket();
        #endregion
    }
    }
}
