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
using Newtonsoft.Json;

namespace PFE.UserContol
{
    public partial class PhaseControl : UserControl
    {

        PhaseControlViewModel viewModel;

        SectionControl activeSection;

        public PhaseControl(Survey survey, Model.Model model)
        {
            viewModel = new PhaseControlViewModel(survey, model);
            InitializeComponent();
            if( viewModel.survey == null)
            {
                viewModel.survey = new Survey { sections = new List<Section>() };
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
                    addSection(form.viewModel.Title, form.viewModel.Description, form.viewModel.Factor);
                }
            }
        }

        private void loadSections()
        {
            foreach (Section section in viewModel.survey.sections)
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
            Section section = new Section { title = title, description = description, factor = factor, questions = new List<Question>() };
            this.viewModel.survey.sections.Add(section);
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

        public static void removeSection()
        {

        }

        private async void buttonHost_Click(object sender, EventArgs e)
        {
            using (var form = new HostForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Console.WriteLine(this.viewModel.survey.model.technology.technologyName);
                    String res = await RestHelper.hostSurvey(this.viewModel.survey);
                    Survey survey = JsonConvert.DeserializeObject<Survey>(res);
                    //this.viewModel.phase.survey = survey;
                    //ProjectHandler.saveProject();
                }
            }
        }
    }
}
