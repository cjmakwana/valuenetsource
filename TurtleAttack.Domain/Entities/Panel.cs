using System;
using System.Collections.Generic;

namespace TurtleAttack.Domain.Entities
{
    public class Panel
    {
        public string MacId { get; set; }
        public string Version { get; set; }
        public short ManufacturedBy { get; set; }
        public bool IsSurveillanceSupported { get; set; }
        public long StorageCapacity { get; set; }
        public ProcessorType Processor { get; set; }
        public IEnumerable<SensorDevice> Sensors { get; set; }
    }
}
