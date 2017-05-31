using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectResurrection
{
    class MyObjectWithFinalizer
    {
        //public static WeakReference myRefLong =
        //        new WeakReference(new MyObjectWithFinalizer(), true);
        public static MyObjectWithFinalizer ref1 = null;

        ~MyObjectWithFinalizer()
        {
            // var target = myRefLong.Target as MyObjectWithFinalizer;
            ref1 = this;
            
        }
    }
}
