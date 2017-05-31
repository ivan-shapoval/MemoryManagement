using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectResurrectionWForms
{
    public partial class Form1 : Form
    {

        private MyClassResurrectable ref2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bla = new MyClassResurrectable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
