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

            Userinfo();
            Console.ReadLine();
        }

        public static void Userinfo()
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
                search.Filter = "(cn=" + username + ")";

                // create results objects from search object  

                SearchResult result = search.FindOne();

                if (result != null)
                {
                    // user exists, cycle through LDAP fields (cn, telephonenumber etc.)  

                    ResultPropertyCollection fields = result.Properties;

                    foreach (String ldapField in fields.PropertyNames)
                    {
                        // cycle through objects in each field e.g. group membership  
                        // (for many fields there will only be one object such as name)  

                        foreach (Object myCollection in fields[ldapField])
                            Console.WriteLine(String.Format("{0,-20} : {1}",
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
    }
} 