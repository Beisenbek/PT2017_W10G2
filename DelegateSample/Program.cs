using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    delegate void PrintDelegate();


    class SuperClass
    {
        public void PrintOK()
        {
            Console.WriteLine("ok");
        }
    }

    class SuperClass2
    {
        public void PrintOK()
        {
            Console.WriteLine("ok2");
        }
    }

    class SuperClass3
    {
        public void PrintOK()
        {
            Console.WriteLine("ok3");
        }
    }


    class SimpleClass
    {
        public PrintDelegate pd;
        public void PrintOK()
        {
            pd.Invoke();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperClass c = new SuperClass();
            SuperClass2 c2 = new SuperClass2();
            SuperClass3 c3 = new SuperClass3();
            SimpleClass s = new SimpleClass();
            s.pd = c3.PrintOK;
            s.PrintOK();
        }
    }
}
