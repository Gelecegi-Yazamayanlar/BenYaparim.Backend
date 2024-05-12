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
        public int JobId { get; set; }
        public int FreelancerId { get; set; }
        public ApplicationStatus Status { get; set; }

        //TODO: Burdan devam edilecek...

    }
}


public enum ApplicationStatus
{
    Deal = 0,
    MoneyInPool = 1,
    Completed = 2,

}
