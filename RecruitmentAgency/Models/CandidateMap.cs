using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class CandidateMap : ClassMap<Candidate>
    {
            Id(c => c.Id).GeneratedBy.Identity();
            Map(c => c.UserName).Length(30);
            Map(c => c.Password).Column("PasswordHash");
            Map(c => c.Birthday);
            Map(c => c.PastPlaces);
            Map(c => c.PhotoPath);
    }
}