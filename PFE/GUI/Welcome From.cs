﻿using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PFE
{
    public partial class WelcomeFrom : MetroFramework.Forms.MetroForm
    {

        private List<Project> items = new List<Project>();

        public WelcomeFrom()
        {
            InitializeComponent();
            projectListView.Items.Clear();
            newProject.UseSelectable = false;
            loadProjects.UseSelectable = false;
            logOut.UseSelectable = false;
        }

        private void newProject_Click(object sender, EventArgs e)
        {
            NewProjectForm form = new NewProjectForm();
            this.Hide();
            form.welcomeForm = this;
            form.Show();
        }

        private void loadProjects_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Project Files | *.xml";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProjectHandler.loadProject(openFileDialog.FileName);
                    this.Hide();
                    MainForm main = new MainForm();
                    main.PropertyChanged += MainChanged;
                    main.Show();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menuPanel.Show();
            loadPanel.Hide();
        }

        private void pageResized(object sender, EventArgs e)
        {
            this.domain.Width = -2;
        }

        private void loadProjectsMethode()
        {
            /*foreach( Project project in Data.actifUser.projects)
            {
                ListViewItem item = new ListViewItem(project.name);
                item.SubItems.Add(project.technologyName);
                item.SubItems.Add("Mon Dpmaine");
                projectListView.Items.Add(item);
            }*/
        }

        public void MainChanged(object o, PropertyChangedEventArgs e)
        {
            if(o != null)
            {
                MainForm main = (MainForm)o;
                if (e.PropertyName.Equals("close"))
                {
                    main.Close();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void login()
        {
            this.Visible = false;
            LoginForm form = new LoginForm();
            form.PropertyChanged += LoginChanged;
            form.Show();
        }

        public void LoginChanged(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                LoginForm loginForm = (LoginForm)o;
                if (e.PropertyName == "Exit")
                {
                    this.Close();
                }
                else
                {
                    loginForm.Close();
                    this.Show();
                }
            }
        }

        private void WelcomeFrom_Shown(object sender, EventArgs e)
        {
            this.login();
        }
    }
}
