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

        public ProjectPlanControl()
        {
            InitializeComponent();
            calendar1.PropertyChanged += CalendarChanged;

            viewModel = new ProjectPlanControlViewModel(null);

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
            ProjectEvent pe = new ProjectEvent { name = "My test event", startDate = DateTime.Now, endDate = new DateTime(2020, 7, 23) };
            CalendarItem calendarItem = new CalendarItem(pe);
            calendar1.AddEvent(calendarItem.customEvent);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
