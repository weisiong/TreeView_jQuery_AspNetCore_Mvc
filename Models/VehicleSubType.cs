using System.ComponentModel.DataAnnotations.Schema;

namespace TreeView_jQuery_AspNetCore_Mvc.Models
{
    public class VehicleSubType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int VehicleTypeId { get; set; }
        [ForeignKey(nameof(VehicleTypeId))]
        public virtual VehicleType VehicleType { get; set; }
    }
}
