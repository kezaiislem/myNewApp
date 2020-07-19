using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.UserContol
{
    public partial class AddEventForm : Form
    {

        public string text { get; set; }
        public DateTime startDate { set; get; }
        public DateTime endDate { set; get; }
        public Color eventColor { set; get; }

        public AddEventForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            textEventName.DataBindings.Add("Text", this, "text", true, DataSourceUpdateMode.OnPropertyChanged);
            inputStartDate.DataBindings.Add("Value", this, "startDate", true, DataSourceUpdateMode.OnPropertyChanged);
            inputEndtDate.DataBindings.Add("Value", this, "endDate", true, DataSourceUpdateMode.OnPropertyChanged);
            inputStartDate.MinDate = DateTime.Today;
            inputEndtDate.DataBindings.Add("MinDate", this, "startDate", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                startDate = inputStartDate.Value;
                endDate = inputEndtDate.Value;
                endDate.AddDays(1);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private Boolean checkValues()
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            return true;
        }
    }
}
