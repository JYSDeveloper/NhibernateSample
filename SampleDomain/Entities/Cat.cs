using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDomain.Entities
{
    public class Cat
    {
        public virtual long? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual char Sex { get; set; }
        public virtual float Weight { get; set; }
    }
}
