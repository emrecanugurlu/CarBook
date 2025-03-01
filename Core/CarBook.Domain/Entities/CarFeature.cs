using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public bool Aveilable { get; set; }
        public Car Car { get; set; }
        public Feature Feature { get; set; }
    }
}
