using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff:Person
    {

        // Declare Variables
        private string School;
        private double Pay;


        #region Properties
        
        // Property - Staff School
        public string StaffSchool
        {
            set
            {
                School = value;
            }

            get
            {
                return School;
            }      
        }


        // Property - Staff Pay
        public double StaffPay
        {
            set
            {
                Pay = value;
            }

            get
            {
                return Pay;
            }    
        }

        #endregion


        // Constructor
        public Staff (string SchoolInput, double PayInput)
        {

            School = SchoolInput;
            Pay = PayInput;
        }


        // Default Values
        public Staff()
        {
            School = "Grand Circus";
            Pay = 0.00;
        }


        // Method
        public override void toString()
        {
            Console.WriteLine(PName + " " + PAddress + " " + School + " " + Pay);
        }
    }
}
