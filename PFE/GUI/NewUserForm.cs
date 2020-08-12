using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PFE
{
    public partial class NewUserForm : MetroFramework.Forms.MetroForm
    {
        private NewUserFormViewModel viewModel;

        public NewUserForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.viewModel = new NewUserFormViewModel();
            this.textBoxAdress.DataBindings.Add("Text", this.viewModel.user, "adress", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxEmail.DataBindings.Add("Text", this.viewModel.user, "email", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxFirstName.DataBindings.Add("Text", this.viewModel.user, "firstName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxLastName.DataBindings.Add("Text", this.viewModel.user, "lastName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxPassword.DataBindings.Add("Text", this.viewModel.user, "password", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxPhoneNumber.DataBindings.Add("Text", this.viewModel.user, "phoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxUsername.DataBindings.Add("Text", this.viewModel.user, "username", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxRPassword.DataBindings.Add("Text", this.viewModel, "rPassword", true, DataSourceUpdateMode.OnPropertyChanged);
            this.comboBoxRole.DataSource = this.viewModel.roles;
            this.comboBoxRole.DataBindings.Add("SelectedValue", this.viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (await this.viewModel.checkFields())
            {
                this.viewModel.addUser();
            }
            else
            {
                labelRequired.Visible = true;
            }
        }

        private async void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.viewModel.user.username))
            {
                if (Regex.IsMatch(this.viewModel.user.username, "^[a-zA-Z][a-zA-Z0-9]*$"))
                {
                    if (await viewModel.usernameUsed())
                    {
                        labelUserUnaviable.Visible = true;
                    }
                    else
                    {
                        labelUserAviable.Visible = true;
                    }
                }
                else
                {
                    labelInvalidUsername.Visible = true;
                }

            }
        }

        private async void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.viewModel.user.email))
            {
                if (Regex.IsMatch(this.viewModel.user.email, @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase))
                {
                    if (await viewModel.emailUsed())
                    {
                        labelEmailUnaviable.Visible = true;
                    }
                }
                else
                {
                    labelInvalidEmail.Visible = true;
                }
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            labelUserUnaviable.Visible = false;
            labelUserAviable.Visible = false;
            labelInvalidUsername.Visible = false;
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            labelEmailUnaviable.Visible = false;
            labelInvalidEmail.Visible = false;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            labelInvalidPassword.Visible = false;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (!viewModel.checkPassword())
            {
                labelInvalidPassword.Visible = true;
            }
        }

        private void textBoxRPassword_Enter(object sender, EventArgs e)
        {
            labelInvalidRpassword.Visible = false;
        }

        private void textBoxRPassword_Leave(object sender, EventArgs e)
        {
            if (!viewModel.checkRPassword())
            {
                labelInvalidRpassword.Visible = true;
            }
        }
    }
}
