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

namespace PFE.UserContol
{
    public partial class PhaseControl : UserControl
    {

        PhaseControlViewModel viewModel;

        SectionControl activeSection;

        public PhaseControl(int phaseNumber)
        {
            viewModel = new PhaseControlViewModel(phaseNumber);
            InitializeComponent();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            SectionControl section = new SectionControl();
            section.Visible = true;
            section.Dock = System.Windows.Forms.DockStyle.Top;
            section.AutoScaleMode = AutoScaleMode.None;
            section.Name = "test";
            this.swichSection(section);
        }

        private void swichSection(SectionControl section)
        {
            if ( activeSection != null )
            {
                this.activeSection.Dispose();
                
            }
            this.activeSection = section;
            this.panelSectionContent.Controls.Add(section);
        }
    }
}
