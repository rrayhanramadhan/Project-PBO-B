using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengumpulan_Poin_Versi_2
{
    public class OOP_Class
    {
        //Private atttributes
        private int Num1, Num2;

        //Property structure
        public int proNum11 { get => Num1; set => Num1 = value; }
        public int proNum21 { get => Num2; set => Num2 = value; } }
    //Default Constructor
        public void OOP_Class()
        {
        int Num1 = 0;
        int Num2 = 0;
        }
    //Parameterized Constructor
        public void OOP_Class(
        int Val1,
        int Val2)
        {
        int Num1 = Val1;
        int Num2 = Val2;
        }

    //Method
        public int Sum
        {
        get
        {
            object Num1;
            object Num2 = null;
            return ((int)(Num1 = Num2));
        }
    }
}

