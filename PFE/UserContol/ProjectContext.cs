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
            textBoxTechnologyName.DataBindings.Add("Text", Data.currentProject, "technologyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxAdress.DataBindings.Add("Text", Data.currentProject, "companyAdress", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPhoneNumber.DataBindings.Add("Text", Data.currentProject, "phoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyName.DataBindings.Add("Text", Data.currentProject, "companyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyField.DataBindings.Add("Text", Data.currentProject, "companyField", true, DataSourceUpdateMode.OnPropertyChanged);

            if (Data.currentProject.objectives != null)
            {
                foreach (String input in Data.currentProject.objectives)
                {
                    ObjectiveControl objective = new ObjectiveControl(input);
                    objective.Dock = DockStyle.Top;
                    objectivesPanel.Controls.Add(objective);
                }
            }

            viewModel.initCombos();
            comboBoxTechnologyNature.DataSource = viewModel.combos;
            comboBoxTechnologyNature.DataBindings.Add("SelectedItem", viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void addObjectiveButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Objective Name", "Add Objective", "", -1, -1);
            if (input != "")
            {
                ObjectiveControl objective = new ObjectiveControl(input);
                objective.Dock = DockStyle.Top;
                objectivesPanel.Controls.Add(objective);
                if (Data.currentProject.objectives == null)
                {
                    Data.currentProject.objectives = new List<String>();
                }
                Data.currentProject.objectives.Add(input);
            }
        }
    }
}
