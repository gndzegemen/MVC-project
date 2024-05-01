using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_Model.Models
{
    public class Vehicle
    {

        public int VehicleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LicensePlate { get; set; }
        public double ActiveWorkingTime { get; set; }
        public double MaintenanceTime { get; set; }
        public double IdleStandbyTime { get; set; }
    }
}
