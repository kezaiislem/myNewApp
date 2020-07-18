using Calendar.NET;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.projectEvents = projectEvents;
            LoadEvents();
        }

        public void LoadEvents()
        {
            this.calendarItems = new List<CalendarItem>();
            foreach (ProjectEvent projectEvent in this.projectEvents)
            {
                calendarItems.Add(new CalendarItem(new ProjectEvent { name = projectEvent.name, startDate = projectEvent.startDate, endDate = projectEvent.endDate , color = Color.Aqua}));
            }
        }

        public void reloadEvents(List<IEvent> events)
        {
            projectEvents.Clear();
            foreach (IEvent ev in events)
            {
                projectEvents.Add(new ProjectEvent { name = ev.EventText, startDate = ev.Date, endDate = ev.EndDate , color = ev.EventColor});
            }
        }

    }
}
