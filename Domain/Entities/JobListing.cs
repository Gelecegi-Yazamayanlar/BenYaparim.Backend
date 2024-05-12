using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobListing : Entity  // The employer's job postings will be kept here.
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }

        public virtual User User { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual List<Skill> Skills { get; set; }

        public virtual List<JobApplication> JobApplications { get; set; }
    }
}
