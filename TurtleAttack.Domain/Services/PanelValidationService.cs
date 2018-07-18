using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleAttack.Domain.Entities;

namespace TurtleAttack.Domain.Services
{
    public class PanelValidationService
    {
        private static PanelValidationService _instance;
        public static PanelValidationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelValidationService();
                return _instance;
            }
        }

        private PanelValidationService()
        {

        }

        public bool IsValidPanel(Panel panel)
        {
            if (panel == null || string.IsNullOrEmpty(panel.MacId) || string.IsNullOrEmpty(panel.Version)) return false;
            
            if(panel.IsSurveillanceSupported)
            {
                if (panel.StorageCapacity < 1024 * 1024 * 1024 * 8L)
                    return false;
            }
            
            switch(panel.Processor)
            {
                case ProcessorType.Intel:
                case ProcessorType.Samsung:
                    break;
                case ProcessorType.Arm:
                    if (panel.Sensors.Any(s => s.Category == SensorCategory.Fire))
                        return false;
                    break;
                case ProcessorType.Infineon:
                    if (panel.Sensors.Any(s => s.Category == SensorCategory.Humidity || s.Category == SensorCategory.Intrusion))
                        return false;
                    break;
                case ProcessorType.Zilog:
                    if (panel.Sensors.Any(s => s.Category == SensorCategory.Temperature))
                        return false;
                    break;
            }

            return true;
        }
    }
}
