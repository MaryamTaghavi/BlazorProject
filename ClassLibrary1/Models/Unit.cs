using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Unit
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
