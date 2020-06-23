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

        public ObjectiveControl(String text)
        {
            InitializeComponent();
            labelObjective.Text = text;
            this.text = text;
        }
    }
}
