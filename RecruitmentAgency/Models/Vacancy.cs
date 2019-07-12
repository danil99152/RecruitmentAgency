using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Vacancy
    {
        public virtual long Id { get; set; }

        [DisplayName("Название")]
        public virtual string Name { get; set; }

        [DisplayName("Дата начала работы")]
        public virtual DateTime StartWorking { get; set; }

        [DisplayName("Дата конца работы")]
        public virtual DateTime EndWorking { get; set; }

        [DisplayName("Название компании")]
        public virtual string Company { get; set; }

        [DisplayName("Необходимы навыки")]
        public virtual ICollection<Requirment> Requirments { get; set; }

        [DisplayName("Предпологаемая зарплата")]
        public virtual int Salary { get; set; }

        public Vacancy()
        {
            Requirments = new List<Requirment>();
        }

        public Vacancy(string vacName) : this()
        {
            Name = vacName;
        }
    }
}