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

    [Theory]
    [InlineData("wolters", "sretlow")]
    [InlineData("whodunit", "tinudohw")]
    public void WordShouldReverse(string value, string expected)
    {
        char[] chars = value.ToCharArray();

        ReverseTest.ReverseWord(ref chars);

        Assert.Equal(expected.ToCharArray(), chars);
    }
}
