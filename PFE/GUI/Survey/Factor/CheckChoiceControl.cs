using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.Model;
using PFE.Constants;

namespace PFE.UserContol
{
    public partial class CheckChoiceControl : UserControl
    {
        public int index { get; set; }
        public String choice { get; set; }
        public Boolean remove { get; set; }

        public CheckChoiceControl(String choice, int index)
        {
            InitializeComponent();
            this.index = index;
            this.choice = choice;
            labeltext.DataBindings.Add("Text", this, "choice", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxEditText.DataBindings.Add("Text", this.labeltext, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                this.remove = false;
                tmp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnNotifyPropertyRemoved(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                this.remove = true;
                tmp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void buttonRemoveChoice_Click(object sender, EventArgs e)
        {
            OnNotifyPropertyRemoved(index.ToString());
        }

        private void labelText_DoubleClick(object sender, EventArgs e)
        {
            textBoxEditText.Visible = true;
            labeltext.Visible = false;
            labeltext.SendToBack();
            textBoxEditText.BringToFront();
            buttonRemoveChoice.Visible = true;
        }

        private void textBoxEditText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxEditText.Visible = false;
                labeltext.Visible = true;
                labeltext.BringToFront();
                textBoxEditText.SendToBack();
                buttonRemoveChoice.Visible = false;
                OnNotifyPropertyChanged(index.ToString());
            }
        }
    }
}
