using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using Newtonsoft.Json;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class NewUserFormViewModel
    {
        public Role selectedItem;
        public Role SelectedItem {
            get => selectedItem;
            set
            {
                user.role = value;
                selectedItem = value;
            }
        }
        public List<Role> roles { get; set; }

        public User user { get; set; }
        public string rPassword { get; set; }

        public NewUserFormViewModel()
        {
            roles = Role.getRoles();
            user = new User();
            SelectedItem = roles.First<Role>();
        }

        public async Task<bool> usernameUsed()
        {
            bool res = await RestHelper.checkUsername(this.user.username);
            return res;
        }
        
        public async Task<bool> emailUsed()
        {
            bool res = await RestHelper.checkEmail(this.user.email);
            return res;
        }

        public bool checkPassword()
        {
            if (!String.IsNullOrWhiteSpace(this.user.password))
            {
                if (!Regex.IsMatch(this.user.password, "^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,}$"))
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkRPassword()
        {
            if (!String.IsNullOrWhiteSpace(rPassword))
            {
                if (rPassword != user.password)
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<bool> checkEmail()
        {
            if (!String.IsNullOrWhiteSpace(this.user.email))
            {
                if (Regex.IsMatch(this.user.email, @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase))
                {
                    if (await emailUsed())
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<bool> checkUsername()
        {
            if (!String.IsNullOrWhiteSpace(this.user.username))
            {
                if (Regex.IsMatch(this.user.username, "^[a-zA-Z][a-zA-Z0-9]*$"))
                {
                    if (await usernameUsed())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<bool> checkFields()
        {
            if (await this.checkEmail() &&
                this.checkPassword() &&
                this.checkRPassword() &&
                await this.checkUsername() &&
                !String.IsNullOrWhiteSpace(user.firstName) &&
                !String.IsNullOrWhiteSpace(user.lastName) &&
                this.user.role != null
                )
            {
                return true;
            }
            return false;
        }

        public async Task<bool> addUser()
        {
            return await RestHelper.addUser(this.user);
        }
    }
}
