using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechJobsOOAutoGraded6
{
    public class abstract IJobField
    {
        public int Id { get; }
        public string Value { get; set; }
    }

    public string ToString()
    {
        return Value;
    }

    public override bool Equals(object? obj)
    {
        return obj is PositionType type &&
               Id == type.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}
