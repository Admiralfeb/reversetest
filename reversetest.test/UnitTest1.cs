using Xunit;

namespace reversetest.test;

public class UnitTest1
{
    [Fact]
    public void PhraseShouldReverse()
    {
        string phrase = "It is cold today";
        char[] chars = phrase.ToCharArray();

        ReverseTest.ReversePhrase(ref chars);

        Assert.Equal("today cold is It".ToCharArray(), chars);
    }

    [Fact]
    public void WordShouldReverse()
    {
        string word = "wolters";
        char[] chars = word.ToCharArray();

        ReverseTest.ReverseWord(ref chars);

        Assert.Equal("sretlow".ToCharArray(), chars);
    }
}
