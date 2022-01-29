namespace reversetest;
public static class ReverseTest
{

    public static void ReverseWord(ref char[] word)
    {
        // flip the chars
        // had to put /2 on it to prevent it from un-flipping chars.
        for (int i = 0; i < word.Length / 2; i++)
        {
            char temp = word[i];
            word[i] = word[word.Length - 1 - i];
            word[word.Length - 1 - i] = temp;
        }
    }

    public static void ReversePhrase(ref char[] phrase)
    {
        // flip the whole array
        ReverseWord(ref phrase);

        // Find and reverse each word within the array
        for (int i = 0; i < phrase.Length; i++)
        {
            if (phrase[i] == ' ')
                continue;

            for (int j = i; j < phrase.Length; j++)
            {
                if (phrase[j] == ' ' || j == phrase.Length - 1)
                {
                    if (j == phrase.Length - 1)
                    {
                        j++;
                    }
                    // perform swap
                    for (int k = 0; k < (j - i) / 2; k++)
                    {
                        char temp = phrase[k + i];
                        phrase[k + i] = phrase[j - 1 - k];
                        phrase[j - 1 - k] = temp;
                    }

                    i = j;
                    break;
                }
            }
        }
    }

    [Obsolete]
    public static void ReversePhraseOld(ref char[] phrase)
    {
        // if mutating the phrase, then find length of end word, save word to variable
        // shift right the length of the word and space and insert the word and a space.

        char[] newPhrase = new char[phrase.Length];
        Array.Fill(newPhrase, ' ');
        int cursor = 0;
        for (int i = phrase.Length - 1; i >= 0; i--)
        {
            if (phrase[i] != ' ' && i != 0)
                continue;

            if (i != 0)
            {
                char[] word = phrase[(i + 1)..(phrase.Length - cursor)];
                foreach (var let in word)
                {
                    newPhrase[cursor] = let;
                    cursor++;
                }
                cursor++;
            }
            else
            {
                char[] word = phrase[i..(phrase.Length - cursor)];
                foreach (var let in word)
                {
                    newPhrase[cursor] = let;
                    cursor++;
                }
            }

        }
        phrase = newPhrase;
    }
}
