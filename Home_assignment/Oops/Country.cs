using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Oops
{
    class Country
    {
        /* public string countryname;
         public string countrycapital;
         public int nooflanguage;
         public long population;

         public string Countryname

               set { Countryname=value; }
               get {retuen Countryname;}*/
        int _mark;
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (_mark > 0) _mark = value;
                else _mark = 0;


            }


        }    

                                             }
}
