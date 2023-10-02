using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Common
{
    internal class Person <Tkey>: EntityBase<Tkey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
