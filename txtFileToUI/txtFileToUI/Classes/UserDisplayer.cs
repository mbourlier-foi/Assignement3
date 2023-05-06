using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFileToUI.Classes
{
    public class UserDisplayer
    {
        public UserDisplayer()
        {
        
        }

        public void DisplayUserInfo(FrmUserDataDisplay form, UserInfoForm user)
        {
            if (user == null)
            {
                Console.WriteLine("There is no such user to display");
            }

            if (form != null)
            {
                /* Modify the text of the textboxes */
                form.Controls["FullNameTextBox"].Text = user.FullName;
                form.Controls["YearOfBirthTextBox"].Text = user.YearOfBirth.ToString();
                form.Controls["CityTextBox"].Text = user.CityOfOrigin;
                form.Controls["FacultyTextBox"].Text = user.Faculty;
                form.Controls["RoleTextBox"].Text = user.Role;
                form.Controls["RoleSpecificAttributeTextBox"].Text = user.RoleSpecificAttribute;
            }
            else
            {
                Console.WriteLine("There is no form to display the user");
            }
        }
    }
}
