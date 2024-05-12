using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobApplication : Entity
    {
        public int JobListingId { get; set; }
        public int FreelancerId { get; set; }
        public ApplicationStatus Status { get; set; }

        public string Note { get; set; }


        public virtual JobListing JobListing { get; set; }

        public virtual Freelancer Freelancer { get; set; }

        public virtual List<Review> Reviews { get; set; }


        //TODO: Burdan devam edilecek...

    }
}


public enum ApplicationStatus
{
    Deal = 0,
    MoneyInPool = 1,
    Completed = 2,

}
