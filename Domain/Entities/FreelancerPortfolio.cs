using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FreelancerPortfolio : Entity
    {
        public int FreelancerId { get; set; }
        public int SubCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        public virtual Freelancer Freelancer { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public virtual List<PortfolioImage> PortfolioImages { get; set; }

    }
}
