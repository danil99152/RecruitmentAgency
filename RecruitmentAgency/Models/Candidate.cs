using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Candidate
    {
        public virtual long Id { get; set; }

        [Display(Name = "Логин")]
        [Required]
        public virtual string UserName { get; set; }

        public virtual string Password { get; set; }

        [DisplayName("Ваша дата рождения")]
        [Required]
        public virtual string Birthday { get; set; }

        [DisplayName("Напишите прошлые места работы")]
        [Required]
        public virtual string PastPlaces { get; set; }

        [DisplayName("Загрузите ваше фото")]
        public virtual string PhotoPath { get; set; }

    }
}