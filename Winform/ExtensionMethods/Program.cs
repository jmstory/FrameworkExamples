using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ExtensionMethodsDemo1;
using Extensions;
using EnumExtension;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints= {10,45,15,39,21,26};
            var result = ints.OrderBy(g=>g);
            foreach( var i  in result)
            {
                System.Console.Write(i + " ");
            }

            System.Console.WriteLine();
            string s = "Hello Extension Methods";
            int t = s.WordCount();
            System.Console.WriteLine("Word count of s is {0}", t);
            
            A a = new A();
            B b = new B();
            C c = new C();

            a.MethodA(1);           
            a.MethodA("hello");

            a.MethodB();

            b.MethodA(1);
            b.MethodB();

            b.MethodA("hello");

            c.MethodA(1);
            c.MethodA("hello");
            c.MethodB();

            System.Console.WriteLine("EnumExtension");
            Grades g1 = Grades.D;
            Grades g2 = Grades.F;
            Console.WriteLine("First {0} a passing grade.", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade.", g2.Passing() ? "is" : "is not");

            Extensions2.minPassing = Grades.C;
            Console.WriteLine("\r\nRaising the bar!\r\n");
            Console.WriteLine("First {0} a passing grade.", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade.", g2.Passing() ? "is" : "is not");
        }
       
    }

    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] {' ' , '.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
namespace DefineIMyInterface
{
    public interface IMyInterface
    {      
        void MethodB();
    }
}
namespace Extensions
{  
    using DefineIMyInterface;

    public static class Extension
    {
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, string s)");
        }
       
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Extension.MethodB(this IMyInterface myInterface)");
        }
    }
}
namespace ExtensionMethodsDemo1
{
    using Extensions;
    using DefineIMyInterface;
    
    class A : IMyInterface
    {
        public void MethodB(){Console.WriteLine("A.MethodB()");}
    }
    class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }   
}
namespace EnumExtension
{
    public static class Extensions2{
        public static Grades minPassing = Grades.D;
        public static bool Passing(this Grades grade)
        {
            return grade >= minPassing;
        }
    }
    public enum Grades { F = 0, D=1, C=2, B=3, A=4 };
}