namespace StringFormatterTests;

using StringFormatter;

public class StringFormatterTests
{
    [Fact]
    public void ReplaceSpaces_BasicCase()
    {
        // arange
        string input = "Предупреждение!    Забирать    потоки с  камер напрямую                                                         только      \nпри                                       особой   необходимости.\n";
        string expected = "Предупреждение! Забирать потоки с камер напрямую только \nпри особой необходимости.\n";

        // act
        string actual = StringFormatter.ReplaceSpaces(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReplaceSpaces_LeadingSpaces()
    {
        // arange
        string input = "    Hello, World!";
        string expected = " Hello, World!";

        // act
        string actual = StringFormatter.ReplaceSpaces(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReplaceSpaces_TrailingSpaces()
    {
        // arange
        string input = "Hello, World!        ";
        string expected = "Hello, World! ";

        // act
        string actual = StringFormatter.ReplaceSpaces(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReplaceSpaces_SpacesWithNewLines()
    {
        // arange
        string input = "Hello,          \n           World!";
        string expected = "Hello, \n World!";

        // act
        string actual = StringFormatter.ReplaceSpaces(input);

        // assert
        Assert.Equal(expected, actual);
    }
}
