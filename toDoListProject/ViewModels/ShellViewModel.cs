using Caliburn.Micro;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toDoListProject.Models;

namespace toDoListProject.ViewModels
{
    public class ShellViewModel : Screen
    {

        private string _firstName = "Tim";
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
            }

        }
        private string _focusName = "Podaj login";
        public string FocusName
        {
            get
            {
                return _focusName;
            }
            set
            {
                _focusName = value;
                NotifyOfPropertyChange(() => FocusName);
            }

        }

        private string _focusPassword = "Podaj hasło";
        public string FocusPassword
        {
            get
            {
                return _focusPassword;
            }
            set
            {
                _focusPassword = value;
                NotifyOfPropertyChange(() => FocusPassword);
            }
        }

        private static void AddUser()
        {
            var users = new List<User>
            {
                new User {Name = "Tom", ForName ="Smith", Login ="Tommy", Password="Theone1"}
            };

            using (var context = new ApplicationDbContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }


    }
}