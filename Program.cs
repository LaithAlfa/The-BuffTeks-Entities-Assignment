using System;
using System.Collections.Generic;
using System.Linq;
using buffteks_entites.models;

namespace buffteks_entites
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seed the database for initial tables
            SeedDatabase.Seed(); 
            
            // Initialize Menu Commands and Options to the Console
            bool endMenu = false;
            while(endMenu == false){
                Console.WriteLine("Please select a command");
                Console.WriteLine("\t1. Create Record\n\t2. Read Record\n\t3. Update Record\n\t4. Delete Record\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command){
                    case 1:
                        // Create a record
                        MenuMethods.CreateNewRecord();
                        break;
                    
                    case 2:
                        // Update a record
                        Console.WriteLine("Command not yet established.");
                        break;
                    case 3:
                        // Delete a record
                        Console.WriteLine("Command not yet established.");
                        break;
                    case 4:
                        // Exit the program
                        endMenu = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
    }
}