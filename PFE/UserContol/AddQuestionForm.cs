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
    public partial class AddQuestionForm : Form
    {
        public String text { get; set; }
        public String type { get; set; }

        public AddQuestionForm()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            textBoxText.DataBindings.Add("Text", this, "text", true, DataSourceUpdateMode.OnPropertyChanged);
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
