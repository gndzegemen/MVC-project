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
        public int ActiveWorkingTimePercentage{get; set;}
        public int IdleStandbyTimePercentage { get; set; }

        public void CalculateIdleStandbyTime()
        {
            // 7 gün * 24 saat = 168 saat
            const double totalHoursInWeek = 168;

            IdleStandbyTime = totalHoursInWeek - (MaintenanceTime + ActiveWorkingTime);
        }

        public void CalculateActiveWorkingTimePercentage()
        {
            const double totalHoursInWeek = 168;

            
            double percentage = (ActiveWorkingTime / totalHoursInWeek) * 100;

            ActiveWorkingTimePercentage = (int)Math.Round(percentage, 0);
        }

        public void CalculateIdleStandbyTimePercentage()
        {
            const double totalHoursInWeek = 168;

            double percentage = (IdleStandbyTime / totalHoursInWeek) * 100;

            IdleStandbyTimePercentage = (int)Math.Round(percentage, 0);
        }

    }
}
