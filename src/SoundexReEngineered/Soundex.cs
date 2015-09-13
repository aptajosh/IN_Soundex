using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoundexCore
{
    public class Soundex
    {
        string name;
        
        //Soundex to return
        private string _soundex;

        public Soundex(string name)
        {
            this.name = name;
        }

        public string IN_Soundex
        {
            get { return this.getSoundex(name); }
        }

        string getSoundex(string name)
        {
            name = name.Trim();
            name = name.ToLower();
            name = RegexHelp.regTriples.Replace(name, RegexHelp.evalTriples);
            name = RegexHelp.regDoubles.Replace(name, RegexHelp.evalDoubles);
            name = RegexHelp.regSingle.Replace(name, RegexHelp.evalSingle);
            return name;
        }
    }
}
  

    

