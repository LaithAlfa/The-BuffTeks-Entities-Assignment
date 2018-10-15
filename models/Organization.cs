using System;
using System.ComponentModel.DataAnnotations;

namespace buffteks_entites
{
    public class Organization
    {
        [Key]
        public int OrgID{ get; set; }
        public string OrgName { get; set; }
        public String OrgPhone { get; set; }
        

        public override string ToString()
        {
            return $"{OrgName} - {OrgPhone}";
        }

    }
}