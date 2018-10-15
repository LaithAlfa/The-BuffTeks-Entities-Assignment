using System;
namespace buffteks_entites
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName {get; set; }
        public int ProjectHours { get; set; }
        public string ProjectLeader { get; set; }
        public DateTime DeadLine { get; set; }
        public DateTime StartLine { get; set; }
        public string ProjectDesc { get; set;}
        public int ProjectClient { get; set; }


         public int ClientID { get; set; }
        public Client Client { get; set; }
        
    }
}