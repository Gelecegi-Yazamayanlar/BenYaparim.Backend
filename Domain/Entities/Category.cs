using Core.DataAccess;
using Domain.Entities;

namespace Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<SubCategory> SubCategories { get; set; }
    }
}


