using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Requirment
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<Vacancy> Vacancies { get; set; }

        public Requirment()
        {
            Vacancies = new List<Vacancy>();
        }

        public Requirment(string requirmentName) : this()
        {
            Name = requirmentName;
        }
    }
}