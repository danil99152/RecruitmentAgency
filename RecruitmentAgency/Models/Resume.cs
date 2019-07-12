using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Resume : Candidate
    {
        public virtual long ResumeId { get; set; }

        [DisplayName("В каком формате вы хотите файл")]
        public virtual string Type { get; set; }
    }
}