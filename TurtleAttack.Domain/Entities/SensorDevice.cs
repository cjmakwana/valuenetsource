using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleAttack.Domain.Entities
{
    public class SensorDevice
    {
        public string MacId { get; set; }
        public SensorCategory Category { get; set; }
        public double LowerThreshold { get; set; }
        public double UpperThreshold { get; set; }
    }
}
