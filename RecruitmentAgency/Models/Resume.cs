using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Resume
    {
        public virtual long ResumeId { get; set; }

        public virtual Candidate FIO { get; set; }

        public virtual Candidate Birthday { get; set; }

        public virtual Candidate PastPlaces { get; set; }

        public virtual Candidate Photo { get; set; }
    }
}