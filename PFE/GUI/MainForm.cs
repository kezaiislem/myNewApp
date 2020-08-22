using MetroFramework;
using Microsoft.VisualBasic;
using PFE.Model;
using PFE.Shared;
using PFE.UserContol;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PFE
{
    public partial class MainForm : Form
    {
        public MainFormViewModel viewModel { get; set; }
        private ProjectContext projectContextView { get; set; }
        private ModelInfo modelInfoView { get; set; }
        private ValidationControl validationView { get; set; }
        private SurveysControl surveysControl { get; set; }
        private ProjectPlanControl projectPlanView { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private UserControl currentView;

        private bool closeProject = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeViews();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            //panelToolsSubMenu.Visible = false;
        }
        
        private void InitializeViews()
        {

            viewModel = new MainFormViewModel();

            this.surveysControl = new SurveysControl(this.viewModel.projet.model.id);
            this.surveysControl.Visible = false;
            this.surveysControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surveysControl.AutoScaleMode = AutoScaleMode.None;
            this.surveysControl.Name = "surveysView";
            this.surveysControl.PropertyChanged += HostRemoved;
            this.panelCurrentView.Controls.Add(this.surveysControl);

            // Page Project Context
            this.projectContextView = new ProjectContext();
            this.projectContextView.Visible = false;
            this.projectContextView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectContextView.AutoScaleMode = AutoScaleMode.None;
            this.projectContextView.Name = "projectContextView";
            this.panelCurrentView.Controls.Add(this.projectContextView);

            // Page Project Plan
            this.projectPlanView = new ProjectPlanControl(this.viewModel.projet.events);
            this.projectPlanView.Visible = false;
            this.projectPlanView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectPlanView.AutoScaleMode = AutoScaleMode.None;
            this.projectPlanView.Name = "projectContextView";
            this.panelCurrentView.Controls.Add(this.projectPlanView);

            // Page Model Info
            if (this.viewModel.projet.model == null)
            {
                this.viewModel.projet.model = new PFE.Model.Model();
            }
            this.modelInfoView = new ModelInfo(this.viewModel.projet.model, this);
            this.modelInfoView.Visible = false;
            this.modelInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelInfoView.AutoScaleMode = AutoScaleMode.None;
            this.modelInfoView.Name = "projectContextView";
            this.panelCurrentView.Controls.Add(this.modelInfoView);

            // Page Validation
            this.validationView = new ValidationControl(this.viewModel.projet.model);
            this.validationView.Visible = false;
            this.validationView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validationView.AutoScaleMode = AutoScaleMode.None;
            this.validationView.Name = "projectContextView";
            this.panelCurrentView.Controls.Add(this.validationView);

            // First Page
            switchView(projectContextView);
            labelPageName.Text = "Project Context";
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
            switchView(projectContextView);
            labelPageName.Text = "Project Context";
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
            switchView(modelInfoView);
            labelPageName.Text = "Model Info";
            hideSubMenu();
            //showSubMenu(panelModelSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            switchView(validationView);
            labelPageName.Text = "Validation and analystics";
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
            hideSubMenu();
            labelPageName.Text = "Results";
            switchView(surveysControl);
            surveysControl.reload(this.viewModel.projet.model.id);
            //..
            //your codes
            //..
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
            this.Close();
        }

        private void switchView(UserControl userControl)
        {
            if( currentView == null)
            {
                currentView = userControl;
            }
            else
            {
                currentView.Hide();
                currentView = userControl;
            }
            currentView.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ProjectHandler.saveProject();
            MessageBox.Show("Project Successfully Saved");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeProject)
            {
                DialogResult result = MetroMessageBox.Show(this, "\nDo u want to save your current project ?", "Exit?", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    ProjectHandler.saveProject();
                }
                else
                {
                    e.Cancel = false;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closeProject)
            {
                this.Hide();
                OnNotifyPropertyChanged("exit");
            }
        }

        private void ButtonProjectPlan_Click(object sender, EventArgs e)
        {
            switchView(projectPlanView);
            labelPageName.Text = "Project Plan";
            hideSubMenu();
        }

        private void HostRemoved(object o, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != null)
            {
                this.viewModel.RemoveHost(e.PropertyName);
            }
        }

        private void buttonCloseProject_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "\nDo u want to save your current project ?", "Exit?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.No)
            {
                closeProject = true;
                this.Hide();
                OnNotifyPropertyChanged("close");
            }
            else if (result == DialogResult.Yes)
            {
                closeProject = true;
                ProjectHandler.saveProject();
                this.Hide();
                OnNotifyPropertyChanged("close");
            }
        }

        private void OnNotifyPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                tmp(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
