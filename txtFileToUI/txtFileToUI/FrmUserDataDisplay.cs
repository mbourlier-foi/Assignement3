using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using txtFileToUI.Classes;

namespace txtFileToUI
{
    public partial class FrmUserDataDisplay : Form
    {
        public FrmUserDataDisplay()
        {
            InitializeComponent();
        }

        private void FrmUserDataDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                UserFileReader userFileReader = new UserFileReader(fileDialog.FileName);
                UserParser userParser = new UserParser();
                UserInfoForm userInfoForm = new UserInfoForm(userParser.ParseDate(userFileReader.ReadFile()));
                UserDisplayer userDisplayer = new UserDisplayer();
                userDisplayer.DisplayUserInfo(this, userInfoForm);

            }
        }
    }
}
