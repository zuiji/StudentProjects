using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miljø_AD_tool;

namespace UserInterFace
{
    public partial class GetInfoAndAddUserForm : Form
    {
        public DirectoryEntry DirectoryEntry { get; set; }
        public GetInfoAndAddUserForm()
        {
            InitializeComponent();
            DirectoryEntry = ConnectionPath.CreateDirectoryEntry();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("You must enter a search value");
                return;
            }

            try
            {
                string result = GetUserInfo.UserInfo(username, DirectoryEntry);
                ResultWinow.Text = result;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }


        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("You must enter your full name");
                return;
            }

            try
            {
                string result = CreateUser.CreateUserAccount(firstName, lastName, DirectoryEntry);
                MessageBox.Show(result);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
               
            }
        }
    }
}