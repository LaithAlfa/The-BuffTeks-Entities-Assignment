using System;
namespace buffteks_entites
{
    public class Client
    {
        public int ClientID{ get; set; }
        //First Name
        public string FirstName { get; set; }
        //Last name
        public string LastName { get; set; }        
        //phone
        public string PhoneNumber { get; set; }
        //email
        public string Email {get; set; }
        //role
        public string Role { get; set; }

        public Organization Organization { get; set; }
         public int OrganizationID { get; set; }
    }
}