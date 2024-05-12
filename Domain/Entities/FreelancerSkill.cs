using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FreelancerSkill : Entity
    {
        public int SkillId { get; set; }
        public int FreelancerId { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual Freelancer Freelancer { get; set; }
    }
}
