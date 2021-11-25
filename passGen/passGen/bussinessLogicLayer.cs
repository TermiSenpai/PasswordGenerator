using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passGen
{
    class bussinessLogicLayer
    {
        GenPassword _genPassword = new GenPassword();
        public string genPass(int passLenght, bool s, bool n, bool u, bool l)
        {
            string pass = _genPassword.genPass(passLenght, s, n, u, l);
            return pass;
        }

        public string genPass(int passLenght)
        {
            string pass = _genPassword.genPass(passLenght);
            return pass;
        }
    }
}
