namespace Palindrome
{
    static class Palindrome
    {
        public static bool IsPalindrome(string sIn)
        {
            if (sIn == null || string.IsNullOrWhiteSpace(sIn))
            {
                return false;
            }

            //replace spaces to check multi word palindromes. ie. race car
            sIn = sIn.Replace(" ", string.Empty);

            for (var i = 0; i < sIn.Length / 2; i++)
            {
                if (sIn.Substring(i, 1) != sIn.Substring(sIn.Length - (i + 1), 1))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
