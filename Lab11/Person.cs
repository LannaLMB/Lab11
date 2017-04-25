using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {

        // Declare Variables
        private string Name;
        private string Address;


        #region Properties

        // Property - Person Name
        public string PName
        {
            set
            {
                Name = value;
            }

            get
            {
                return Name;
            }
        }


        // Property - Person Address
        public string PAddress
        {
            set
            {
                Address = value;
            }

            get
            {
                return Address;
            }
        }

        #endregion


        // Constructor
        public Person(string NameInput, string AddressInput)
        {

            Name = NameInput;
            Address = AddressInput;
        }


        // Default Values
        public Person()
        {
            Name = "Lanna Brasure";
            Address = "1570 Woodward Ave.  Detroit, MI 48226";
        }


        public override string ToString()
        {
            return Name + " " + Address;
        }
    }
}
