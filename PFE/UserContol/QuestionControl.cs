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
    public partial class QuestionControl : UserControl
    {
        public QuestionControl(Question question)
        {
            InitializeComponent();
            this.labelQuestion.Text = question.text;
        }
    }
}
