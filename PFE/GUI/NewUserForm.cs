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
            this.comboBoxRole.DataSource = this.viewModel.roles;
            this.comboBoxRole.DataBindings.Add("SelectedValue", this.viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
