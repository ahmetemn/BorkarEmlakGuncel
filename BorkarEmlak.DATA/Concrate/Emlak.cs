using BorkarEmlak.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.DATA.Concrate
{
    public  class Emlak:BaseEmlak
    {

        public string  Name { get; set; }

        public string  ImagePath { get; set; }

        public  double?  Lat { get; set; }

        public  double?  Lng { get; set; }

        public double? Price { get; set; }
        public  string Address { get; set; }
        public int CountryId { get; set; }
        public Country  Country { get; set; }
        public AppUser AppUser { get; set; }
        public int CityId { get; set; }
        public City City  { get; set; }

    }
}
