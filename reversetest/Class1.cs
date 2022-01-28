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
