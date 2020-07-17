using Calendar.NET;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ProjectPlanControlViewModel
    {
        public List<ProjectEvent> projectEvents { get; set; }
        public List<CalendarItem> calendarItems { get; set; }

        public ProjectPlanControlViewModel(List<ProjectEvent> projectEvents)
        {
            this.projectEvents = new List<ProjectEvent>();
            calendarItems = new List<CalendarItem>();

            calendarItems.Add(new CalendarItem(new ProjectEvent { name = "Event 1", startDate = DateTime.Now, endDate = new DateTime(2020, 7, 25) }));
            calendarItems.Add(new CalendarItem(new ProjectEvent { name = "Event 2", startDate = DateTime.Now, endDate = new DateTime(2020, 7, 25) }));
            calendarItems.Add(new CalendarItem(new ProjectEvent { name = "Event 3", startDate = DateTime.Now, endDate = new DateTime(2020, 7, 25) }));
            calendarItems.Add(new CalendarItem(new ProjectEvent { name = "Event 4", startDate = DateTime.Now, endDate = new DateTime(2020, 7, 25) }));

        }

        public void reloadEvents(List<IEvent> events)
        {
            projectEvents.Clear();
            foreach (IEvent ev in events)
            {
                projectEvents.Add(new ProjectEvent { name = ev.EventText, startDate = ev.Date, endDate = ev.EndDate });
            }
        }

        /*public void editEvent(IEvent evnt)
        {
            foreach (CalendarItem calendarItem in calendarItems)
            {
                if (calendarItem.customEvent == evnt)
                {
                    projectEvents.Remove(calendarItem.Event);
                    calendarItems.Remove(calendarItem);
                    break;
                }
            }
        }*/
    }
}
