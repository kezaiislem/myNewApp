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

namespace PFE.UserContol
{
    public partial class SectionControl : UserControl
    {

        private int tabIndex = 1; 

        public SectionControl()
        {
            InitializeComponent();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            tabIndex++;
            QuestionControl a = new QuestionControl("Question 1", 0, null);
            a.Dock = DockStyle.Top;
            mainPanel.Controls.Add(a);
            mainPanel.Controls.SetChildIndex(a, 0);
        }
    }
}
