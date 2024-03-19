using BorkarEmlak.DATA.Concrate;
using BorkarEmlak.REPO.Abstract;
using BorkarEmlak.REPO.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.REPO.Concrate
{
    public class EmlakREPO : BaseEmlakREPO<Emlak>, IEmlakREPO
    {
        public EmlakREPO(ApplicationContext applicationContext) : base(applicationContext)
        {

        }
    }
}
