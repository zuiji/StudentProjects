using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;


namespace Miljø_AD_tool
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to read userinfo :\nPress 2 to addUser :\nPress any other buttons to stop : ");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            switch (inputFromUser)
            {
                case '1':
                    UserInfo();
                    break;

                case '2':
                    CreateUserAccount();
                    break;

                default:
                    break;
            }
        }

        public static void UserInfo()
        {
            Console.Write("Enter user: ");
            string username = Console.ReadLine();
            try
            {
                // create LDAP connection object  

                DirectoryEntry myLdapConnection = CreateDirectoryEntry();


                // create search object which operates on LDAP connection object  
                // and set search object to only find the user specified  

                DirectorySearcher search = new DirectorySearcher(myLdapConnection);
                //  search.Filter = $"(sAMAccountName= {username})";
                // create results objects from search object  

                SearchResult result = search.FindOne();
                if (result != null)
                {
                    // user exists, cycle through LDAP fields (cn, telephone number etc.)  

                    ResultPropertyCollection fields = result.Properties;

                    foreach (string ldapField in fields.PropertyNames)
                    {
                        // cycle through objects in each field e.g. group membership  
                        // (for many fields there will only be one object such as name)  

                        foreach (Object myCollection in fields[ldapField])
                            Console.WriteLine(string.Format("{0,-20} : {1}",
                                          ldapField, myCollection.ToString()));
                    }
                }

                else
                {
                    // user does not exist  
                    Console.WriteLine("User not found!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception caught:\n\n" + e.ToString());
            }
        }

        static DirectoryEntry CreateDirectoryEntry()
        {
            // create and return new LDAP connection with desired settings  

            DirectoryEntry ldapConnection = new DirectoryEntry("LDAP://192.168.20.2", "Administrator", "jmp1234!");
            ldapConnection.AuthenticationType = AuthenticationTypes.Secure;

            return ldapConnection;
        }
        public static void CreateUserAccount()
        {
            try
            {
                // Asking for Users First name and last name 
                Console.WriteLine("Please enter Firstname");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter LastName");
                string lastname = Console.ReadLine();

                // contains Standard Password. 
                string password = "User1234!";

                // adding a X if Users first name or last name is under 3 chars long. and its added to the right of his name.
                string loginName = firstName.PadRight(3, 'X').Substring(0, 3) + lastname.PadRight(3, 'X').Substring(0, 3);

                // collects firstname and lastname
                string fullname = $"{firstName} {lastname}";

                // Using LDAP connection object
                DirectoryEntry dirEntry = CreateDirectoryEntry();

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
                Console.WriteLine(E);
            }
        }

    }
}