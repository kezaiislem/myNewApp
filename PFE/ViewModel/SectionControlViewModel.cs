using PFE.Model;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class SectionControlViewModel
    {
        public Section section { get; set; }
        public List<LikertQuestionControl> QuestionControls { get; set; }

        public SectionControlViewModel(Section section)
        {
            this.QuestionControls = new List<LikertQuestionControl>();
            this.section = section;
        }
    }
}
