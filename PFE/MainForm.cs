using MetroFramework;
using Microsoft.VisualBasic;
using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PFE
{
    public partial class MainForm : Form
    {
        private MainFormViewModel viewModel { get; set; }

        public MainForm()
        {
            InitializeComponent();
            loadProjectView();
            hideSubMenu();
        }

        public void loadProjectView()
        {
            viewModel = new MainFormViewModel();
            textBoxTechnologyName.DataBindings.Add("Text", Data.currentProject, "technologyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxAdress.DataBindings.Add("Text", Data.currentProject, "companyAdress", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPhoneNumber.DataBindings.Add("Text", Data.currentProject, "phoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyName.DataBindings.Add("Text", Data.currentProject, "companyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyField.DataBindings.Add("Text", Data.currentProject, "companyField", true, DataSourceUpdateMode.OnPropertyChanged);

            if (Data.currentProject.objectives != null)
            {
                foreach (String objective in Data.currentProject.objectives)
                {
                    ObjectiveItem item = new ObjectiveItem(objective, objectivesPanel.Size.Width - 20);
                    objectivesPanel.Controls.Add(item.panel);
                }
            }

            viewModel.initCombos();
            comboBoxTechnologyNature.DataSource = viewModel.combos;
            comboBoxTechnologyNature.SelectedItem = viewModel.selectedItem;
        }

        private void hideSubMenu()
        {
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            openChildForm();
            Console.WriteLine(Data.currentProject.companyField);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form2());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openChildForm()
        {
            panelProjectContext.Show();
        }

        private void addObjectiveButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Objective Name", "Add Objective", "", -1, -1);
            if (input != "")
            {
                ObjectiveItem item = new ObjectiveItem(input, objectivesPanel.Size.Width - 20);
                objectivesPanel.Controls.Add(item.panel);
                if (Data.currentProject.objectives == null)
                {
                    Data.currentProject.objectives = new List<String>();
                }
                Data.currentProject.objectives.Add(input);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            ProjectHandler.saveProject();
            MessageBox.Show("Project Successfully Saved");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "\nDo u want to save your current project ?", "Exit?", MessageBoxButtons.YesNoCancel);
            
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                if (comboBoxTechnologyNature.SelectedItem != null)
                {
                    Data.currentProject.technologyNature = (Field)((ComboboxItem)comboBoxTechnologyNature.SelectedItem).Value;
                }
                ProjectHandler.saveProject();
            } 
            else
            {
                e.Cancel = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
