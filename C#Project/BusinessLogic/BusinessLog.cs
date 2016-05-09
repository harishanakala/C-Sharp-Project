using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess; // for acessing DataAccess class
using BusinessObject; // for acessing bussiness object class

namespace Businesslogic
{
    public class BusinessLog
    { 
    
        public int SaveStudentregisrationBL(BusinessObj objBusinessLog) // passing Bussiness object Here
        {
            try
            {
                DataObj objdataobj = new DataObj(); // Creating object of DataAccess

                return objdataobj.AddUserDetails(objBusinessLog); // calling Method of DataAccess

            }
            catch
            {
                throw;
            }
        }

    }
}