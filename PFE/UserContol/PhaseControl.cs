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
using System.Web.UI.Design;
using MetroFramework.Controls;
using PFE.Shared;
using PFE.Model;

namespace PFE.UserContol
{
    public partial class PhaseControl : UserControl
    {

        PhaseControlViewModel viewModel;

        SectionControl activeSection;

        public PhaseControl(Phase phase)
        {
            viewModel = new PhaseControlViewModel(phase);
            InitializeComponent();
            if( viewModel.phase.survey == null)
            {
                viewModel.phase.survey = new Survey { sections = new List<Section>() };
            }
            else
            {
                loadSections();
            }
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

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            using (var form = new AddSectionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    addSection(form.Title, form.Description, null);
                }
            }
        }

        private void loadSections()
        {
            foreach (Section section in viewModel.phase.survey.sections)
            {
                MetroButton button = new MetroButton();
                button.Text = section.title;
                button.Dock = DockStyle.Top;
                button.Height = 35;
                button.Click += (s, ev) => {
                    SectionControl sectionControl = new SectionControl(section);
                    sectionControl.Visible = true;
                    sectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
                    sectionControl.AutoScaleMode = AutoScaleMode.None;
                    this.swichSection(sectionControl);
                };
                panelSections.Controls.Add(button);
                panelSections.Controls.SetChildIndex(button, 0);
            }
        }

        private void addSection(String title, String description, Factor factor)
        {
            MetroButton button = new MetroButton();
            button.Text = title;
            button.Dock = DockStyle.Top;
            button.Height = 35;
            this.viewModel.phase.survey.sections.Add(new Section { title = title, description = description, questions = new List<Question>() });
            button.Click += (s, ev) => {
                SectionControl sectionControl = new SectionControl(this.viewModel.phase.survey.sections.Last<Section>());
                sectionControl.Visible = true;
                sectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
                sectionControl.AutoScaleMode = AutoScaleMode.None;
                this.swichSection(sectionControl);
            };
            panelSections.Controls.Add(button);
            panelSections.Controls.SetChildIndex(button, 0);
        }

        public static void removeSection()
        {

        }

    }
}
