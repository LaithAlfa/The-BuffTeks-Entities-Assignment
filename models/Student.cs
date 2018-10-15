using System;
namespace buffteks_entites
{
    public class Student
    {
         public int StudentID{ get; set; }
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
        // CIDM3350
        public string CIDM3350 {get; set;} 

        // 20191013 Create the FK Realtionship
        public int TeamID {get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}