using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.models
{
    public class GradesModel
    {
        [Range(0, 100)]
        public double asgn { get; set; }
        
        public double gp { get; set; }
        
        public double qz { get; set; }
        
        public double ex { get; set; }
        
        public double intex { get; set; }


    }
}
