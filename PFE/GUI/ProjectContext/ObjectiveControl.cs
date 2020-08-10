using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.ViewModel;

namespace PFE
{
    public partial class ObjectiveControl : UserControl
    {

        public String text { get; set; }

        public List<String> objectives;

        public int index;

        public ObjectiveControl(String text, List<String> objectives, int index)
        {
            InitializeComponent();
            labelObjective.Text = text;
            this.text = text;
            this.objectives = objectives;
            this.index = index - 1;
            textBoxEditObjective.DataBindings.Add("Text", labelObjective, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            labelObjective.DataBindings.Add("Text", this, "text", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void labelObjective_DoubleClick(object sender, EventArgs e)
        {
            textBoxEditObjective.Visible = true;
            labelObjective.Visible = false;
            labelObjective.SendToBack();
            textBoxEditObjective.BringToFront();
            buttonRemoveObjective.Visible = true;
        }

        private void textBoxEditObjective_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13)
            {
                textBoxEditObjective.Visible = false;
                labelObjective.Visible = true;
                labelObjective.BringToFront();
                textBoxEditObjective.SendToBack();
                this.objectives[this.index] = this.text;
                buttonRemoveObjective.Visible = false;
            }
        }

        private void buttonRemoveObjective_Click(object sender, EventArgs e)
        {
            objectives.RemoveAt(this.index);
            this.Parent.Controls.Remove(this);
        }
    }
}
