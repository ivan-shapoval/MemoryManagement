using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectResurrection
{
    class Program
    {
        static void Main(string[] args)
        {

          var bla =  new MyObjectWithFinalizer();
            bla = null;

            GC.Collect();
      //      MyObjectWithFinalizer myObj2 = MyObjectWithFinalizer.myRefLong.Target as MyObjectWithFinalizer;

            Console.WriteLine("myObj2 == {0}",
                            MyObjectWithFinalizer.ref1 == null ? "null" : "non-null");


            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("myObj2 == {0}",
                            MyObjectWithFinalizer.ref1 == null ? "null" : "non-null");


            Console.ReadLine();
        }


    }
}
