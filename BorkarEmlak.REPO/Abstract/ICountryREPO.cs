﻿using BorkarEmlak.DATA.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.REPO.Abstract
{
    public  interface ICountryREPO:IBaseEmlakREPO<Country>
    {
        public List<Country> IlkOnGetir();

    }
}
