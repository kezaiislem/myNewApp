﻿using Newtonsoft.Json;
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
            //getDomains();
        }

        private void InitializeView()
        {
            viewModel = new NewProjectFormViewModel();
            textBoxProjectName.DataBindings.Add("Text", viewModel, "projectName");
        }

        private async void getDomains()
        {
            /*String data = await RestHelper.getDomains();
            if(data != "")
            {
                Console.WriteLine("here");
                domains = JsonConvert.DeserializeObject<List<Field>>(data);
            }
            InitializeCombo();*/
        }

        private void InitializeCombo()
        {
            /*foreach(Field domain in domains)
            {
                domainComboBox.Items.Add(new ComboboxItem { Text = domain.name, Value = domain });
                domainComboBox.SelectedIndex = 0;
            }*/
        }

        private void NewProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!viewModel.success)
                welcomeForm.Show();
            else
                new MainForm().Show();
        }

        private async void createProjectBtn_Click(object sender, EventArgs e)
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
            /*ComboboxItem selecteditem = (ComboboxItem)domainComboBox.SelectedItem;
            Project project = new Project { name = projectName.Text, technologyName = technologyName.Text, companyName = organizationName.Text, technologyNature = (Field)selecteditem.Value };
            String result = await RestHelper.createProject(project);*/
        }
    }
}
