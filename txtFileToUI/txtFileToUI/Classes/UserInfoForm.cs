using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFileToUI.Classes
{
    public class UserInfoForm
    {
        public string Name;
        public string Surname;
        public string YearOfBirth;
        public string City;
        public string Faculty;
        public string Role;
        public string RoleSpecificAttribute;

        public UserInfoForm(string[] tab)
        {
            Name = tab[0];
            Surname = tab[1];
            YearOfBirth = tab[2];
            City = tab[3];
            Faculty = tab[4];
            Role = tab[5];
            RoleSpecificAttribute = "";
        }
    }
}
