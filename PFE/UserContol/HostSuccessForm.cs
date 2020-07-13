using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.UserContol
{
    public partial class HostSuccessForm : Form
    {

        private string hostId { get; set; }

        public HostSuccessForm(string hostId)
        {
            InitializeComponent();
            this.hostId = "http://localhost:4200/survey/" + hostId;
            textBoxLink.Text = this.hostId;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hostId);
        }
    }
}
