using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace PFE
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void signinButton_Click(object sender, EventArgs e)
        {
            String userName = metroTextBoxUsername.Text.ToLower();
            String password = metroTextBoxPassword.Text;
            try
            {
                if (userName != "" && password != "")
                {
                    String data = await RestHelper.authentificate(userName, password);
                    if (data == "")
                    {
                        Console.WriteLine("Wrong User or pass");
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
                    Console.WriteLine("Cant be null");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}