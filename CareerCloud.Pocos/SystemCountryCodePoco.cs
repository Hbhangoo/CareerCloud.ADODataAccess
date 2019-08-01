﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("System_Country_Codes")]
   public class SystemCountryCodePoco
    {
        [Key]
        public String Code { get; set; }
        public String Name { get; set; }
        public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles{ get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }

    }
}
