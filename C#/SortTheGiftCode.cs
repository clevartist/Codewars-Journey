public class Kata
{
    public static string SortGiftCode(string code)
    {
        char[] charArray = code.ToCharArray();

        int n = charArray.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (charArray[j] > charArray[j + 1])
                {
                    char temp = charArray[j];
                    charArray[j] = charArray[j + 1];
                    charArray[j + 1] = temp;
                }
            }
        }

        return new string(charArray);
    }
}
