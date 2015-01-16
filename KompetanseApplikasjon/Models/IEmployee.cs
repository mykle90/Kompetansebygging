using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompetanseApplikasjon.Models
{
    [ContractClass(typeof(IEmployeeContract))]
    interface IEmployee
    {
        String Name { get; set; }
        int Age { get; set; }
        

    }

    [ContractClassFor(typeof (IEmployee))]
    internal abstract class IEmployeeContract : IEmployee
    {
        public string Name { get; set; }
        public int Age {
            get
            {
                return default(int);
            }
            set
            {
                Contract.Requires(value > -30, "BOGOS AGE");
            } 
        }
    }
}
