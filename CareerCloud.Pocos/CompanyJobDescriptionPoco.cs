﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{

    [Table("Company_Jobs_Descriptions")]
   public class CompanyJobDescriptionPoco:IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        [Column("Job_Name")]
        public String JobName { get; set; }
        [Column("Job_Descriptions")]
        public String JobDescriptions { get; set; }
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual CompanyJobPoco CompanyJobs { get; set; }
    }
}
