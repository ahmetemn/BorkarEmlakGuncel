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
    public class CountryREPO : BaseEmlakREPO<Country>, ICountryREPO
    {
        public CountryREPO(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public List<Country> IlkOnGetir()
        {
            throw new NotImplementedException();
        }
    }
}
