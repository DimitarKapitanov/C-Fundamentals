using System;

namespace _4_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            IsInRange(password);
            IsDigitOrLetter(password);
            HaveTwoDigits(password);

            if (IsInRange(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (IsDigitOrLetter(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (HaveTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(IsInRange(password) == true && IsDigitOrLetter(password) == true && HaveTwoDigits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool IsInRange(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool IsDigitOrLetter(string password)
        {
            foreach (char simbol in password)
            {
                if (!char.IsLetterOrDigit(simbol))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HaveTwoDigits(string password)
        {
            int count = 0;
            foreach (var simbol in password)
            {
                if (char.IsDigit(simbol))
                {
                    count++;
                    if (count == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
