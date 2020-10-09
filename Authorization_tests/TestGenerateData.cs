using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization_tests
{
    class TestGenerateData
    {
        public static string Generate_random_string(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            char symbol;

            for (int i = 0; i < size; i++)
            {
                symbol = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(symbol);
            }

            if (lowerCase)
                return stringBuilder.ToString().ToLower();

            return stringBuilder.ToString();
        }

        public static string Generate_random_mail(string nameDomen, int size = 10)
        {
            string randomEmail = Generate_random_string(size) + nameDomen;
            return randomEmail;
        }

        public static string Generate_random_data(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string data = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                data += (char)array[i];
            }

            return data;
        }

        public static string Generate_random_password(int size)
        {
            string randomPassword = Generate_random_data(size);

            return randomPassword;
        }

        public static int Generate_random_number(int minValue, int maxValue)
        {
            var random = new Random();

            return random.Next(minValue, maxValue);
        }

        public static string Generate_random_phone_number(string countryCode, int country)
        {
            var random = new Random();
            int[] array = new int[country];
            string phoneNumber = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                phoneNumber += array[i];
            }

            phoneNumber = countryCode + phoneNumber;

            return phoneNumber;
        }
    }
}
