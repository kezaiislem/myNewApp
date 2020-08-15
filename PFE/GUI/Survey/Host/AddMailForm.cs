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
    public partial class AddMailForm : Form
    {

        public string mail { get; set; }

        public AddMailForm()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            textBoxEmail.DataBindings.Add("Text", this, "mail", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkFields()
        {
            try
            {
                MailAddress ma = new MailAddress(mail);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
