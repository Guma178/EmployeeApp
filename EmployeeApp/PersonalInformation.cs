using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    struct PersonalInformation
    {
        string FIO;
        DateTime bornDate;

        public PersonalInformation(string FIO, DateTime bornDate)
        {
            this.bornDate = bornDate;
            this.FIO = FIO;
        }

        public override int GetHashCode()
        {
            return bornDate.GetHashCode() + FIO.GetHashCode();
        }

        public override string ToString()
        {
            return FIO + "родившийся " + bornDate.ToString();
        }
    }
}
