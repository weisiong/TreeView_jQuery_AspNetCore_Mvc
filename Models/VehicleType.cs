using System.Collections.Generic;

namespace TreeView_jQuery_AspNetCore_Mvc.Models
{
    public class VehicleType
    {
        public VehicleType()
        {
            this.VehicleSubTypes = new HashSet<VehicleSubType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VehicleSubType> VehicleSubTypes { get; set; }
    }
}
