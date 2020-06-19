using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PFE
{
    public partial class NewProjectForm : MetroFramework.Forms.MetroForm
    {

        public WelcomeFrom welcomeForm { get; set; }

        public List<Domain> domains = new List<Domain>();

        private Boolean success = false;

        public NewProjectForm()
        {
           
            InitializeComponent();
            getDomains();
        }

        private async void getDomains()
        {
            String data = await RestHelper.getDomains();
            if(data != "")
            {
                Console.WriteLine("here");
                domains = JsonConvert.DeserializeObject<List<Domain>>(data);
            }
            InitializeCombo();
        }

        private void InitializeCombo()
        {
            foreach(Domain domain in domains)
            {
                domainComboBox.Items.Add(new ComboboxItem { Text = domain.name, Value = domain });
                domainComboBox.SelectedIndex = 0;
            }
        }

        private void NewProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!success)
                welcomeForm.Show();
            else
                welcomeForm.Close();
        }

        private async void createProjectBtn_Click(object sender, EventArgs e)
        {
            ComboboxItem selecteditem = (ComboboxItem)domainComboBox.SelectedItem;
            Project project = new Project { name = projectName.Text, technologyName = technologyName.Text, organization = organizationName.Text, domain = (Domain)selecteditem.Value };
            String result = await RestHelper.createProject(project);
        }
    }
}
