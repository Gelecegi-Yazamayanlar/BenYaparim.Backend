using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Freelancer : Entity
    {
        public string Score { get; set; }
        public string CompletedJobCount { get; set; }
        public string IBAN { get; set; }
        public double TotalEarnings { get; set; }
        public virtual List<FreelancerSkill> FreelancerSkills { get; set; }
    }
}
