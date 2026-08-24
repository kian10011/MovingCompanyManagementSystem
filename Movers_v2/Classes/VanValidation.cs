using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class VanValidation
    {


        public static string ValidateRegistrationPlate(string regPlate)
        {

            // Trim any unnecessary spaces
            regPlate = regPlate.Trim();

            // Check the length of the registration plate
            if (regPlate.Length < 5 || regPlate.Length > 8) // ABC 1234 has a min of 4 and max of 8 characters
            {
                return "The registration plate must be between 4 and 7 characters long.";

            }

            // Split the string into parts (by the space)
            string[] parts = regPlate.Split(' ');

            // Ensure the registration plate has exactly two parts (letters and numbers)
            if (parts.Length != 2)
            {
                return "The registration plate must consist of two parts: letters and numbers separated by a space.";
            }

            string lettersPart = parts[0];
            string numbersPart = parts[1];

            // Validate the letters part (exactly three uppercase letters)
            if (lettersPart.Length != 3 || !IsAllUppercaseLetters(lettersPart))
            {
                return "The first part of the registration plate must contain exactly three uppercase letters.";
            }

            // Validate the numbers part (1 to 4 digits)
            if (numbersPart.Length < 1 || numbersPart.Length > 4)
            {
                return "The first part of the registration plate must contain only uppercase letters (A-Z).";
            }

            //check that the second part are all digits.
            if (!IsAllDigits(numbersPart))
            {
                return "The second part of the registration plate must contain only numeric digits (0-9).";
            }
            // If all checks pass, return true
            return " ";
        }


        // Checks if a string contains only uppercase letters.

        private static bool IsAllUppercaseLetters(string input)
        {
            foreach (char c in input)
            {
                if (c < 'A' || c > 'Z')
                {
                    return false;
                }
            }
            return true;
        }


        // Checks if a string contains only digits.

        private static bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }

}
