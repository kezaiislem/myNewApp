using PFE.CustomObjects;
using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace PFE.UserContol
{
    public partial class HostSuccessForm : Form
    {

        public BindingList<String> items { get; set; } = new BindingList<string>();
        private string hostId { get; set; }

        public HostSuccessForm(string hostId)
        {
            InitializeComponent();
            this.hostId = hostId;
            textBoxLink.Text = "http://localhost:4200/survey/" + this.hostId;
            listBoxEmails.DataSource = items;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("http://localhost:4200/survey/" + this.hostId);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(var form = new AddMailForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    items.Add(form.mail);
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxEmails.SelectedIndex >= 0)
            {
                items.RemoveAt(listBoxEmails.SelectedIndex);
            }
            listBoxEmails.Refresh();
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            if (items.Count() > 0)
            {
                MailingRequest request = new MailingRequest();
                request.subject = "Survey Link";
                request.destinations = items.ToList<String>();
                Task.Run(async () => await RestHelper.shareSurvey(hostId, request));
                MessageBox.Show("Survey shared successfuly");           
            }
        }
    }
}
