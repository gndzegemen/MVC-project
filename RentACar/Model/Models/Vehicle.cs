using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_Model.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public double ActiveWorkingTime { get; set; }
        public double MaintenanceTime { get; set; }
        public double IdleStandbyTime { get; set; }
    }
}
