using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Team1
    {
        string teamId;
        public string name;
        string abbr;
        string logo;

        public void set(string teamId, string name, string abbr, string logo)
        { this.teamId = teamId; 
          this.name = name;
          this.abbr = abbr; 
          this.logo = logo; }

    }
}

