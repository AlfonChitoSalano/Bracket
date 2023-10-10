namespace BracketPoc;

public static class Bracket
{
    public static bool Check(string arguments)
    {
        var count = 0;

        foreach (var character in arguments)
        {
            switch (character)
            {
                case '<':
                    count++;
                    break;
                case '>':
                {
                    count--;

                    if (count < 0)
                    {
                        return false;
                    }

                    break;
                }
            }
        }

        return count == 0;
    }
}