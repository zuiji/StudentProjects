using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljø_AD_tool
{
    class CreateUser
    {
        public static string CreateUserAccount(string firstName, string lastname, DirectoryEntry CreateDirectoryEntry)
        {
            try
            {


                // contains Standard Password. 
                string password = "User1234!";

                // adding a X if Users first name or last name is under 3 chars long. and its added to the right of his name.
                string loginName = firstName.PadRight(3, 'X').Substring(0, 3) + lastname.PadRight(3, 'X').Substring(0, 3);

                // collects firstname and lastname
                string fullname = $"{firstName} {lastname}";

                // Using LDAP connection object
                DirectoryEntry dirEntry = CreateDirectoryEntry;

                // Adding a Child ( new User ) with fullname with are a collection of FirstName and LastName
                DirectoryEntry newUser = dirEntry.Children.Add($"CN={ fullname}", "user");
                newUser.Properties["samAccountName"].Value = loginName;
                newUser.Properties["sn"].Value = lastname;
                newUser.Properties["givenName"].Value = firstName;
                newUser.Properties["userPrincipalName"].Value = loginName + "@H1.com";

                // Saves the Changes
                newUser.CommitChanges();

                //If you dont have an SSL connection you can not set password
                newUser.Invoke("SetPassword", new object[] { password });
                newUser.Properties["LockOutTime"].Value = 0;
                //Enable user
                int val = (int)newUser.Properties["userAccountControl"].Value;
                newUser.Properties["userAccountControl"].Value = val & ~0x2;
                // Saves The changes with Password
                newUser.CommitChanges();

                // Closing connection
                dirEntry.Close();

                // Closing connection
                newUser.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                return (E.ToString());
            }

            return null;
        }

       
    }
}
