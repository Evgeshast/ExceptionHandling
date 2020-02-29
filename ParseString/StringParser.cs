using System;

namespace ParseString
{
    public class StringParser
    {
        public int ParseToInt(string s)
        {
            const string LookupTable = "0123456789";

            int result = s.Aggregate(0, (accumulate, ch) =>
            {
                int charValue = LookupTable.IndexOf(ch);

                if (charValue == -1)
                {
                    throw new FormatException();
                }

                return accumulate = (accumulate * 10) + charValue;
            });
            return result;
        }
    }
}
