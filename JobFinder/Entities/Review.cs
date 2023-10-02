using JobFinder.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public string Text { get; set; }

        public int Rating { get; set; }
        //public int Rating {
        //    get
        //    {
        //        return Rating;
        //    }

        //    set
        //    {
        //        //if (value >= 0 || value <= 5)
        //        //{
        //        //    Rating = value;
        //        //}
        //        //throw new Exception("Rating value must be 0-5");

                

        //    }
        
        
        //} 

        public void setRating(int value)
        {
            
        }
        
    }
}
