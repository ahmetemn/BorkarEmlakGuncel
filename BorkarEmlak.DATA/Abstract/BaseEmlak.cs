using BorkarEmlak.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.DATA.Abstract
{
    public  class BaseEmlak
    {

        public  int Id  { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DeletedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Status  Status  { get; set; }
    }
}
