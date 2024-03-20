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
    public class CountryService : BaseEmlakSERVICE<Country>, ICountryService
    {
        public CountryService(IBaseEmlakREPO<Country> context) : base(context)
        {
        }
    }
}
