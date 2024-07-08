using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Suffix_Generator
{
    public class Suffix
    {
        private const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        private string CreatePlusEmail(int length)
        {
            StringBuilder _stringBuilder = new();
            Random _random = new(); 
            while (0 < length--)
            {
                _stringBuilder.Append(valid[_random.Next(valid.Length)]);
            }
            return _stringBuilder.ToString();
        }

        public string GeneratorEmail(string email, int lengthAddToEmail, int countGeneratorEmail)
        {
            if(!string.IsNullOrEmpty(email) && email.Contains('@'))
            {
                StringBuilder _stringBuilder = new();
                int indexRemove = email.IndexOf('@');
                string newemial = email[..indexRemove];

                if (countGeneratorEmail > 0)
                {
                    for (int i = 0; i < countGeneratorEmail; i++)
                    {
                        string result = CreatePlusEmail(lengthAddToEmail);
                        string newEmail = $"{newemial}+{result}@gmail.com";
                        _stringBuilder.Append(newEmail + Environment.NewLine);
                    }
                }
                else { return "Count Generator Email Invalid\n"; }
                return _stringBuilder.ToString();
            }
            else { return "Email Invalid\n"; }
        }
    }
}
