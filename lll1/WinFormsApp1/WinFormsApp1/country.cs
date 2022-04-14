using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Country
    {
        string countryCode;
        string countryName;

        //todo сделать через инициализацию

        public void Set(string countryCode, string countryName)
        {
            this.countryCode = countryCode;
            this.countryName = countryName;
        }
           
    }
}
