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
        public Color eventColor { set; get; } = Color.Red;

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
            panel1.DataBindings.Add("BackColor", this, "eventColor", true, DataSourceUpdateMode.OnPropertyChanged);
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

        private Boolean checkValues()
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Event test cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DateTime.Compare(startDate, endDate) >= 0)
            {
                MessageBox.Show("End date must be higher than start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.panel1.BackColor = colorDialog.Color;
            }
        }
    }
}
