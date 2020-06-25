using PFE.Model;
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
    public partial class AddSectionForm : Form
    {
        public String Title { get; set; }
        public Factor Factor { get; set; }
        public String Description { get; set; }


        public AddSectionForm()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            textBoxTitle.DataBindings.Add("Text", this, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDescription.DataBindings.Add("Text", this, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            //comboBoxFactor.DataBindings.Add("SelectedItem", this, "Factor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
