using System;

namespace TurtleAttack.Domain
{
    public abstract class Panel
    {
        public string MacId { get; set; }
        public string Version { get; set; }
        public short ManufacturedBy { get; set; }
        
    }
}
