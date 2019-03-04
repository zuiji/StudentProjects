using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljø_AD_tool
{
    class GetUserInfo
    {
        public static string UserInfo(string userName, DirectoryEntry createDirectoryEntry)
        {

            try
            {
                // create LDAP connection object  

                DirectoryEntry myLdapConnection = createDirectoryEntry;


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
                    return "User not found!";
                }
            }

            catch (Exception e)
            {
                return ("Exception caught:\n\n" + e.ToString());
            }

            return null;
        }

       
    }
}
