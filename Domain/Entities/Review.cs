using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review : Entity
    {
        public int JobApplicationId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public virtual JobApplication JobApplication { get; set; }

    }
}
