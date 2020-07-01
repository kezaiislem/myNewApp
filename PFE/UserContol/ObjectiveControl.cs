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
            this.index = index-1;
        }

        private void labelObjective_DoubleClick(object sender, EventArgs e)
        {
            textBoxEditObjective.Visible = true;
            labelObjective.Visible = false;
            labelObjective.SendToBack();
            textBoxEditObjective.BringToFront();
        }

        private void textBoxEditObjective_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13)
            {
                text = textBoxEditObjective.Text;
                labelObjective.Text = text;
                textBoxEditObjective.Visible = false;
                labelObjective.Visible = true;
                labelObjective.BringToFront();
                textBoxEditObjective.SendToBack();
                textBoxEditObjective.Text = "";
                this.objectives[this.index] = this.text;
            }
        }
    }
}
