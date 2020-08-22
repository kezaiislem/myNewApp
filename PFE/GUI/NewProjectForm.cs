using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PFE
{
    public partial class NewProjectForm : MetroFramework.Forms.MetroForm
    {

        public WelcomeFrom welcomeForm { get; set; }
        private NewProjectFormViewModel viewModel { get; set; }

        public NewProjectForm()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            viewModel = new NewProjectFormViewModel();
            textBoxProjectName.DataBindings.Add("Text", viewModel, "projectName");
        }

        private void NewProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!viewModel.success)
                welcomeForm.Show();
            else
            {
                MainForm main = new MainForm();
                main.PropertyChanged += welcomeForm.MainChanged;
                main.Show();
            }
                
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                if (viewModel.projectName == "")
                {
                    saveFileDialog.FileName = "Untitled Project";
                }
                else
                {
                    saveFileDialog.FileName = viewModel.projectName;
                }
                saveFileDialog.Filter = "Xml File|*.xml";
                saveFileDialog.Title = "Save Project";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProjectHandler.createNewProject(viewModel.projectName, saveFileDialog.FileName);
                    viewModel.success = true;
                    this.Close();
                }
            }
        }
    }
}
