using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cause_fights.Models
{
    public class Cause
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Topic { get; set; }

        public string ImgPath { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Signature SignatureModel { get; set; }

        public virtual ICollection<Signature> Signatures { get; set; }
    }
}