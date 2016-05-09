using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
     public class BusinessObj 
    {
        //Declaring Student Registration Variables

        private string _Name;

        private string _Email;

        private string _Phone;

        private string _Department;

        
        
        // Get and set values

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Phone
        {

            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        public string Department
        {
            get
            {
                return _Department;
            }
            set
            {
                _Department = value;
            }
        }
    }
}