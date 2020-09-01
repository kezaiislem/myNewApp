using MetroFramework;
using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Forms;

namespace PFE
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

        private LoginFormViewModel viewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        private bool success;

        public LoginForm()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            viewModel = new LoginFormViewModel();
            metroTextBoxUsername.DataBindings.Add("Text", viewModel, "username");
            metroTextBoxPassword.DataBindings.Add("Text", viewModel, "password");
        }

        private async void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewModel.username == null || viewModel.password == null)
                {
                    MetroMessageBox.Show(this, "\n\nUsername and Password Cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (viewModel.username != "" && viewModel.password != "")
                {
                    String data = await RestHelper.authentificate(viewModel.username.ToLower(), viewModel.password);
                    if (data == "")
                    {
                        MetroMessageBox.Show(this, "\n\nWrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Session s = JsonConvert.DeserializeObject<Session>(data);
                        Data.sessionId = s.id;
                        Data.actifUser = s.user;
                        success = true;
                        OnNotifyPropertyChanged("Success");
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nUsername and Password Cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MetroMessageBox.Show(this, "\n\nCant Connect Server, Please check yout internet connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.PropertyChanged += NewUserChanged;
            newUserForm.Show();
        }

        public void NewUserChanged(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                if (e.PropertyName == "Success")
                {
                    NewUserForm newUserForm = (NewUserForm)o;
                    newUserForm.Close();
                    this.Show();
                }
                else
                {
                    if (this.Visible == false)
                    {
                        this.Show();
                    }
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!success)
            {
                OnNotifyPropertyChanged("Exit");
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