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
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public string CityOfOrigin { get; set; }
        public string Faculty { get; set; }
        public string FavoriteCourse { get; set; }
        public string Role { get; set; }
        public string RoleSpecificAttribute { get; set; }

        public UserInfoForm()
        {

        }
    }
}
