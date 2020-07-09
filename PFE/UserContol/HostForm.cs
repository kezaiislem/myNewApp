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
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
            datePickerClose.MinDate = DateTime.Today;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxTerms.Checked)
            {
                DateTime closeDate = datePickerClose.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must check the option ' I accept sharing my questions ' in order to host your survey", "Advertissement", MessageBoxButtons.OK);
            }
        }
    }
}
