namespace LeetCode.Problems.TwoPointers;

public class StringCompressionProblem
{
    public int Compress(ref char[] chars)
    {
        var i = 0;
        int result = 0;

        while (i < chars.Length)
        {
            int groupLength = 1;

            while (i + groupLength < chars.Length && chars[i + groupLength] == chars[i])
            {
                groupLength++;
            }

            chars[result++] = chars[i];

            if (groupLength > 1)
            {
                foreach (char c in groupLength.ToString())
                {
                    chars[result++] = c;
                }
            }

            i += groupLength;
        }

        return result;
    }

    //public int Compress(ref char[] chars)
    //{
    //    var i = 0;
    //    var j = 0;

    //    while (i < chars.Length)
    //    {
    //        var current = chars[i];
    //        var counter = 0;

    //        while (i < chars.Length && chars[i] == current)
    //        {
    //            i++;
    //            counter++;
    //        }

    //        chars[j++] = current;

    //        if (counter > 1)
    //        {
    //            foreach (var counterChar in counter.ToString())
    //            {
    //                chars[j++] = counterChar;
    //            }
    //        }
    //    }

    //    return j;
    //}
}