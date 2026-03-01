using System.Numerics;
using System.Text;
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
    }
    }
}
