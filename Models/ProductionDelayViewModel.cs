using System;
using System.Collections.Generic;

namespace ProductionDelayLoggingSystem.Models
{
    public class ProductionDelayViewModel
    {
        public string SelectedShift { get; set; }
        public DateTime SelectedDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<DelayEntry> Delays { get; set; } = new List<DelayEntry>();

        public DelayEntry SelectedDelay { get; set; } = new DelayEntry();

        public string SelectedAgency { get; set; }
        public string ReasonDescription { get; set; }
    }
}
