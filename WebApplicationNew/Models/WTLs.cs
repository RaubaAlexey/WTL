using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Models
{
    public class WTLs
    {
        public int Id { get; set; }
        public String Name{ get; set; }
        public DateTime Monday { get; set; }
        public DateTime Tuesday { get; set; }
        public DateTime Wednesday { get; set; }
        public DateTime Thursday { get; set; }
        public DateTime Friday { get; set; }
        public DateTime Saturday { get; set; }
        public DateTime Sunday { get; set; }
    }
}