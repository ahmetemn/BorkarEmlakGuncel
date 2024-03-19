using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.DATA.Concrate
{
    public  class AppUser:IdentityUser
    {

        public ICollection<Emlak>  Emlaks{ get; set; }
    }
}
