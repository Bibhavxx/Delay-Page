using System;

namespace ProductionDelayLoggingSystem.Models
{
    public class DelayEntry
    {
        public string Shift { get; set; }
        public DateTime DelayStartTime { get; set; }
        public DateTime DelayStopTime { get; set; }
        public int DelayId { get; set; }
        public string ReasonCode { get; set; }
        public string OperatorId { get; set; }
        public string Remarks { get; set; }
        public int DelayDuration { get; set; }
    }
}
