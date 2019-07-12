using NHibernate;
using RecruitmentAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Repositories
{
    public class VacancyRepository : Repository<Vacancy>
    {
        public VacancyRepository(ISession session) : base(session)
        {
        }
    }
}