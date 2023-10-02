using JobFinder.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobFinder.Abstract;

namespace JobFinder.Entities
{
    internal class Customer : Person<Guid>,ICsvConvertable
    {
        public string PhoneNumber { get; set; }


        public string GetValues()
        {
            return $"{Id}--{FirstName}--{LastName}--{PhoneNumber}";
        }




    }

    
}
