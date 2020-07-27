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
using PFE.Shared;
using Microsoft.VisualBasic;
using PFE.Model;

namespace PFE.UserContol
{
    public partial class ProjectContext : UserControl
    {

        public ProjectContextViewModel viewModel { get; set; }

        public ProjectContext()
        {
            InitializeComponent();
            loadProjectView();
        }

        public void loadProjectView()
        {
            viewModel = new ProjectContextViewModel();
            textBoxTechnologyName.DataBindings.Add("Text", viewModel.project.model.technology, "technologyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxAdress.DataBindings.Add("Text", viewModel.project, "companyAdress", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPhoneNumber.DataBindings.Add("Text", viewModel.project, "phoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyName.DataBindings.Add("Text", viewModel.project, "companyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyField.DataBindings.Add("Text", viewModel.project, "companyField", true, DataSourceUpdateMode.OnPropertyChanged);

            if (viewModel.project.objectives != null)
            {
                int i = 1;
                foreach (String input in viewModel.project.objectives)
                {
                    ObjectiveControl objective = new ObjectiveControl(input, viewModel.project.objectives, i);
                    objective.Dock = DockStyle.Top;
                    objectivesPanel.Controls.Add(objective);
                    i++;
                }
            }
            comboBoxTechnologyNature.DataSource = viewModel.fields;
            comboBoxTechnologyNature.DataBindings.Add("SelectedItem", viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void addObjectiveButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Objective Name", "Add Objective", "", -1, -1);
            if (input != "")
            {
                if (viewModel.project.objectives == null)
                {
                    viewModel.project.objectives = new List<String>();
                }
                viewModel.project.objectives.Add(input);
                ObjectiveControl objective = new ObjectiveControl(input, viewModel.project.objectives, viewModel.project.objectives.Count());
                objective.Dock = DockStyle.Top;
                objectivesPanel.Controls.Add(objective);
            }
        }
    }
}
