using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EF_DbLibrary
{
    public class ImprovementPlan
    {
        [Key]
        [ForeignKey("Employee")]

        public int BusinessEntityID { get; set;}
        public virtual Employee? Employee { get; set; }

        [Required]
        public DateTime PlanStart { get; set; } 
        public DateTime PlanEnd { get; set; }
        
        
    }
}
