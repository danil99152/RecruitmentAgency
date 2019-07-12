using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class VacancyMap : ClassMap<Vacancy>
    {
        Id(v => v.Id).GeneratedBy.Identity();
            Map(v => v.Name).Length(30);
            Map(v => v.StartWorking);
        Map(v => v.EndWorking);
        Map(v => v.Company).Length(30);
            HasManyToMany(v => v.Requirments)
                .ParentKeyColumn("Vacancy_id")
                .ChildKeyColumn("Requirment_id");
        Map(v => v.Salary);
    }
}