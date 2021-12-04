using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passGen
{
    class GenPassword
    {
        Random _r = new Random();

        private string _characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
        private string _lowerCase = "abcdefghijklmnopqrstuvwxyz";
        private string _upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _symbols= "%$#@";
        private string _numbers= "0123456789";
        private char _word;
        private string _password;
        
        public string genPass(int passLenght)
        {
            _password = string.Empty;

            for (int i = 0; i < passLenght; i++)
            {
                _word = _characters[_r.Next(_characters.Length)];
                _password += _word.ToString();
            }

            return _password;
        }

        public string genPass(int passLenght, bool s, bool n, bool u, bool l)
        {
            _password = string.Empty;

            string chars = string.Empty;

            if (s)
                chars += _symbols;
            if (n)
                chars += _numbers;
            if (u)
                chars += _upperCase;
            if (l)
                chars += _lowerCase;


            for (int i = 0; i < passLenght; i++)
            {
                if (chars == string.Empty)
                {
                    _password = "Check an option and try again";
                    break;
                }

                _word = chars[_r.Next(chars.Length)];
                _password += _word.ToString();
            }

            return _password;
        }
        
    }
}
