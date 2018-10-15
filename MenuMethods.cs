using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace buffteks_entites.models
{
    public class MenuMethods
    {
        public static void CreateNewRecord(){
            bool exitCommands = false;
            while (exitCommands == false){
                Console.WriteLine("Which database will this take place in?");
                Console.WriteLine("\t1. Students\n\t2. Teams\n\t3. Clients\n\t4. Orginizations\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        // Create a Student Record
                        Commands.CreateStudent();
                        break;
                    case 2:
                        // Create a Team Record
                        Commands.CreateTeam();
                        break;
                    case 3:
                        // Create a Client Record
                        Commands.CreateClient();
                        break;
                    case 4:
                        // Create an Orginization Record
                        Commands.CreateOginization();
                        break;
                    case 5:
                        // Exit Menu
                        exitCommands = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
      
        public static void UpdateARecord(){
            bool exitUpdate = false;
            while (exitUpdate == false){
                Console.WriteLine("Which database will this take place in?");
                Console.WriteLine("\t1. Students\n\t2. Teams\n\t3. Clients\n\t4. Orginizations\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        // Update a Student Record
                        Commands.UpdateStudent();
                        break;
                    case 2:
                        Commands.UpdateStudent();
                        break;
                    case 3:
                       Commands.UpdateStudent();
                        break;
                    case 4:
                        Commands.UpdateStudent();
                        break;
                    case 5:
                        // Exit Menu
                        exitUpdate = true;
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
