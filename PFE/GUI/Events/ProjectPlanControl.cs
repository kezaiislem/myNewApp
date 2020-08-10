using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using PFE.Model;
using PFE.model;
using PFE.CustomObjects;
using PFE.ViewModel;

namespace PFE.UserContol
{
    public partial class ProjectPlanControl : UserControl
    {

        ProjectPlanControlViewModel viewModel;

        public ProjectPlanControl(List<ProjectEvent> projectEvents)
        {
            InitializeComponent();
            Init(projectEvents);
        }

        private void Init(List<ProjectEvent> projectEvents)
        {
            viewModel = new ProjectPlanControlViewModel(projectEvents);
            calendar1.PropertyChanged += CalendarChanged;
            foreach (CalendarItem calendarItem in viewModel.calendarItems)
            {
                calendar1.AddEvent(calendarItem.customEvent);
            }
        }

        private void CalendarChanged(object o, PropertyChangedEventArgs e)
        {
            this.viewModel.reloadEvents(calendar1.LoadEvents());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEventForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                ProjectEvent pe = new ProjectEvent { name = form.text, startDate = form.startDate, endDate = form.endDate, color = ColorTranslator.ToHtml(form.eventColor) };
                CalendarItem calendarItem = new CalendarItem(pe);
                calendar1.AddEvent(calendarItem.customEvent);
            }
        }
    }
}
