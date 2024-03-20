using BorkarEmlak.DATA.Concrate;
using BorkarEmlak.REPO.Abstract;
using BorkarEmlak.SERVICE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.SERVICE.Concrate
{
    public class EmlakService : BaseEmlakSERVICE<Emlak>, IEmlakService
    {
        public EmlakService(IBaseEmlakREPO<Emlak> context) : base(context)
        {
        }
    }
}
