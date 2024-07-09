using System.Text;

namespace Gmail_Suffix_Generator
{
    public class Suffix
    {
        private const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private const string gmail = "@gmail.com";
        private const char suffix = '+';


        private static string CreateSuffix(int length)
        {
            StringBuilder stringBuilder = new();
            Random random = new();
            while (0 < length--)
            {
                stringBuilder.Append(valid[random.Next(valid.Length)]);
            }
            return stringBuilder.ToString();
        }

        public static string GeneratorEmail(string email, int lengthAddToEmail, int countGeneratorEmail)
        {
            StringBuilder stringBuilder = new();

            if (CheckEmailValid(email))
            {
                if (countGeneratorEmail > 0)
                {
                    for (int i = 0; i < countGeneratorEmail; i++)
                    {
                        stringBuilder.Append(InitializationEmail(email));
                        stringBuilder.Append(suffix);
                        stringBuilder.Append(CreateSuffix(lengthAddToEmail));
                        stringBuilder.Append(gmail);
                        stringBuilder.Append(Environment.NewLine);
                    }
                }
                else { throw new Exception("Count Generator Email Invalid\n"); }
            }
            else throw new Exception("Email Invalid\n");

            return stringBuilder.ToString();
        }

        private static bool CheckEmailValid(string email)
        {
            if (!string.IsNullOrEmpty(email) && email.Contains('@'))
                return true;
            else 
                return false;
        }

        private static string InitializationEmail(string email)
        {
            int indexRemove = email.IndexOf('@');
            return email[..indexRemove];
        }
    }
}
