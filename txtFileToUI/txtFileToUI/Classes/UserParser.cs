using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFileToUI.Classes
{
    public class UserParser
    {
        public string[] ParseDate(string data)
        {
            List<string> list = new List<string>();
            string[] rows = data.Split('\n');

            foreach (string row in rows)
            {
                string[] field = row.Split('=');
                if (field.Length == 2)
                {
                    string value = field[1].Trim();
                    list.Add(value);

                }

            }
            return list.ToArray();
        }
    }
}
