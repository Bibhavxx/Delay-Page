using Microsoft.AspNetCore.Mvc;
using ProductionDelayLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductionDelayLoggingSystem.Controllers
{
    public class DelayController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProductionDelayViewModel
            {
                SelectedDate = DateTime.Today,
                FromDate = DateTime.Today,
                ToDate = DateTime.Today,
                SelectedShift = "A",
                Delays = GetMockDelays()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ProductionDelayViewModel model)
        {
            model.Delays = GetMockDelays();
            return View(model);
        }

        private List<DelayEntry> GetMockDelays()
        {
            return new List<DelayEntry>
            {
                new DelayEntry
                {
                    Shift = "C",
                    DelayStartTime = new DateTime(2025, 7, 21, 22, 1, 28),
                    DelayStopTime = new DateTime(2025, 7, 22, 1, 50, 28),
                    DelayId = 2603,
                    ReasonCode = "PLN",
                    OperatorId = "E",
                    Remarks = "E",
                    DelayDuration = 230
                }
            };
        }
    }
}
