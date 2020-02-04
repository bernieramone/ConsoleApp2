﻿namespace ConsoleApp2
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);

            }

            return inputString;
        }

        public static int AddTaxToTheValue(this int inputValue)
        {
            if (inputValue > 0)
            {
                inputValue += 10;
                return inputValue;
            }

            return inputValue;
        }
    }
}
