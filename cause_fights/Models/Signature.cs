using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cause_fights.Models
{
    public class Signature
    {
        public int ID { get; set; }
        public int CauseID { get; set; }

        public int UserID { get; set; }

        public DateTime Signed_Date { get; set; }

        public virtual Cause Cause { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}