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
                Console.WriteLine("There is no user to display.");
            }

            if (form != null)
            {
                /* Modify the text of the textboxes */
                form.Controls["txtFullName"].Text = user.Name + " " + user.Surname;
                form.Controls["txtYearofbirth"].Text = user.YearOfBirth;
                form.Controls["txtCity"].Text = user.City;
                form.Controls["txtFaculty"].Text = user.Faculty;
                form.Controls["txtRole"].Text = user.Role;
            }
            else
            {
                Console.WriteLine("There is no form to display the user.");
            }
        }
    }
}
