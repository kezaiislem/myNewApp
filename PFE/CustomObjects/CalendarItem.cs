using Calendar.NET;
using PFE.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CustomObjects
{
    public class CalendarItem
    {
        public ProjectEvent Event { get; set; }
        public CustomEvent customEvent { get; set; }

        [CustomRecurringFunction("ProjectEvent", "Calculates which days I should be getting this event")]
        private bool EventDays(IEvent evnt, DateTime day)
        {
            if (day.Ticks >= Event.startDate.Ticks && day.Ticks <= Event.endDate.Ticks)
            {
                return true;
            }
            return false;
        }

        public CalendarItem(ProjectEvent Event)
        {
            this.Event = Event;
            this.customEvent = new CustomEvent
            {
                Date = Event.startDate,
                RecurringFrequency = RecurringFrequencies.Custom,
                EventText = this.Event.name,
                CustomRecurringFunction = EventDays,
                EndDate = Event.endDate,
                EventColor = ColorTranslator.FromHtml(Event.color)
            };
        }
    }
}
