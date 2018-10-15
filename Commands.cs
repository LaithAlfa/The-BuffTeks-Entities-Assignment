using System;
using System.Collections.Generic;
using System.Linq;
using buffteks_entites.models;
using Microsoft.EntityFrameworkCore;


namespace buffteks_entites
{
    class Commands
    {
                   public static void CreateStudent(){
                    // Pull Student FName
                    Console.Write("First Name: ");
                    string StuFName = Console.ReadLine();
                    // Pull Student LName
                    Console.Write("Last Name: ");
                    string StuLName = Console.ReadLine();
                    // Pull Student Phone Number
                    Console.Write("Phone Number: ");
                    string StuPhone = Console.ReadLine();
                    // Pull Student Email
                    Console.Write("Email: ");
                    string StuMail = Console.ReadLine();
                    // Pull Student Role
                    Console.Write("Role: ");
                    string StuRole = Console.ReadLine();
                    // Apply Student Team
                    Console.Write("Student Team ID: ");
                    int TeamID = Convert.ToInt32(Console.ReadLine());
                    // Input into the database
                    using(var db = new AppDbContext()){
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = StuFName,
                                LastName = StuLName,
                                PhoneNumber = StuPhone,
                                Email = StuMail,
                                Role = StuRole,
                                TeamID = TeamID
                            }
                        };
                        db.Students.AddRange(students);
                        db.SaveChanges();
                        }
                        Console.WriteLine("Record has been added successfully.");
            }

         public static void CreateTeam(){
            // Pull TeamID
            Console.Write("Team ID: ");
            int tID = Convert.ToInt32(Console.ReadLine());
            // Pull TeamName
            Console.Write("Team Name: ");
            string tName = Console.ReadLine();
            // Pull TeamDescription
            Console.Write("Team Description: ");
            string tDescription = Console.ReadLine();
            // Input into the database
           using(var db = new AppDbContext()){
               List<Team> teams = new List<Team>()
               {
                   new Team()
                   {
                       TeamID = tID,
                       TeamName = tName,
                       TeamDescription = tDescription
                   }
               };
               db.Teams.AddRange(teams);
               db.SaveChanges();
           }
           Console.WriteLine("Record has been added successfully.");
        }

          public static void CreateOginization(){
        // Pull OrgID
        Console.Write("Orginization ID: ");
        int oID = Convert.ToInt32(Console.ReadLine());
        // Pull OrgName
        Console.Write("Orginization Name: ");
        string oName = Console.ReadLine();
        // Pull OrgDescription
        Console.Write("Organization Description: ");
        string oPhone = Console.ReadLine();
        // Input into the database
        using(var db = new AppDbContext()){
            List<Organization> organizations = new List<Organization>()
            {
                new Organization()
                {
                    OrgID = oID,
                    OrgName = oName,
                    OrgPhone = oPhone
                }
            };
            db.Organizations.AddRange(organizations);
            db.SaveChanges();
            }
            Console.WriteLine("Record has been added successfully.");
        }
        public static void CreateClient(){
        // Pull ClientID
        Console.Write("Client ID: ");
        int cID = Convert.ToInt32(Console.ReadLine());
        // Pull Client First Name
        Console.Write("First Name: ");
        string cFName = Console.ReadLine();
        // Pull Client Last Name
        Console.Write("Last Name: ");
        string cLName = Console.ReadLine();
        // Pull Client Phone Number
        Console.Write("Phone Number: ");
        string cPhone = Console.ReadLine();
        // Pull Client Email
        Console.Write("Email: ");
        string cMail = Console.ReadLine();
        // Pull Client Role
        Console.Write("Role: ");
        string cRole = Console.ReadLine();
        // Apply orginization
        Console.Write("Orginization ID: ");
        int cOrg = Convert.ToInt32(Console.ReadLine());
        // Input into the database
        using(var db = new AppDbContext()){
            List<Client> clients= new List<Client>()
            {
                new Client()
                {
                    ClientID = cID,
                    FirstName= cFName,
                    LastName = cLName,
                    PhoneNumber = cPhone,
                    Email = cMail,
                    Role = cRole,
                    OrganizationID = cOrg
                }
            };
            db.Clients.AddRange(clients);
            db.SaveChanges();
            }
            Console.WriteLine("Record has been added successfully.");
        }
    
     
        // Update Student Phone #
        public static void UpdateStudent()
        {
            using (var context = new AppDbContext())
            {
                var student = context.Students;
                if (!student.Any())
                {
                    Console.WriteLine("No students in the database\n");
                }
                else
                {
                    
                    Console.Write("\nEnter the ID of the student's phone # you want to update: ");
                    var studentToUpdate = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter the new phone #: ");
                    var newPhoneNumber = Console.ReadLine();

                    foreach (var s in student.Where(id => id.StudentID == studentToUpdate))
                    {
                        s.PhoneNumber = newPhoneNumber;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Phone recored has been updated");
                }

            }
        }

          

        private static void UpdateOrganization()
        {
            using (var context = new AppDbContext())
            {
                var organization = context.Projects.Include(c => c.Client).ThenInclude(o => o.Organization);

                if (!organization.Any())
                {
                    Console.WriteLine("No records in the database to update\n");
                }
                else
                {
                    
                    Console.WriteLine();
                    Console.Write("\nEnter the ID of the organization's phone # you want to update: ");
                    var organizationToUpdate = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter the new phone #: ");
                    var newPhoneNumber = Console.ReadLine();

                    foreach (var o in organization.Where(id => id.Client.OrganizationID == organizationToUpdate))
                    {
                        o.Client.Organization. OrgPhone = newPhoneNumber;
                    }

                    context.SaveChanges();
                    Console.WriteLine($"Phone recored has been updated");
            }

        }
}

        public static void teamsSort()
        {
            using(var db = new AppDbContext())
            {
                var teams = db.Teams.ToList();
                Console.WriteLine(">>Here are the teams sorted Decending<<");
                var teamsDecending = teams.OrderByDescending(x => x.TeamName);
                foreach(Team t in teamsDecending)
                {
                    Console.WriteLine(t);
                }
            }
        }
        public static void studentGroup()
        {
            using(var db = new AppDbContext())
            {
            var students = db.Students.ToList();
            var studentsByRole = students.OrderByDescending(x => x.Role);
            foreach(Student t in studentsByRole)
            {
                    Console.WriteLine(t);
            }
            }
        }












    }
    





}

