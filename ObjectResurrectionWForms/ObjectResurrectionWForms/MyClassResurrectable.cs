using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectResurrectionWForms
{
    class MyClassResurrectable
    {
        //private MyClassResurrectable ref1 = null;

        ~MyClassResurrectable()
        {
            GC.ReRegisterForFinalize(this);
            //ref1 = this;
            MessageBox.Show("finilizer");
        }
    }
}
