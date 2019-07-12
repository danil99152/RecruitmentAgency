using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class RequirmentMap : ClassMap<Requirment>
    {
        Id(c => c.Id).GeneratedBy.Identity();
            Map(c => c.Name).Length(30);
        HasManyToMany(r => r.Vacancies)
                .ParentKeyColumn("Requirment_id")
                .ChildKeyColumn("Vacancy_id");
    }
}