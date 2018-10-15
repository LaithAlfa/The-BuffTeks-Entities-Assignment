using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace buffteks_entites.models
{
    public class SeedDatabase
    {
        public static void Seed(){
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any() && !db.Teams.Any())
                    {
                        // Create a new list for "Teams" named as a database "teams"
                        List<Team> teams = new List<Team>()
                        {
                            new Team() {TeamID = 1, TeamName = "Team 1", TeamDescription = "This is the 1st Team"},
                            new Team() {TeamID = 2, TeamName = "Team 2", TeamDescription = "This is the 2nd Team"},
                            new Team() {TeamID = 3, TeamName = "Team 3", TeamDescription = "This is the 3rd Team"}
                        };

                        db.Teams.AddRange(teams);

                        // Create a new list for "Students" named as a database "students"
                        List<Student> students = new List<Student>()
                        {
                            new Student() {FirstName = "Laith", LastName = "Alfaloujeh", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Mekkala", LastName = "Bourape", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Charles", LastName = "Coufal", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "John", LastName = "Cunningham", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 1},
                            new Student() {FirstName = "Michael", LastName = "Hayes", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 2},
                            new Student() {FirstName = "Aaron", LastName = "Hebert", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 3},
                            new Student() {FirstName = "Yi Fu", LastName = "Ji", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Todd", LastName = "Kile", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Mara", LastName = "Kinoff", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "Cesareo", LastName = "Lona", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 1},
                            new Student() {FirstName = "Michael", LastName = "Matthews", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 2},
                            new Student() {FirstName = "Mason", LastName = "McCollum", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 3},
                            new Student() {FirstName = "Alexander", LastName = "McDonald", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Phelps", LastName = "Merrell", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Quan", LastName = "Nguyen", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "Alexander", LastName = "Roder", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 1},
                            new Student() {FirstName = "Amy", LastName = "Saysourinyosack", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 2},
                            new Student() {FirstName = "Claudia", LastName = "Silva", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 3},
                            new Student() {FirstName = "Gabriela", LastName = "Valenzuela", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Kayla", LastName = "Washington", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Matthew", LastName = "Webb", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "Cory", LastName = "Williams", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 1},         
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                      
                    }
                  


                if (!db.Clients.Any() && !db.Organizations.Any()){
                    // Create a new list for "Organizations" named as a database "organizations"

                    List<Organization> orginizations = new List<Organization>()
                    {
                        new Organization() {OrgID = 1, OrgName = "Amarillo College", OrgPhone = "123-345-4566"},
                        new Organization() {OrgID = 2, OrgName = "Happy State Bank", OrgPhone = "234-767-4333"},
                        new Organization() {OrgID = 3, OrgName = "Chase Bank", OrgPhone = "313-454-2333"},
                        new Organization() {OrgID = 4, OrgName = "BSA", OrgPhone = "128-588-9043"},
                       
                    };
                    db.Organizations.AddRange(orginizations);

                    db.SaveChanges();

                    // Create a new list for "Clients" named as a database "clients"
                    List<Client> clients = new List<Client>(){
                        new Client() {FirstName = "Jeffry", LastName = "Babb", PhoneNumber = "123-456-7890", Email = "jbabb@wtamu.edu", Role = "Professor", OrganizationID = 1},
                        new Client() {FirstName = "Jack", LastName = "Glover", PhoneNumber = "123-456-7890", Email = "jglover@wtamu.edu", Role = "CEO", OrganizationID = 1},
                        new Client() {FirstName = "Carron", LastName = "Sanders", PhoneNumber = "123-456-7890", Email = "csandersl@mail.com", Role = "Software Devolper", OrganizationID = 2},
                        new Client() {FirstName = "Michael", LastName = "smith", PhoneNumber = "123-456-7890", Email = "gwoodward@wtsbdc.com", Role = "Consultant", OrganizationID = 4},

                    };
                    db.Clients.AddRange(clients);

                    db.SaveChanges();
                    
                }
                  
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            Console.WriteLine("DATABASE HAS BEEN SEEDED.");
        }
    }
}