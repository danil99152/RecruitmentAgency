using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Models
{
    public class Photo
    {
        public virtual long PhotoId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Path { get; set; }

        public Photo()
        {

        }

        public Photo(string name, string path) : this()
        {
            Name = name;
            Path = path;
        }
    }
}