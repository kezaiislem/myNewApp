using MetroFramework;
using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using PFE.ViewModel;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace PFE
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

        private LoginFormViewModel viewModel;

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
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nUsername and Password Cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}