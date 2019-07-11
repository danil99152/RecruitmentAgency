using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Vacancy
    {
        public virtual long VacancyId { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime StartWorking { get; set; }

        public virtual DateTime EndWorking { get; set; }

        public virtual string Company { get; set; }

        public virtual ICollection<Requirment> Requirments { get; set; }

        public virtual int Salary { get; set; }
    }
}