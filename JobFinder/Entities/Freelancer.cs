using JobFinder.Abstract;
using JobFinder.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JobFinder.Entities
{
    internal class Freelancer : Person<Guid>,ICsvConvertable
    {
        //Person extends EntityBase so we inherited from entitybase too.

        public string WorkExperience { get; set; }
        public List<Review> Review { get; set; }  //for comparison correctness we use double not float 

        public string GetValues()
        {
            return $"{Id}--{FirstName}--{LastName}--{WorkExperience}";
        }



    }
}
