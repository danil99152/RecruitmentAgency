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
        public virtual long CandidateId { get; set; }

        [DisplayName("Ваше Фамилия, Имя и Отчество(если имеется)")]
        [Required]
        public virtual string FIO { get; set; }

        [DisplayName("Ваша дата рождения")]
        [Required]
        public virtual string Birthday { get; set; }

        [DisplayName("Напишите прошлые места работы")]
        [Required]
        public virtual string PastPlaces { get; set; }

        [DisplayName("Загрузите ваше фото")]
        public virtual Photo Photos { get; set; }
     //   [DisplayName("В каком формате вы хотите файл")]
    //    public virtual string Type { get; set; }
    }
}