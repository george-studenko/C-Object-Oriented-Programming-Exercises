using _70_483.ClassesAndObjects;
using _70_483.Delegates;
using _70_483.Inheritance;
using _70_483.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70_483
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.FirstName = "George";
            e1.LastName = "Studenko";
            e1.Seniority = 5;

            string promote = e1.Promote();
            MessageBox.Show(promote);
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            Adult a1 = new Adult();

            MessageBox.Show("Adult 1 has been billed " + a1.Bill(2233123213555));

            Child c1 = new Child();
            MessageBox.Show("Child 1 " + c1.Inoculate());

            UnderFive uf = new UnderFive();
            MessageBox.Show("Child Under 5 years old " + uf.UnderFiveSpecialMethod());
        }

        private void testStructsButton_Click(object sender, EventArgs e)
        {
            // Structs will keep their value each as they are threated as Value Types
            MyStruct st1 = new MyStruct();
            st1.Number = 1;
            Debug.WriteLine("st1=" + st1.Number);
            MyStruct st2 = st1;
            Debug.WriteLine("st2=" + st2.Number);
            st2.Number = 2;
            Debug.WriteLine("st1=" + st1.Number);
            Debug.WriteLine("st2=" + st2.Number);

            // However Classes will actually change the value from the cloned instance as they are threated as Reference Types
            MyClass cl1 = new MyClass();
            cl1.Number = 1;

            Debug.WriteLine("cl1=" + cl1.Number);
            MyClass cl2 = cl1;
            Debug.WriteLine("cl2=" + cl2.Number);
            cl2.Number = 2;
            Debug.WriteLine("cl1=" + cl1.Number);
            Debug.WriteLine("cl2=" + cl2.Number);

            /* this will print
             * 
                st1=1
                st2=1
                // After changing st2 to value = 2 st1 will still keep its value of 1 as they are kept indiviually in the stack
                st1=1
                st2=2

                cl1=1
                cl2=1
                // when changing cl2 to value =2 cl1 will also change to 2 as they are both referencing to the same value on the heap
                cl1=2
                cl2=2                
          */
        }

        // Delegates Example
        delegate int del(int a, int b);
        private void delegatesButton_Click(object sender, EventArgs e)
        {
            DelegateExample de = new DelegateExample();
            del d= de.addNumbers;
            Debug.WriteLine("Adding the 1st delegated method");
            Debug.WriteLine(d(3, 2));

            Debug.WriteLine("Adding a 2nd delegated method");
            d += de.substractNumbers;
            Debug.WriteLine(d(3, 2));

            Debug.WriteLine("Adding a 3rd delegated method");
            d += de.mutliplyNumbers;
            Debug.WriteLine(d(3, 2));

            Debug.WriteLine("Deleting substract delegated method");
            d -= de.substractNumbers;
            Debug.WriteLine(d(3, 2));
        }

        private void TestEventHandlerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
