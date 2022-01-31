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
        // inspiration for the initial reverse from: https://www.educative.io/edpresso/how-to-reverse-the-order-of-words-in-a-sentence

        // flip the whole array
        ReverseWord(ref phrase);

        // Find and reverse each word within the array
        for (int start = 0; start < phrase.Length; start++)
        {
            if (phrase[start] == ' ')
                continue;

            for (int end = start; end < phrase.Length; end++)
            {
                if (phrase[end] == ' ' || end == phrase.Length - 1)
                {
                    if (end == phrase.Length - 1)
                    {
                        end++;
                    }
                    // perform swap
                    // alternative code Array.Reverse(phrase,i,(j-i))
                    for (int i = 0; i < (end - start) / 2; i++)
                    {
                        char temp = phrase[i + start];
                        phrase[i + start] = phrase[end - 1 - i];
                        phrase[end - 1 - i] = temp;
                    }

                    start = end;
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
