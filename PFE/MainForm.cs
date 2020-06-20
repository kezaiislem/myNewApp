using Microsoft.VisualBasic;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PFE
{
    public partial class MainForm : Form
    {

        public Field selectedField { get; set; }
        List<ComboboxItem> combos { get; set; }
        ComboboxItem selectedItem { get; set; }

        public MainForm()
        {
            InitializeComponent();
            //ProjectHandler.createNewProject("hohtihtrhrt", "C:\\Users\\ISLEM\\Desktop");
            loadProjectView();
            initCombos();
            hideSubMenu();
        }

        public void loadProjectView()
        {
            if (ProjectHandler.loadProject("C:\\Users\\ISLEM\\Desktop\\hohtihtrhrt.xml"))
            {
                textBoxTechnologyName.DataBindings.Add("Text", Data.currentProject, "technologyName");
                textBoxAdress.DataBindings.Add("Text", Data.currentProject, "companyAdress");
                textBoxPhoneNumber.DataBindings.Add("Text", Data.currentProject, "phoneNumber");
                textBoxCompanyName.DataBindings.Add("Text", Data.currentProject, "companyName");
                textBoxCompanyField.DataBindings.Add("Text", Data.currentProject, "companyField");
            }
        }

        public void saveProject()
        {
            Data.currentProject.technologyNature = (Field)((ComboboxItem)comboBoxTechnologyNature.SelectedItem).Value;
            ProjectHandler.saveProject();
        }

        private void initCombos()
        {

            if(Data.currentProject.objectives != null)
            {
                foreach (String objective in Data.currentProject.objectives)
                {
                    ObjectiveItem item = new ObjectiveItem(objective, objectivesPanel.Size.Width - 20);
                    objectivesPanel.Controls.Add(item.panel);
                }
            }

            combos = new List<ComboboxItem>();

            if (Data.fields.Count == 0)
            {
                Data.fields.Add(new Field { id = 0, name = "Informatique" });
                Data.fields.Add(new Field { id = 1, name = "university" });
                Data.fields.Add(new Field { id = 2, name = "Buisness" });
                Data.fields.Add(new Field { id = 3, name = "Infos" });
                foreach(Field it in Data.fields)
                {
                    combos.Add(new ComboboxItem { Text = it.name, Value = it });
                    if (it.id == Data.currentProject.technologyNature.id)
                    {
                        selectedItem = combos.Last<ComboboxItem>();
                    }
                }
            }
            comboBoxTechnologyNature.DataSource = combos;
            comboBoxTechnologyNature.SelectedItem = selectedItem;
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
            string input = Interaction.InputBox("Objective Name", "Add Objective", "", -1 , -1);
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
            saveProject();
            MessageBox.Show("Project Successfully Saved");
        }
    }
}
