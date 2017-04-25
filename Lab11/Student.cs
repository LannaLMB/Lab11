using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student : Person  // Inherits Person Class
    {

        // Declare Variables
        private string Program;
        private int Year;
        private double fee;


        #region Properties

        // Property - Student Program
        public string SProgram
        {
            set
            {
                Program = value;
            }

            get
            {
                return Program;
            }
        }


        // Property - Student year
        public int SYear
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }


        // Property - Student Fee
        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        #endregion


        // Constructor
        public Student(string ProgramInput, int YearInput, double FeeInput)
        {

            Program = ProgramInput;
            Year = YearInput;
            Fee = FeeInput;
        }


        // Default Values
        public Student()
        {
            Program = ".Net/C#";
            Year = 2017;
            Fee = 8500.00;
        }


        // Method
        public override string ToString()
        {
            return PName + " " + PAddress + " " + Program + " " + Year + " " + Fee;
        }
    }
}
