using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseUser
    {
        public string PhoneNumber { get; set; }
        public string ProfessionCategoryId { get; set; }
        public string ProfessionTitle { get; set; }
        public string ProfessionDescription { get; set; }
        public bool isAdmin { get; set; } = false;

        public virtual List<JobListing> JobListings { get; set; }





    }
}
