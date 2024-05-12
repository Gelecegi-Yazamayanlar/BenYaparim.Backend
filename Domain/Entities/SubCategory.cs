using Core.DataAccess;

namespace Domain.Entities
{
    public class SubCategory : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<JobListing> JobListings { get; set; }


    }
}
