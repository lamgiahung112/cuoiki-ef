using CUOIKI_EF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.Helpers
{
    public class FilterKey
    {
        public FilterName Name { get; set; }
        public FilterLogicType LogicType { get; set; }
        public FilterKey(FilterName name, FilterLogicType logic)
        {
            Name = name;
            LogicType = logic;
        }
        public bool Equals(FilterKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (this.GetHashCode() != other.GetHashCode()) return false;
            System.Diagnostics.Debug.Assert(base.GetType() != typeof(object));
            if (!base.Equals(other)) return false;
            return this.Name == other.Name && this.LogicType == other.LogicType;
        }
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (this.GetType() != obj.GetType()) return false;
            return Equals((FilterKey)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name.GetHashCode(), LogicType.GetHashCode());
        }
    }
}
